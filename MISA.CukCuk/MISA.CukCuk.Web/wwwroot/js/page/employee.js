
$(document).ready(function () {
    new EmployeeJS();
    $(function () {
        dialogDetail = $("#dialog-form").dialog({
            autoOpen: false,
            width: 775,
            resizable: true,
            position: ({ my: "center", at: "center", of: window }),
            fluid: true,
            modal: true,
        
        });
        dialogConfirm = $("#dialog-confirm").dialog({
            autoOpen: false,
            resizable: false,
            height: "auto",
            width: 400,
            modal: true,
        });

    })

})

/**
 * Class quản lý các sự kiện cho trang Customer
 * created by ngochtb(13/11/2020)*/

class EmployeeJS extends BaseJS {
    constructor() {
        super();
        this.buildSelectsEmployee();        
        this.search();
        this.getMaxEmployeeCode();
    }
    setApiRouter() {
        this.apiRouter = "/api/v1/employees";
    }

    /**
     * hàm tìm kiếm
     * */
    search() {
        var me = this;
        $('.search-select').change(function () {
            var propertyValue = $('.search-input').val();
            var departmentID = $('.search-select-department option:selected').val();
            var possitionID = $('.search-select-possition option:selected').val();
            var url = `/api/v1/employees/filter?specs=${propertyValue}&departmentID=${departmentID}&PossitionID=${possitionID}`;
            me.loadData(url);
        });

        $('.search-input').on('keypress', function (e) {
            if (e.which == 13) {
                var propertyValue = $('.search-input').val();
                var departmentID = $('.search-select-department option:selected').val();
                var possitionID = $('.search-select-possition option:selected').val();               

                var url = `/api/v1/employees/filter?specs=${propertyValue}&departmentID=${departmentID}&PossitionID=${possitionID}`;
                me.loadData(url);
            }
        });
    }

    // build combobox 
    buildSelectsEmployee() {
        $('#cbxDepartment').append($('<option value="" selected>Tất cả phòng ban</option>'));
        $('#cbxPossition').append($('<option value="" selected>Tất cả vị trí</option>'));

        var me = this;
        var selects = $('.search .build-select');
        $.each(selects, function (index, select) {
            var _url = $(select).attr("api");
            var fieldValue = $(select).attr("fieldValue");
            var fieldName = $(select).attr("fieldName")
            $.ajax({
                url: me.host + _url,
                method: "GET",

            }).done(function (res) {
                if (res) {
                    $.each(res, function (index, obj) {

                        var option = $(`<option value="${obj[fieldValue]}">${obj[fieldName]}</option>`);
                        $(select).append(option);

                    })
                }
                $('.loading').hide();
            }).fail(function (res) {
                debugger;
                $('.loading').hide();
            })
        })
    }


    // lấy mã nhân viên lớn nhất khi thực hiện thêm mới
    getMaxEmployeeCode() {
        var me = this;
        $('#btnAdd').click(function () {
            try {
                $.ajax({
                    url: "http://localhost:51014/api/v1/employees/GetMaxEmployeeCode",
                    dataType: "JSON",
                    method: "GET",
                    success: function (response) {
                        debugger;
                        var employeeCode = response.Data;
                        employeeCode = employeeCode.replace(/\d+/g, function (latter) {
                            var length = latter.toString().length;
                            latter = parseInt(latter) + 1;
                            var length1 = latter.toString().length;
                            var string = "";
                            for (var i = 0; i < length - length1; i++) {
                                string = string + "0"
                            }
                            return string + latter;
                        });
                        $('#EmployeeCode').val(employeeCode);
                    },
                    error: function (err) {
                        console.log(err);

                    }
                });
            }
            catch (err) {
                console.log("Có lỗi xảy ra!");
            }
        })

    }
}