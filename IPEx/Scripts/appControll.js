$(".toggle-password").click(function () {

    $(this).toggleClass("fa-eye fa-eye-slash");
    var input = $($(this).attr("toggle"));
    if (input.attr("type") == "password") {
        input.attr("type", "text");
    } else {
        input.attr("type", "password");
    }
});
$(".btnCreate").click(function (e) {
    e.preventDefault();
    $(".pCreative").toggle();
});
$(".btnConsumer").click(function (e) {
    e.preventDefault();
    $(".pConsumer").toggle();
});