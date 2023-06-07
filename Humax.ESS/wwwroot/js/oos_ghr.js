var FileStoreIndex = 0;
var notifyTimer;

var DXEventMonitor = {
    TimerId: -1,
    PendingUpdates: [],

    Trace: function (namestr, value)
    {
        var self = DXEventMonitor;
        var builder = ["<table>"];
        self.BuildTraceRowHtml(builder, namestr, value, 0);

        builder.push("</table><br />");
        self.PendingUpdates.unshift(builder.join(""));
        if (self.TimerId < 0)
            self.TimerId = window.setTimeout(self.Update, 0);
    },

    BuildTraceRowHtml: function (builder, name, text, width) {
        builder.push("<tr><td valign=top");
        if (width)
            builder.push(" style='width: ", width, "px'");
        builder.push(">");
        if (name)
            builder.push("<b>", name, ":</b>");
        builder.push("</td><td valign=top>", text, "</td></tr>");
    },

    GetLogElement: function () {
        return document.getElementById("EventLog")
    },

    Update: function () {
        var self = DXEventMonitor;
        var element = self.GetLogElement();

        element.innerHTML = self.PendingUpdates.join("") + element.innerHTML;
        self.TimerId = -1;
        self.PendingUpdates = [];
    },

    Clear: function () {
        DXEventMonitor.GetLogElement().innerHTML = "";
    },

    EscapeHtml: function (str) {
        return str.replace(/&/g, '&amp;').replace(/"/g, '&quot;').replace(/'/g, '&#39;').replace(/</g, '&lt;').replace(/>/g, '&gt;');
    }
};

var OOSCore = {
    OpenPopup: function (url, title, w, h) {
        var left = Math.round((screen.width / 2) - (w / 2));
        var top = Math.round((screen.height / 2) - (h / 2));
        return window.open(url, title, 'toolbar=no, location=no, directories=no, status=no, '
            + 'menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=' + w
            + ', height=' + h + ', top=' + top + ', left=' + left);
    },
    OpenImportPopup: function (url, title) {
        var w = 900;
        var h = 700;
        var left = Math.round((screen.width / 2) - (w / 2));
        var top = Math.round((screen.height / 2) - (h / 2));
        return window.open(url, title, 'toolbar=no, location=no, directories=no, status=no, '
            + 'menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=' + w
            + ', height=' + h + ', top=' + top + ', left=' + left);
    },
    Call_Ajax_Function: function (Url, Params, refCallback) {
        $.ajax({
            type: "GET",
            cache: false,
            url: Url,
            data: Params,
            headers: { '__RequestVerificationToken':OOSCore.VerificationToken() },
            success: function (res) {
                refCallback(res);
            },
            error: function (xhr, ajaxOptions, thrownError) {
            }
        });
    },
    Call_Ajax_Function_POST: function (Url, Params, refCallback) {
        var header = $("#__RequestVerificationToken").val();
        if (refCallback === '') {
            $.ajax({
                type: "POST",
                traditional: true,
                cache: false,
                url: Url,
                data: Params,
                headers: { '__RequestVerificationToken': OOSCore.VerificationToken() },
                error: function (xhr, ajaxOptions, thrownError) {
                }
            });
        }
        else {
            $.ajax({
                type: "POST",
                cache: false,
                traditional: true,
                url: Url,
                data: Params,
                headers: { '__RequestVerificationToken': OOSCore.VerificationToken() },
                success: function (res) {
                    refCallback(res);
                },
                error: function (xhr, ajaxOptions, thrownError) {
                }
            });
        }
    },
    Call_Ajax_Post_Form: function (Url, formName, refCallback) {
        var params = $("Form#" + formName).serialize();
        if (params === '')
        {
            params = $("#" + formName).serialize();
            if (params === '') {
                alert('Form not found !');
                return;
            }
        }
        OOSCore.Call_Ajax_Function_POST(Url, params, refCallback);
    },
    Call_Ajax_Post_FormMultipart: function (Url, formName, refCallback) {
        var form = $("Form#" + formName)[0];
        var data = new FormData(form);
        $.ajax({
            type: "POST",
            enctype: 'multipart/form-data',
            url: Url,
            data: data,
            processData: false,
            contentType: false,
            cache: false,
            timeout: 600000,
            headers: { '__RequestVerificationToken': OOSCore.VerificationToken() },
            success: function (data) {
                refCallback(data);
            }
        });
    },
    VerificationToken: function () {
        var token = $('input[name="__RequestVerificationToken"]').val();
        return token;
    }
};

var OOSAPI_Sys = {
    GetValue_String: function (code, inputs, refCallback) {
        var valu = '';
        $.ajax({
            type: "GET",
            cache: false,
            url: '/APISys/GetValue_String',
            data: { Code: code, Parameters: inputs },
            dataType: "json",
            headers: { '__RequestVerificationToken': OOSCore.VerificationToken() },
            success: function (res) {
                refCallback(res);
            },
            error: function (xhr, ajaxOptions, thrownError) {
            }
        });
        return valu;
    },
    Do_Function: function (code, inputs, refCallback) {
        var valu = '';
        $.ajax({
            type: "POST",
            cache: false,
            url: '/APISys/DoFunction',
            data: { Code: code, Parameters: inputs },
            dataType: "json",
            headers: { '__RequestVerificationToken': OOSCore.VerificationToken() },

            success: function (res) {
                if (refCallback!==null) {
                    refCallback(res);
                }
            },
            error: function (xhr, ajaxOptions, thrownError) {
            }
        });
        return valu;
    },
    Do_Function_Form: function (code, formName, refCallback) {
        var url= '/APISys/DoFunction';
        var params = $("Form#" + formName).serialize() + "&Code=" + code;

        OOSCore.Call_Ajax_Function_POST(url, params, refCallback);
    },
    Update_Size: function () {
        var params = $(window).width().toString() + ';' + $(window).height().toString();
        this.Do_Function('UPDATE_SIZE', params.toString(), null);
    }
};

var OOSAPI_Payroll = {
    GetValue_String: function (code, inputs, refCallback) {
        $.ajax({
            type: "GET",
            cache: false,
            url: '/Payroll/APIPayroll/GetValue_String',
            data: { Code: code, Input: inputs },
            dataType: "json",
            headers: { '__RequestVerificationToken': OOSCore.VerificationToken() },

            success: function (res) {
                refCallback(res.Valu);
            },
            error: function (xhr, ajaxOptions, thrownError) {
            }
        });
        return '';
    }
};

var OOSAPI_HRIS = {
    GetValue_String: function (code, inputs, refCallback) {
        var valu = '';
        $.ajax({
            type: "GET",
            cache: false,
            url: '/HRIS/APIHRIS/GetValue_String',
            data: { Code: code, Parameters: inputs },
            dataType: "json",
            headers: { '__RequestVerificationToken': OOSCore.VerificationToken() },

            success: function (res) {
                refCallback(res);
            },
            error: function (xhr, ajaxOptions, thrownError) {
            }
        });
        return valu;
    },
    Do_Function: function (code, inputs, refCallback) {
        var valu = '';
        $.ajax({
            type: "POST",
            cache: false,
            url: '/HRIS/APIHRIS/Do_Function',
            data: { Code: code, Parameters: inputs },
            dataType: "json",
            headers: { '__RequestVerificationToken': OOSCore.VerificationToken() },

            success: function (res) {
                refCallback(res);
            },
            error: function (xhr, ajaxOptions, thrownError) {
            }
        });
        return valu;
    }
};

var OOSAPI_EVALUATION = {
    GetValue_String: function (code, inputs, refCallback) {
        var valu = '';
        $.ajax({
            type: "GET",
            cache: false,
            url: '/Evaluation/APIEvaluation/GetValue_String',
            data: { Code: code, Parameters: inputs },
            dataType: "json",
            headers: { '__RequestVerificationToken': OOSCore.VerificationToken() },

            success: function (res) {
                refCallback(res);
            },
            error: function (xhr, ajaxOptions, thrownError) {
            }
        });
        return valu;
    }
};

var OOSDialog = {
    ShowProfile: function (id) {
        $.ajax({
            url: "/HRIS/Profile/ProfilePreviewCompact",
            type: "GET",
            data: { "NhanVienID": id },
            headers: { '__RequestVerificationToken': OOSCore.VerificationToken() },

            success: function (result) {
                OOSDialog.ShowPopupContentHTML(result,'Employee Information', 300, 150);
            }
        });
    },
    ShowEmailSender: function (caption, pcode, ccode, module) {
        OOSDialog.ShowLoadingPanel();
        $.ajax({
            url: "/Admin/EmailSender/EmailSenderDialog",
            type: "GET",
            data: { "TaskName": caption, "ProfileCode": pcode, "ContentCode": ccode, "Module": module },
            headers: { '__RequestVerificationToken': OOSCore.VerificationToken() },

            success: function (result) {
                $('#idPopupThongBao').html(result);
                OOSDialog.HideLoadingPanel();
                pcEmailSender.Show();
            }
        });
    },
    ShowExportData: function (caption, module) {
        OOSDialog.ShowLoadingPanel();
        $.ajax({
            url: "/Admin/ImportData/ExportDataDialog",
            type: "GET",
            data: { "Caption": caption, "Module": module },
            headers: { '__RequestVerificationToken': OOSCore.VerificationToken() },

            success: function (result) {
                $('#idPopupThongBao').html(result);
                OOSDialog.HideLoadingPanel();
                pcExportData.Show();
            }
        });
    },
    ShowXtraFunction: function (ID) {
        OOSDialog.ShowLoadingPanel();
        $.ajax({
            url: "/Admin/Function/XtraFunctionDialog",
            type: "GET",
            data: { "ID": ID },
            headers: { '__RequestVerificationToken': OOSCore.VerificationToken() },
            success: function (result) {
                $('#idPopupThongBao').html(result);
                OOSDialog.HideLoadingPanel();
                pcXtraFunction.Show();
            }
        });
    },

    ShowPopupThongBaoClient: function (mess) {
        OOSDialog.ShowPopupMessage(mess);
    },

    PrintForms: function (ObjectID, FormCode) {
        $.ajax({
            url: "/Admin/PrintForms/ShowPrintForms" + "/" + ObjectID + "/" + FormCode,
            type: "GET",
            data: {
                Message: 'error',
                Code: 0
            },
            headers: { '__RequestVerificationToken': OOSCore.VerificationToken() },
            success: function (result) {
                $('#idPrintForms').html(result);
                pcPrintForms.Show();
            }
        });
    },
    ShowLoadingPanelText: function (s) {
        pnLoadingPanel.SetText(s);
        pnLoadingPanel.Show();
    },
    ShowLoadingPanel: function () {
        pnLoadingPanel.SetText('Đang xử lý, xin vui lòng đợi !');
        pnLoadingPanel.Show();
    },

    HideLoadingPanel: function () {
        pnLoadingPanel.Hide();
    },

    ShowPopupChangePass: function () {
        pcChangePass.Show();
    },

    ShowPopupMessage: function (s) {
        pcMessageBox.SetWidth(370);
        pcMessageBox.SetHeight(150);
        var html =
            '<div class="messagebox">' + s + '</div><div style="text-align:center; padding-top:20px"><button class="btn blue-steel" onclick="OOSDialog.ClosePopupMessage();"><i class="fa fa-check"></i> Close</button></div>';
        pcMessageBox.SetContentHTML(html);
        pcMessageBox.Show();
    },
    ShowMessage: function (s) {
        pcMessageBox.SetWidth(370);
        pcMessageBox.SetHeight(150);
        var html =
            '<div class="messagebox">' + s + '</div><div style="text-align:center; padding-top:20px"><button class="btn blue-steel" onclick="OOSDialog.ClosePopupMessage();"><i class="fa fa-check"></i> Close</button></div>';
        pcMessageBox.SetContentHTML(html);
        pcMessageBox.Show();
    },
    ShowPopupContent: function (content, headertext) {
        var html =
            '<div>' + content + '</div><div style="text-align: center;padding: 20px;position: absolute;bottom: 0;width: 100%;"><button class="btn blue-steel" onclick="OOSDialog.ClosePopupMessage();"><i class="fa fa-check"></i> Close</button></div>';
        pcMessageBox.SetWidth(800);
        pcMessageBox.SetHeight(600);
        pcMessageBox.SetHeaderText(headertext);
        pcMessageBox.SetContentHTML(html);
        pcMessageBox.Show();
    },
    ShowPopupContentHTML: function (html, headertext, w, h) {

        if (w > 0 && h > 0) {
            pcMessageBox.SetWidth(w);
            pcMessageBox.SetHeight(h);
        }

        pcMessageBox.SetHeaderText(headertext);
        pcMessageBox.SetContentHTML(html);
        pcMessageBox.Show();
    },
    ShowPopupContentURL: function (url, headertext, w, h) {
        if (h!==null && h > 0)
            pcMessageBox.SetHeight(h);
        else
            pcMessageBox.SetHeight(768);

        if (w!== null && w > 0)
            pcMessageBox.SetWidth(w);
        else
            pcMessageBox.SetWidth(1024);

        pcMessageBox.SetHeaderText(headertext);
        pcMessageBox.SetContentUrl(url); 
        pcMessageBox.Show();
    },
    ShowPopupMessageQ: function (s) {
        pcMessageBox.SetWidth(370);
        pcMessageBox.SetHeight(150);
        var html = '';
        html = '<div class="messagebox">' + s + '</div><div style="text-align:center; padding-top:20px"><button class="btn red-sunglo" onclick="OOSDialog.ClosePopupMessage();"><i class="fa fa-times"></i>  Bỏ Qua</button><button class="btn blue-steel" onclick="OnPopupQ_DongY();"><i class="fa fa-check"></i> Đồng ý</button></div>';
        pcMessageBox.SetContentHTML(html);
        pcMessageBox.Show();
    },

    ShowQuestion_WID: function (s, refCallback, refID) {
        pcMessageBox.SetWidth(370);
        pcMessageBox.SetHeight(150);
        var html = '';
        html = '<div class="messagebox">' + s + '</div><div style="text-align:center; padding-top:20px"><button class="btn red-sunglo" onclick="OOSDialog.ClosePopupMessage();"><i class="fa fa-times"></i>  Bỏ Qua</button><button class="btn blue-steel" onclick="' + refCallback + '(\'' + refID + '\');"><i class="fa fa-check"></i> Đồng ý</button></div>';
        pcMessageBox.SetContentHTML(html);
        pcMessageBox.Show();
    },
    ConfirmDialog: function (s, refCallback) {
        pcMessageBox.SetWidth(370);
        pcMessageBox.SetHeight(150);
        var html = '';
        html = '<div class="messagebox">' + s + '</div><div style="text-align:center; padding-top:20px"><button class="btn red-sunglo" onclick="OOSDialog.ClosePopupMessage();"><i class="fa fa-times"></i>  Bỏ Qua</button><button class="btn blue-steel" id="custom-confirm-agree"><i class="fa fa-check"></i> Đồng ý</button></div>';
        pcMessageBox.SetContentHTML(html);

        window.setTimeout(function () {
            $("#custom-confirm-agree").unbind("click");
            $("#custom-confirm-agree").click(function () {
                OOSDialog.ClosePopupMessage();
                refCallback();
            });
        }, 500);

        pcMessageBox.Show();
    },
    ShowQuestion: function (s, refCallback) {
        pcMessageBox.SetWidth(370);
        pcMessageBox.SetHeight(150);
        var html = '';
        html = '<div class="messagebox">' + s + '</div><div style="text-align:center; padding-top:20px"><button class="btn blue-steel" onclick="' + refCallback + '();"><i class="fa fa-check"></i> Đồng ý</button><button class="btn red-sunglo" onclick="OOSDialog.ClosePopupMessage();"><i class="fa fa-times"></i>  Bỏ Qua</button></div>';
        pcMessageBox.SetContentHTML(html);
        pcMessageBox.Show();
    },
    ShowPopupNhanVienInfo: function (NhanVienID, headertext) {
        var html = '<iframe width="999" frameborder="0" height="768" src="/HRIS/Process/Salary/' + NhanVienID + '"></iframe>';
        pcMessageBox.SetWidth(999);
        pcMessageBox.SetHeight(768);
        pcMessageBox.SetHeaderText(headertext);
        pcMessageBox.SetContentHTML(html);
        pcMessageBox.Show();
    },
    ClosePopupMessage: function () {
        pcMessageBox.Hide();
    },
    ClosePopup: function () {
        pcMessageBox.Hide();
    },
    ShowTextInput: function (headertext, caption, refCallback) {
        pcMessageBox.SetHeaderText(headertext);
        pcMessageBox.SetWidth(370);
        pcMessageBox.SetHeight(50);
        var html = '';
        html = '<div class="messagebox"><div style="float:left; padding-bottom:10px;">' + caption + '</div><input id="iptTextInput" class="form-control" style="width:100%"></input></div>';
        html += '<div style="text-align:center; padding-top:20px"><button class="btn red-sunglo" onclick = "OOSDialog.ClosePopupMessage();" ><i class="fa fa-times"></i>  Bỏ Qua</button> <button class="btn blue-steel" id="custom-confirm-agree"><i class="fa fa-check"></i> Đồng ý</button></div> ';
        pcMessageBox.SetContentHTML(html);
        pcMessageBox.Show();

        window.setTimeout(function () {
            $("#iptTextInput").focus();
            $("#custom-confirm-agree").unbind("click");
            $("#custom-confirm-agree").click(function () {
                if ($("#iptTextInput").val() == '') {
                    showErrorMessage("Bạn phải nhập thông tin !");
                }
                else {
                    refCallback($("#iptTextInput").val());
                }
            });
        }, 50);
    },
    ShowInputHTML: function (caption, html, refCallback) {
        pcMessageBox.SetHeaderText(headertext);
        pcMessageBox.SetWidth(370);
        pcMessageBox.SetHeight(50);
        html += '<div style="text-align:center; padding-top:20px"><button class="btn red-sunglo" onclick = "OOSDialog.ClosePopupMessage();" ><i class="fa fa-times"></i>  Bỏ Qua</button> <button class="btn blue-steel" id="custom-confirm-agree"><i class="fa fa-check"></i> Đồng ý</button></div> ';
        pcMessageBox.SetContentHTML(html);
        pcMessageBox.Show();

        window.setTimeout(function () {
            $("#iptTextInput").focus();
            $("#custom-confirm-agree").unbind("click");
            $("#custom-confirm-agree").click(function () {
                refCallback();
            });
        }, 50);
    }
};

var OOSFileManagement = {
    Init: function () {
        FileStoreIndex = 0;
    },
    DeleteFileStore: function (fileStoreID) {
        OOSDialog.ClosePopupMessage();
        var url = '/FileManagement/DeleleFileStore';
        var params = { FileStoreID: fileStoreID };
        OOSCore.Call_Ajax_Function_POST(url, params, function () {            
            $("#sf_" + fileStoreID.toString()).remove();
        });
    },
    CVDeleteFileStore: function (fileStoreID) {
        OOSDialog.ClosePopupMessage();
        var url = '/FileManagement/CVDeleleFileStore';
        var params = { FileStoreID: fileStoreID };
        OOSCore.Call_Ajax_Function_POST(url, params, function (res) {
            $("#sf_" + fileStoreID.toString()).remove();
        });
    },
    Remove_File: function Remove_File(name) {
        $("input[id='" + name + "']").remove();
        $("div[id='div" + name + "']").remove();
        FileStoreIndex--;
        var params = { FileName: name };
        OOSCore.Call_Ajax_Function_POST('/FileManagement/RemoveFile', params, function (res) { });
    },
    onFileUploadComplete: function onFileUploadComplete(e, s) {
        if (e.callbackData) {
            var fileData = e.callbackData.split('|');
            var Name = fileData[0],
                fullName = fileData[1];
            var idName = s + '_' + FileStoreIndex.toString();
            FileStoreIndex++;
            var html = '<div id="div' + idName + '"><div style="float:left"><input id="' + idName + '" value="' + fullName + '" name="' + idName + '" type="hidden"><span>' + FileStoreIndex + '. ' + Name + '</span><div style="float:right; padding-left:10px;"><a href="javascript:;" onclick="Remove_File(' + "'" + idName + "'" + ');" style="float:left;color:red;cursor:pointer" title="Close"><i class="fa fa-times"></i></a></div></div></div>';
            $("#fileContainer").append(html);
        }
        else {
            showErrorMessage('File format mismatch !');
        }
    }
};

var OOSUtils = {
    Disabled: function (id, status) {
        $("#" + id).prop('disabled', status);
    },
    EnableButton: function (id) {
        $("#" + id).prop('disabled', false);
    },
    DisableButton: function (id) {
        $("#" + id).prop('disabled', true);
    },
    DisableSaveButton: function () {
        $('[name ="btSave"]').prop('disabled', true);
    },
    EnableSaveButton: function () {
        $('[name ="btSave"]').prop('disabled', false);
    },
    CheckSMTPServer: function (srv, port, uid, pwd, femail, ssl, tls, popsrv, popport, popuid, poppwd, popssl, poptls) {
        var params = srv + ';' + port + ';' + uid + ';' + pwd + ';' + femail + ';' + ssl + ';' + tls + ';' + popsrv + ';' + popport + ';' + popuid + ';' + poppwd + ';' + popssl + ';' + poptls;

        OOSDialog.ShowLoadingPanel();
        OOSAPI_Sys.GetValue_String('CHECK_SMTP', params, function (res) {
            OOSDialog.HideLoadingPanel();

            OOSDialog.ShowPopupMessage(res.Valu);
        });
    },
    CheckPOPServer: function (srv, port, uid, pwd, femail, ssl) {
        var params = srv + ';' + port + ';' + uid + ';' + pwd;
        OOSAPI_Sys.GetValue_String('CHECK_POP', params, function (res) {
            OOSDialog.ShowPopupMessage(res.Valu);
        });
    },
    SetHeightGridview(s, h) {
        var windowHeight = window.innerHeight;
        s.SetHeight(windowHeight - ASPxClientUtils.GetAbsoluteY(s.GetMainElement()) - 5 - h);
    }
};

var OOSUserForm = {
    CheckAll_ChucVuNhomNangLuc: function () {
        $("#chkChucVuNhomNangLuc").find(".dxKBSW").each(function () {
            $(this).parent().removeClass();
            $(this).parent().addClass("dxICheckBox_Moderno dxichSys dxWeb_edtCheckBoxChecked_Moderno");
            $(this).find("input").val('C');
        });
    }
};

var OOSNotify = {
    //Bắt đầu chạy Timer
    Start: function () {
        if (notifyTimer !== null)
            clearInterval(notifyTimer);

        notifyTimer = setInterval(function () { OOSNotify.GetNotify(); }, 1000);
    },
    GetNotify: function () {
        OOSAPI_Sys.GetValue_String('GET_NOTIFY', '', function (res) {
            if (res.status === 1) {
                OOSNotify.Stop();

                if (res.SLPheDuyet > 0) {
                    $("#idApprove").append("<span id='approve_count' class='badge badge-default'>" + res.SLPheDuyet + "</span>");
                    $("#approve_count_title").html(res.SLPheDuyet);

                    $.each(res.PheDuyetList, function (i, item) {
                        $("#ulPheDuyet").append(
                            "<li>" +
                            "<a href='/Admin/Approve?QuyTrinhID=" + item.QuyTrinhID + "'>" +
                            "<span style='margin-right:2px' class='badge badge-success pull-right'>" + item.Count + "</span>" +
                            "<span class='details'><span class='label label-sm label-icon'><i class='icon-check text-success'></i></span>" +
                            item.TenQuyTrinh + "</span></a></li>");
                    });
                }

                if (res.SLCanhBao > 0) {
                    $("#idNotification").append("<span id='notification_count' class='badge badge-danger'>" + res.SLCanhBao + "</span>");
                    $("#notification_count_title").html(res.SLCanhBao);

                    $.each(res.CanhBaoList, function (i, item) {
                        $("#ulCanhBao").append(
                            "<li>" +
                            "<a href='/Admin/Notification/Index/" + item.ID + "'>" +
                            "<span style='margin-right:2px' class='badge badge-danger pull-right'>" + item.ResultCount + "</span>" +
                            "<span class='details'><i class='fa fa-exclamation-circle' style='color: #ada822c7;font-size: 16px;'></i> " + item.Name + "</span></a></li>");
                    });
                }
            }
        });
    },
    Stop: function () {
        if (notifyTimer !== null) {
            window.clearInterval(notifyTimer);
            notifyTimer = null;
        }
    }
};

var ThirtParty = {
    GoogleMap: function (lo, la, addr) {
        // initialize map
        var map = new google.maps.Map(document.getElementById("map-canvas"), {
            center: new google.maps.LatLng(lo, la),
            zoom: 13,
            mapTypeId: google.maps.MapTypeId.ROADMAP
        });
        // initialize marker
        var marker = new google.maps.Marker({
            position: map.getCenter(),
            draggable: true,
            map: map
        });
        // intercept map and marker movements
        google.maps.event.addListener(map, "idle", function () {
            marker.setPosition(map.getCenter());
            if (typeof Longtitude !== 'undefined') {
                Longtitude.SetText(map.getCenter().lat().toFixed(6));
                Latitude.SetText(map.getCenter().lng().toFixed(6));
            }
        });
        google.maps.event.addListener(marker, "dragend", function (mapEvent) {
            map.panTo(mapEvent.latLng);
        });
        // initialize geocoder
        var geocoder = new google.maps.Geocoder();
        google.maps.event.addDomListener(document.getElementById("search-btn"), "click", function () {
            geocoder.geocode({ address: document.getElementById("search-txt").value }, function (results, status) {
                if (status === google.maps.GeocoderStatus.OK) {
                    var result = results[0];
                    document.getElementById("search-txt").value = result.formatted_address;
                    if (result.geometry.viewport) {
                        map.fitBounds(result.geometry.viewport);
                    } else {
                        map.setCenter(result.geometry.location);
                    }
                } else if (status === google.maps.GeocoderStatus.ZERO_RESULTS) {
                    alert("Sorry, geocoder API failed to locate the address.");
                } else {
                    alert("Sorry, geocoder API failed with an error.");
                }
            });
        });
        google.maps.event.addDomListener(document.getElementById("search-txt"), "keydown", function (domEvent) {
            if (domEvent.which === 13 || domEvent.keyCode === 13) {
                google.maps.event.trigger(document.getElementById("search-btn"), "click");
            }
        });
        // initialize geolocation
        if (navigator.geolocation) {
            google.maps.event.addDomListener(document.getElementById("detect-btn"), "click", function () {
                navigator.geolocation.getCurrentPosition(function (position) {
                    map.setCenter(new google.maps.LatLng(position.coords.latitude, position.coords.longitude));
                }, function () {
                    alert("Sorry, geolocation API failed to detect your location.");
                });
            });
            document.getElementById("detect-btn").disabled = false;
        }

        if (lo === 0 && la === 0 && addr !== '') {
            geocoder.geocode({ address: addr }, function (results, status) {
                if (status === google.maps.GeocoderStatus.OK) {
                    var result = results[0];
                    document.getElementById("search-txt").value = result.formatted_address;
                    if (result.geometry.viewport) {
                        map.fitBounds(result.geometry.viewport);
                    } else {
                        map.setCenter(result.geometry.location);
                    }
                } else if (status == google.maps.GeocoderStatus.ZERO_RESULTS) {
                    alert("Sorry, geocoder API failed to locate the address.");
                } else {
                    alert("Sorry, geocoder API failed with an error.");
                }
            });
        }
    }
}