var _listMedia = {};
var _listObject = [];

function cUuid() {
    var d = new Date().getTime();   //Timestamp
    var d2 = (performance && performance.now && (performance.now() * 1000)) || 0;   //Time in microseconds since page-load or 0 if unsupported
    return 'xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx'.replace(/[xy]/g, function (c) {
        var r = Math.random() * 16; //random number between 0 and 16
        if (d > 0) {    //Use timestamp until depleted
            r = (d + r) % 16 | 0;
            d = Math.floor(d / 16);
        } else {    //Use microseconds since page-load if supported
            r = (d2 + r) % 16 | 0;
            d2 = Math.floor(d2 / 16);
        }
        return (c === 'x' ? r : (r & 0x3 | 0x8)).toString(16);
    });
}

function addMedia(e) {
    _listMedia = {};
    _listObject = [];

    //var _file = e.files[0];
    if (e.files.length > 0) {
        $('.post__medias').removeClass('hidden');
        $('.post__medias > .gallery__list').html('');
        for (var i = 0; i < e.files.length; ++i) {
            var _uuid = cUuid();
            var _file = e.files[i];

            _listMedia[_uuid] = _file;
            _listObject.push({
                "code": _uuid,
                "media": _file
            });

            var reader = new FileReader();
            reader.onload = function (_e) {
                //_path = _e.target.result;
                $('.post__medias > .gallery__list').append(`<div class="gallery__preview">
                            <img class="gallery__pic" src="${_e.target.result}" alt="">
                        </div>`);
            }
            reader.readAsDataURL(_file);
        }
    }
    else
        $('.post__medias').addClass('hidden');

    //console.log(_listMedia);
    //console.log(_listObject);

    //Object.keys(_listMedia).forEach(function (key) {
    //    console.log(key);
    //    console.log(_listMedia[key]);
    //});

    //for(_key in _listObject){
    //    console.log(_key);
    //    console.log(_listObject[_key]);
    //}
}

function deleteMedia(_uuid) {
    if (_listMedia.length > 0) {
        console.log(1);
    }
    console.log(_listMedia);
}

$(function () {
    $('.post_submit').click(function () {
        //var _antiForgeryToken = $('input[name="__RequestVerificationToken"]').val();
        var _title = $('input[name="post_title"]').val();
        var _content = $('input[name="post_content"]').val();

        if (typeof (_title) == 'undefined' || _title == '') {
            toastr.warning('Tiêu đề bài viết không để trống.');
            return;
        }

        var _data = new FormData();
        _data.append("Title", _title);
        _data.append("Content", _content);

        for (_key in _listObject) {
            _data.append("Media", _listObject[_key]['media']);
        }

        $.ajax({
            //enctype: 'multipart/form-data',
            url: '/Post/Index',
            type: "POST",
            data: _data,
            dataType: 'json',
            contentType: 'application/json; charset=utf-8',
            cache: false,
            processData: false,
            contentType: false,
            //headers: { '__RequestVerificationToken': _antiForgeryToken },
            success: function (res) {
                if (res.success == 1) {
                    toastr.success("Thêm mới bài đăng thành công");
                } else {
                    toastr.warning(res.message);
                }
            },
            error: function (xhr, ajaxOptions, thrownError) {
                toastr.error("Lỗi Server");
            },
            complete: function () {
                _listMedia = {};
                _listObject = [];
                //$("body").removeClass("loading");
            }
        });
    });
});
function insertLike(data, calllback) {
    var options = {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(data)
    }
    fetch(url, options)
        .then(function (response) {
            response.json();
        })
        .then(callback);
}
