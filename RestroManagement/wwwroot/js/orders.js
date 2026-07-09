var currentDate = new Date();

function formatDate(date) {
    let y = date.getFullYear();
    let m = ("0" + (date.getMonth() + 1)).slice(-2);
    let d = ("0" + date.getDate()).slice(-2);

    return y + "-" + m + "-" + d;
}

function loadOrders() {

    var date = formatDate(currentDate);

    $("#selectedDate").text(date);

    $.ajax({
        url: '/Restaurant/Home/GetRecentOrders',
        type: 'GET',
        data: { date: date },
        success: function (result) {
            $("#orderList").html(result);
        },
        error: function () {
            alert("Not Loaded Sucessfully");
        }
    });
}


$(document).ready(function () {

    loadOrders();

    $("#prevDate").click(function () {
        currentDate.setDate(currentDate.getDate() - 1);
        loadOrders();
    });


    $("#nextDate").click(function () {
        currentDate.setDate(currentDate.getDate() + 1);
        loadOrders();
    });

});