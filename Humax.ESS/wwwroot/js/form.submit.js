$(function () {
    $('form.CoreFormSubmit').submit(function (e) {
        $('button[type="submit"][data-name="BtnFormSubmit"]').prop('disabled', true);
        overlayOn();
        e.preventDefault();

        var _enctype = $('form.CoreFormSubmit').attr('enctype');
        var _action = $('form.CoreFormSubmit').attr('action');
        var _method = $('form.CoreFormSubmit').attr('method');
        var _endSubmit = $('form.CoreFormSubmit').attr('end-submit');
        var _data = $('form.CoreFormSubmit').serializeArray();

        if (typeof _enctype != 'undefined' && _enctype == 'multipart/form-data') {
            var form = $('form.CoreFormSubmit')[0];
            var _data = new FormData(form);
            //
            $.ajax({
                enctype: 'multipart/form-data',
                processData: false,
                contentType: false,
                dataType: 'json',
                type: _method,
                url: _action,
                data: _data,
                success: function (res, status, jqXHR) {
                    //console.log(res);
                    if (res.status == 1) {
                        toastr.success("Thực hiện thành công");

                        setTimeout(function () {
                            if (_endSubmit == 'R')
                                $("form.CoreFormSubmit")[0].reset();
                            else
                                window.location.href = _endSubmit;
                        }, 1000);
                    } else if (res.status == 99) {
                        var _validation = res.validation;
                        if (typeof _validation != 'undefined' && _validation.length > 0) {
                            for (var key in _validation) {
                                var _field = _validation[key]["Field"];
                                var _message = _validation[key]["Message"];

                                $('span[field="' + _field + '"]').addClass('c-validation').html(_message);
                            }
                        }
                    } else {
                        toastr.warning("Có lỗi trong quá trình xử lý");
                    }
                },
                error: function (jqXHR, status, err) {
                    toastr.error("Lỗi Server");
                },
                complete: function () {
                    overlayOff();
                    $('button[type="submit"][data-name="BtnFormSubmit"]').prop('disabled', false);
                }
            });
        } else {
            $.ajax({
                dataType: 'json',
                type: _method,
                url: _action,
                data: _data,
                success: function (res, status, jqXHR) {
                    //console.log(res);
                    if (res.status == 1) {
                        toastr.success("Thực hiện thành công");

                        setTimeout(function () {
                            if (_endSubmit == 'R')
                                $("form.CoreFormSubmit")[0].reset();
                            else
                                window.location.href = _endSubmit;
                        }, 1000);
                    } else if (res.status == 99) {
                        var _validation = res.validation;
                        if (typeof _validation != 'undefined' && _validation.length > 0) {
                            for (var key in _validation) {
                                var _field = _validation[key]["Field"];
                                var _message = _validation[key]["Message"];

                                $('span[field="' + _field + '"]').addClass('c-validation').html(_message);
                            }
                        }
                    } else {
                        toastr.warning("Có lỗi trong quá trình xử lý");
                    }
                },
                error: function (jqXHR, status, err) {
                    toastr.error("Lỗi Server");
                },
                complete: function () {
                    overlayOff();
                    $('button[type="submit"][data-name="BtnFormSubmit"]').prop('disabled', false);
                }
            });
        }
    });
});