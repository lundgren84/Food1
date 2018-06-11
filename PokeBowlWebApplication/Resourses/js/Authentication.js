jQuery(document).ready(function ($) {

    $(".jsLoginForm").submit(function (e) {
        e.preventDefault();

        var form = $(this);
        $.ajax({
            url: form.attr('action'),
            type: form.attr('method'),
            data: form.serialize(),
            success: function (data) {
                if (data === "great success") {
                    location.reload();
                } else {
                    $(".jsLoginFormWrap").html(data);
                }
            },
            error: function (data) {
                alert(data);
            }
        });
    });
});

jQuery(document).ready(function ($) {

    $(".jsRegisterForm").submit(function (e) {
        e.preventDefault();

        var form = $(this);
        $.ajax({
            url: form.attr('action'),
            type: form.attr('method'),
            data: form.serialize(),
            success: function (data) {
                if (data === "great success") {
                    location.reload();
                    console.log("ALL OK");
                } else {
                    $(".jsRegisterFormWrap").html(data);
                }
            },
            error: function (data) {
                alert(data);
            }
        });
    });
});
