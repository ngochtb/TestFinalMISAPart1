$(document).ready(function () {
    /* new EmployeeJs();*/
})



/**
 * Hàm định dạng ngày/tháng/năm
 * @param {any} date
 * created by ngochtb(12/11/2020)
 */
function formatDate(date) {
    var date = new Date(date);
    if (Number.isNaN(date.getTime())) {
        return "";
    }
    else {
        var day = date.getDate();
        month = date.getMonth() + 1;
        year = date.getFullYear();
        day = day < 10 ? '0' + day : day;
        month = month < 10 ? '0' + month : month;
        return day + '/' + month + '/' + year;
    }

}
/**
 * Hàm định dạng ngày-tháng-năm
 * @param {any} date
 * createdby ngochtb(21/11/2020)
 */
function formatDatePicker(date){
    var date = new Date(date);
    var day = date.getDate();
    month = date.getMonth() + 1;
    year = date.getFullYear();
    day = day < 10 ? '0' + day : day;
    month = month < 10 ? '0' + month : month;
    return year + '-' + month + '-' + day;
}

/**
 * Hàm định dạng tiền tệ
 * @param {Number} money số tiền
 * created by ngochtb(12/11/2020)
 */

function formatMoney(money) {
    if (money === null)
        return "";
    else
        return money.toFixed(0).replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1.");
}

/**
 * Kiểm tra giá trị null
 * @param {any} item
 * created by ngochtb(12/11/2020)
 */

function checkNull(item) {
    if (item === null)
        return "";
    else
        return item;
}
/**
 * Kiểm tra trường bỏ trống
 * createdby ngochtb(21/11/2020)
 * */

function validateEmpty() {
    var value = $(this).val();
    if (!value) {
        $(this).addClass('border-red');
        $(this).attr('title', 'Trường này không được phép để trống');
        $(this).attr("validate", false);
    }
    else {
        $(this).removeClass('border-red');
        $(this).attr('validate', true);
    }
}
/**
 * Kiểm tra trường email hợp lệ
 * createdby ngochtb(21/11/2020)
 * */
function validateEmail() {
    var value = $(this).val();
    var regex = /^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/;
    if (!regex.test(value)) {
        $(this).addClass('border-red');
        $(this).attr('title', 'Email không đúng định dạng');
        $(this).attr("validate", false);
    } else {
        $(this).removeClass('border-red');
        $(this).attr('validate', true);
    }
}


