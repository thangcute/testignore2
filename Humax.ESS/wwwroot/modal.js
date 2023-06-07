function modal_open(_tagId, _title, _href, _footer=1) {
    if (_footer == 0)
        $('#' + _tagId + 'Footer').css('display', 'none');
    else
        $('#' + _tagId + 'Footer').css('display', 'block');

    if (typeof _href != 'undefined' && _href != '') {
        //overlayOn();
        $('#' + _tagId + 'Title').html(_title);
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
                //overlayOff();
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
        console.log(_i);
        modal_open('modalGlobal', _i.attr('modal-title'), _i.attr('modal-href'));
    });

    $('#modalGlobal').on('shown.bs.modal', function (e) {

    });

    $('#modalGlobal').on('hidden.bs.modal', function (e) {
        $('#modalGlobalTitle').html('');
        $('#modalGlobalBody').html('');
    });

    $('#ModalBtnSubmit').click(function () {
        if ($('#ModalBtnFormSubmit').length > 0) {
            $('#ModalBtnFormSubmit').click();
        }
    });
});