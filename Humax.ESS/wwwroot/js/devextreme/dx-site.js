/**
    Khai bao
 */
var jsGioiTinh = [
    {
        Id: "Nam",
        Name: "Nam"
    },
    {
        Id: "Nữ",
        Name: "Nữ"
    },
];

var jsLoaiGiayTo = [
    {
        Id: 1,
        Name: "01: Sổ hộ khẩu"
    },
    {
        Id: 2,
        Name: "02: Sổ tạm trú"
    },
    {
        Id: 3,
        Name: "03: Giấy tạm trú"
    },
    {
        Id: 4,
        Name: "04: Số UBND"
    },
    {
        Id: 5,
        Name: "05: Khác"
    }
];

var jsQuanHe = [
    {
        Id: "Ông",
        Name: "Ông"
    },
    {
        Id: "Bà",
        Name: "Bà"
    },
    {
        Id: "Bố",
        Name: "Bố"
    },
    {
        Id: "Mẹ",
        Name: "Mẹ"
    },
    {
        Id: "Vợ",
        Name: "Vợ"
    },
    {
        Id: "Chồng",
        Name: "Chồng"
    },
    {
        Id: "Con",
        Name: "Con"
    },
    {
        Id: "Anh ruột",
        Name: "Anh ruột"
    },
    {
        Id: "Chị ruột",
        Name: "Chị ruột"
    },
    {
        Id: "Em ruột",
        Name: "Em ruột"
    },
    {
        Id: "Cháu",
        Name: "Cháu"
    },
    {
        Id: "Chú",
        Name: "Chú"
    },
    {
        Id: "Cô",
        Name: "Cô"
    },
    {
        Id: "Bác",
        Name: "Bác"
    },
    {
        Id: "Mẹ chồng",
        Name: "Mẹ chồng"
    },
    {
        Id: "Bố chồng",
        Name: "Bố chồng"
    },
    {
        Id: "Anh chồng",
        Name: "Anh chồng"
    },
    {
        Id: "Chị chồng",
        Name: "Chị chồng"
    },
    {
        Id: "Em chồng",
        Name: "Em chồng"
    },
    {
        Id: "Bố vợ",
        Name: "Bố vợ"
    },
    {
        Id: "Mẹ vợ",
        Name: "Mẹ vợ"
    },
    {
        Id: "Anh vợ",
        Name: "Anh vợ"
    },
    {
        Id: "Chị vợ",
        Name: "Chị vợ"
    },
    {
        Id: "Em vợ",
        Name: "Em vợ"
    },
    {
        Id: "Khác",
        Name: "Khác"
    }
];
/**
 */
function FormDetail(_id, _title = '', _url = '', _popup = 'popup', _data = {}, _width = 600, _offset = 50) {
    var _position = {
        "my": "top center",
        "at": "top center",
        "offset": _offset
    };

    if (_offset == 0) {
        _position = {
            "my": "center",
            "at": "center",
        };
    }
    var popup = $("#" + _popup).dxPopup("instance");
    popup.option({
        "title": _title,
        "width": _width,
        "height": 'auto',
        "position": _position,
        "contentTemplate": function () {
            $.ajax({
                url: _url,
                dataType: 'html',
                type: 'GET',
                async: false,
                data: _data,
                success: function (response, status, jqXHR) {
                    $("#" + _popup + " .dx-popup-content").html(response);
                },
                error: function (jqXHR, status, err) {
                    $("#" + _popup + " .dx-popup-content").html('');
                },
                complete: function (jqXHR, status) {
                }
            });
        }
    });
    popup.show();
}

function Confirm(_message, _title = 'Xác nhận') {
    var _dialog = DevExpress.ui.dialog.custom({
        width: 450,
        title: _title,
        message:'<div class="dialog-custom-content"><i class="icon dx-icon-info"></i> ' + _message + '</div>',
        buttons: [
            {
                text: "Đồng ý",
                onClick: function (e) {
                    return { //e.component.option("text")
                        status: true
                    }
                }
            },
            {
                text: "Hủy",
                onClick: function (e) {
                    return {
                        status: false
                    }
                }
            },
        ]
    });
    return _dialog;
    //_dialog.show().done(function (dialogResult) {
    //    return dialogResult.status;
    //    //console.log(dialogResult.buttonText);
    //});
}

function Notify(_message) {
    var _notify = DevExpress.ui.dialog.custom({
        width: 450,
        title: 'Thông báo',
        message: _message,
        buttons: [
            {
                text: "Đóng",
                onClick: function (e) {
                    return {
                        status: false
                    }
                }
            },
        ]
    });
    return _notify;
}

function ClosePopup(_popup = 'popup') {
    if ($('#' + _popup).length) {
        $("#" + _popup).dxPopup("hide");
        $('#' + _popup + ' .dx-popup-content').html('');
    } else {
        toastr.warning("Không tìm thấy Popup");
    }
}

/**
 */

var gridInfoText = function () {
    var currentPage = $("#gridContainer").dxDataGrid("instance").pageIndex();
    var pageSize = $("#gridContainer").dxDataGrid("instance").pageSize();
    var totalCount = $('#gridContainer').dxDataGrid('instance').totalCount();

    return 'Hiển thị ' + (currentPage * pageSize + 1) + ' đến ' + (totalCount > ((currentPage + 1) * pageSize) ? ((currentPage + 1) * pageSize) : totalCount) + ' trong số ' + totalCount + ' mục';
};

function dataGrid_rowIndex_cellTemplate(element, info) {
    var currentPage = $("#gridContainer").dxDataGrid("instance").pageIndex();
    var pageSize = $("#gridContainer").dxDataGrid("instance").pageSize();
    element.html(currentPage * pageSize + info.rowIndex + 1);
}