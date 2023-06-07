var __width = "600px";
var __height = "auto";

function form_submit(_tagId) {
    $('#' + _tagId + 'Submit').click();
}

function modal_init(_tagId, _width, _height, _btnSubmit=1) {
    if (typeof _width !== 'undefined' && _width !== '')
        __width = _width;

    if (typeof _height !== 'undefined' && _height !== '')
        __height = _height;

    var _modal = '<div class="modal fade" id="' + _tagId + '" tabindex="-1" role="dialog" aria-hidden="true">';
    _modal += '<div class="modal-dialog modal-dialog-centered" role="document" style="width: ' + __width + ';">';
    _modal += '<div class="modal-content">';
    _modal += '<div class="modal-header">';
    _modal += '<h5 class="modal-title" id="' + _tagId + 'Label">Modal title</h5>';
    _modal += '</div>';
    _modal += '<div class="modal-body" id="' + _tagId + 'Body">';

    //for (var _i = 0; _i <= 150; _i++) {
    //    _modal += '<p class="modal-text">' + _i + '</p>';
    //}

    _modal += '</div>';
    _modal += '<div class="modal-footer" id="' + _tagId + 'Footer">';
    _modal += '<button class="btn btn-warning" data-dismiss="modal">';
    _modal += '<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather feather-power"><path d="M18.36 6.64a9 9 0 1 1-12.73 0"></path><line x1="12" y1="2" x2="12" y2="12"></line></svg>';
    _modal += ' Đóng';
    _modal += '</button>';
    if (_btnSubmit == 1) {
        _modal += '<button type="button" class="btn btn-primary" onclick="form_submit(\'' + _tagId + '\');">';
        _modal += '<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather feather-save"><path d="M19 21H5a2 2 0 0 1-2-2V5a2 2 0 0 1 2-2h11l5 5v11a2 2 0 0 1-2 2z"></path><polyline points="17 21 17 13 7 13 7 21"></polyline><polyline points="7 3 7 8 15 8"></polyline></svg>';
        _modal += ' Lưu';
        _modal += '</button>';
    }
    _modal += '</div>';
    _modal += '</div>';
    _modal += '</div>';
    _modal += '</div>';
    $('body').append(_modal);

    $('#' + _tagId).on('shown.bs.modal', function (e) {
        
    });

    $('#' + _tagId).on('hidden.bs.modal', function (e) {
        $('#' + _tagId + 'Body').html('');
    });
}

function modal_change_width(_tagId, _width) {
    if ($('div#' + _tagId + ' > div.modal-dialog').length) {
        if (typeof _width !== 'undefined' && _width !== '') {
            $('div#' + _tagId + ' > div.modal-dialog').css('width', _width);
            $('div#' + _tagId + ' > div.modal-dialog').css('max-width', _width);
        } else {
            $('div#' + _tagId + ' > div.modal-dialog').css('width', __width);
            $('div#' + _tagId + ' > div.modal-dialog').css('max-width', __width);
        }
    }
}

//function modal_change_height(tag, height) {
//    if ($('div#' + tag + 'Body').length) {
//        if (typeof height !== 'undefined' && height !== '') {
//            $('div#' + tag + 'Body').css('height', height);
//            $('div#' + tag + 'Body').css('max-height', height);
//        } else {
//            $('div#' + tag + 'Body').css('height', _height);
//            $('div#' + tag + 'Body').css('max-height', _height);
//        }
//    }
//}

function modal_open(_tagId, _title, _href) {
    if (typeof _href != 'undefined' && _href != '') {
        overlayOn();
        $('#' + _tagId + 'Label').html(_title);
        $.ajax({
            url: _href,
            dataType: 'html',
            type: 'GET',
            async: false,
            data: {},
            success: function (response, status, jqXHR) {
                $('#' + _tagId + 'Body').html(response);
            },
            error: function (jqXHR, status, err) {
            },
            complete: function (jqXHR, status) {
                overlayOff();
            }
        });
        $('#' + _tagId).modal();
    } else
        $('#' + _tagId).modal();
}

function modal_close(_tagId) {
    $('#' + _tagId).modal('hide');
    $('#' + _tagId + 'Title').html('');
    $('#' + _tagId + 'Body').html('');
}

$(function () {
    $('html').on('click', '.btn-modal', function (e) {
        e.preventDefault();
        _i = $(this);

        _modal_id = $(this).attr('modal-id');

        if (typeof _modal_id != 'undefined' && _modal_id != '' && typeof $('#' + _modal_id).length != 'undefined' && $('#' + _modal_id).length > 0) {
            if (typeof $(this).attr('modal-width') !== 'undefined' && $(this).attr('modal-width') !== '')
                modal_change_width(_modal_id, $(this).attr('modal-width'));
            else
                modal_change_width(_modal_id);

            //if (typeof $(this).attr('_height') !== 'undefined' && $(this).attr('_height') !== '')
            //    modal_change_height(_modal_id, $(this).attr('_height'));
            //else
            //    modal_change_height(_modal_id);

            if (typeof _modal_id != 'undefined' && _modal_id != '')
                modal_open(_modal_id, _i.attr('modal-title'), _i.attr('modal-data'));
        } else {
            console.log('khong tim thay doi tuong: #' + _modal_id)
        }
    });
});