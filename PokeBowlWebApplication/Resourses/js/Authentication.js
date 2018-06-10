jQuery(document).ready(function ($) {

    $(".jsLoginForm").submit(function (e) {
        e.preventDefault();

        var form = $(this);
        $.ajax({
            url: form.attr('action'),
            type: form.attr('method'),
            data: form.serialize(),
            success: function (data) {
                $(".loginFormWrap").html(data);
            },
            error: function (data) {
                alert(data);
            }
        });
    });
});