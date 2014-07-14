AddAntiForgeryToken = function (data) {
    data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
    return data;
};

$(document).ready(function () {
    $(".J_Logout").click(function () {
        $.ajax({
            type: "post",
            dataType: "json",
            url: $(this).attr("rel"),
            data: AddAntiForgeryToken({}),
            success: function (response) {
                if (response.ResultType==0) {
                    location.href = "Home/Login";
                }
            }
        });
    });
    $(".J_MenuItem a").click(function () {
        $(".J_MenuItem").removeClass("active");
        $(this).parent().addClass("active");
        $(this).parent().parent().parent().parent().find(".J_Menu").removeClass("active");
        $(this).parent().parent().parent().addClass("active");
    });
});

LoadFailed = function (data) {
    console.log(data);
    if (data.status == 403) {
        alert("页面禁止访问，请重新登录！");
    } else {
        alert("页面加载错误！");
    }
};