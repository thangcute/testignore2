function formatRepo(repo) {
    if (repo.loading) {
        return repo.text;
    }

    $container = repo.name + ' - ' + repo.code;
    return $container;
}

function formatRepoSelection(repo) {
    return repo.name || repo.text;
}

function select2Init(_tagAttr, _url) {
    var _placeholder = 'Thông tin tìm kiếm';
    if ($(_tagAttr).attr('placeholder'))
        _placeholder = $(_tagAttr).attr('placeholder');

    $(_tagAttr).select2({
        ajax: {
            //url: '/Select2/GetProduct',
            url: _url,
            type: 'GET',
            dataType: 'json',
            delay: 250,
            data: function (params) {
                return {
                    search: params.term,
                    page: params.page
                };
            },
            processResults: function (data, params) {
                params.page = params.page || 1;

                return {
                    results: data.items,
                    pagination: {
                        more: (params.page * 10) < data.total_count
                    }
                };
            },
            cache: true
        },
        placeholder: _placeholder,
        minimumInputLength: 0,
        templateResult: function (_data) {
            if (_data.loading) {
                return _data.text;
            }

            if (typeof _data.code != 'undefined' && _data.code != null && _data.code != '')
                $_container = _data.name + ' - ' + _data.code;
            else
                $_container = _data.name;

            return $_container;
        },
        templateSelection: formatRepoSelection
    });
}