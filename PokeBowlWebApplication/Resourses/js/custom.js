//Smooth scroll
$(function () {
    $('a[href="#home"]:not([href="#"])').click(function () {
        if (location.pathname.replace(/^\//, '') == this.pathname.replace(/^\//, '') && location.hostname == this.hostname) {
            var target = $(this.hash);
            target = target.length ? target : $('[name=' + this.hash.slice(1) + ']');
            if (target.length) {
                $('html, body').animate({
                    scrollTop: target.offset().top - 79
                }, 500);
                return false;
            }
        }
    });
});

var cartOpen = false;
var accOpen = false;
var menuOpen = false;
$(".toolbar-toggle").on("click", function () {
    var me = $(this);

    var cartClick = me.hasClass("open-cart-btn")
    var menuClick = me.hasClass("open-menu-btn")
    var accClick = me.hasClass("open-account-btn")

    if (cartClick) {
        cartOpen = !cartOpen;
        accOpen = false;
        menuOpen = false;
    }
    if (accClick) {
        accOpen = !accOpen;
        cartOpen = false;
        menuOpen = false;
    }
    if (menuClick) {
        menuOpen = !menuOpen;
        cartOpen = false;
        accOpen = false;
    }

    if (cartOpen || accOpen || menuOpen) {
        $("body").addClass("noscroll"); 
        $("#cover").removeClass("hidden"); 
    } else {
        $("body").removeClass("noscroll")
        $("#cover").addClass("hidden"); 
    }
})