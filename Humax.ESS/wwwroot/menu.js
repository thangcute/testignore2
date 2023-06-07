jQuery(function () {
    let _debug = function (properties) {
        console.groupCollapsed("jQuery.ContextMenu.js");
        console.debug("Hai selezionato '" + properties.text + "' ('" + properties.key + "').");
        console.debug(this);
        console.groupEnd();
    };

    let _menuItems = [
        {
            type: "item",
            //icon: "clone",
            text: "Xem nhanh",
            action: function () { //option, contextMenuIndex, optionIndex
                console.log($(this).data('id'));
                modal_open('modalGlobal', 'Thông tin công việc', '/TaskWork/View/' + $(this).data('id'), 0);
            }
        },
        {
            type: "divider"
        },
        {
            type: "submenu",
            text: "Cập nhật trạng thái",
            class: "submenu-vertical",
            items: [
                {
                    type: "item",
                    text: "Đang mở",
                    action: _debug
                },
                {   //toastr.warning("Không thể thay đổi trạng thái này");
                    type: "item",
                    text: "Mở lại",
                    action: function() {
                        console.log($(this).data('id'));
                        toastr.success('Cập nhật thành công Id: ' + $(this).data('id'));
                    }
                },
                {
                    type: "item",
                    text: "Trong tiến trình",
                    class: "submenu-vertical",
                    action: function () {
                        console.log($(this).data('id'));
                        toastr.success('Cập nhật thành công Id: ' + $(this).data('id'));
                    }
                },
                {
                    type: "item",
                    //icon: "globe",
                    text: "Đang làm",
                    action: function () {
                        console.log($(this).data('id'));
                        toastr.success('Cập nhật thành công Id: ' + $(this).data('id'));
                    }
                },
                {
                    type: "item",
                    text: "Đã xong",
                    action: function () {
                        console.log($(this).data('id'));
                        toastr.success('Cập nhật thành công Id: ' + $(this).data('id'));
                    }
                },
                {
                    type: "item",
                    text: "Đang xem",
                    action: function () {
                        console.log($(this).data('id'));
                        toastr.success('Cập nhật thành công Id: ' + $(this).data('id'));
                    }
                },
                {
                    type: "item",
                    text: "Đã duyệt",
                    action: function () {
                        console.log($(this).data('id'));
                        toastr.success('Cập nhật thành công Id: ' + $(this).data('id'));
                    }
                },
                {
                    type: "item",
                    text: "Từ chối",
                    action: function () {
                        console.log($(this).data('id'));
                        toastr.success('Cập nhật thành công Id: ' + $(this).data('id'));
                    }
                },
                {
                    type: "item",
                    text: "Đã hủy",
                    action: function () {
                        console.log($(this).data('id'));
                        toastr.success('Cập nhật thành công Id: ' + $(this).data('id'));
                    }
                },
                {
                    type: "item",
                    text: "Đã đóng",
                    action: function () {
                        console.log($(this).data('id'));
                        toastr.success('Cập nhật thành công Id: ' + $(this).data('id'));
                    }
                }
            ]
        },
        {
            type: "submenu",
            text: "Báo cáo tiến độ",
            class: "sub-horizontal",
            items: [
                {
                    type: "item",
                    text: "10%",
                    class: "sub-item",
                    action: function () {
                        console.log($(this).data('id'));
                        toastr.success('Cập nhật thành công Id: ' + $(this).data('id'));
                    }
                },
                {
                    type: "item",
                    text: "20%",
                    action: function () {
                        console.log($(this).data('id'));
                        toastr.success('Cập nhật thành công Id: ' + $(this).data('id'));
                    }
                },
                {
                    type: "item",
                    text: "30%",
                    action: function () {
                        console.log($(this).data('id'));
                        toastr.success('Cập nhật thành công Id: ' + $(this).data('id'));
                    }
                },
                {
                    type: "item",
                    text: "40%",
                    action: function () {
                        console.log($(this).data('id'));
                        toastr.success('Cập nhật thành công Id: ' + $(this).data('id'));
                    }
                },
                {
                    type: "item",
                    text: "50%",
                    action: function () {
                        console.log($(this).data('id'));
                        toastr.success('Cập nhật thành công Id: ' + $(this).data('id'));
                    }
                },
                {
                    type: "item",
                    text: "60%",
                    action: function () {
                        console.log($(this).data('id'));
                        toastr.success('Cập nhật thành công Id: ' + $(this).data('id'));
                    }
                },
                {
                    type: "item",
                    text: "70%",
                    action: function () {
                        console.log($(this).data('id'));
                        toastr.success('Cập nhật thành công Id: ' + $(this).data('id'));
                    }
                },
                {
                    type: "item",
                    text: "80%",
                    action: function () {
                        console.log($(this).data('id'));
                        toastr.success('Cập nhật thành công Id: ' + $(this).data('id'));
                    }
                },
                {
                    type: "item",
                    text: "90%",
                    action: function () {
                        console.log($(this).data('id'));
                        toastr.success('Cập nhật thành công Id: ' + $(this).data('id'));
                    }
                },
                {
                    type: "item",
                    text: "Hoàn thành",
                    action: function () {
                        console.log($(this).data('id'));
                        toastr.success('Cập nhật thành công Id: ' + $(this).data('id'));
                    }
                },
            ]
        },
        {
            type: "item",
            text: "Thêm người thực hiện",
            action: function () {
                console.log($(this).data('id'));
                toastr.success('Cập nhật thành công Id: ' + $(this).data('id'));
            }
        },
        {
            type: "item",
            text: "Thêm đầu việc",
            action: function () {
                //console.log($(this).data('id'));
                modal_open('modalGlobal', 'Thông tin công việc', '/TaskWork/TaskList/' + $(this).data('id'));
            }
        },
        {
            type: "item",
            text: "Thêm công việc con",
            action: function () {
                //console.log($(this).data('id'));
                modal_open('modalGlobal', 'Thêm công việc con', '/TaskWork/Detail/' + $(this).data('id'));
            }
        },
        {
            type: "item",
            text: "Cập nhật thời gian",
            action: function () {
                console.log($(this).data('id'));
                toastr.success('Cập nhật thành công Id: ' + $(this).data('id'));
            }
        },
        {
            type: "item",
            text: "Chuyển công việc",
            action: function () {
                console.log($(this).data('id'));
                toastr.success('Cập nhật thành công Id: ' + $(this).data('id'));
            }
        },
        {
            type: "divider"
        },
        {
            type: "item",
            text: "Nhân bản công việc",
            action: function () {
                console.log($(this).data('id'));
                modal_open('modalGlobal', 'Nhân bản công việc', '/TaskWork/TaskReplica/' + $(this).data('id'));
            }
        },
        {
            type: "item",
            text: "Sửa công việc",
            action: function () {
                //console.log($(this).data('id'));
                modal_open('modalGlobal', 'Sửa thông tin', '/TaskWork/Edit/' + $(this).data('id'));
            }
        },
        /*
        {
            type: "item",
            icon: "refresh",
            text: "Ricarica",
            action: function () { //option, contextMenuIndex, optionIndex
                //window.location.reload();
                console.log($(this).data('id'))
            }
        },
        {
            type: "item",
            icon: "home",
            text: "Torna alla home",
            action: function () {
                //window.location.href = "/";
                console.log($(this).data('id'))
            }
        }
        */
    ];

    $(".products__row:not(.products__row_head)").contextMenu({
        items: _menuItems
    });
});