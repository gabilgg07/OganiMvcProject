"use strict";
(function ($) {
    $(window).on("load", function () {
        $(".loader").fadeOut();
        $("#preloder").delay(200).fadeOut("slow");
        $(".featured-controls li").on("click", function () {
            $(".featured-controls li").removeClass("active");
            $(this).addClass("active");
        });
        // if ($(".featured-filter").length > 0) {
        // //   var containerEl = document.querySelector(".featured-filter");
        //   //   var mixer = mixitup(containerEl);
        // }
    });
    $(".set-bg").each(function () {
        var bg = $(this).data("setbg");
        $(this).css("background-image", "url(" + bg + ")");
    });
    $(".humberger-open").on("click", function () {
        $(".humberger-menu-wrapper").addClass("show-humberger-menu-wrapper");
        $(".humberger-menu-overlay").addClass("active");
        $("body").addClass("over_hid");
    });
    $(".humberger-menu-overlay").on("click", function () {
        $(".humberger-menu-wrapper").removeClass("show-humberger-menu-wrapper");
        $(".humberger-menu-overlay").removeClass("active");
        $("body").removeClass("over_hid");
    });
    $(".mobile-menu").slicknav({
        prependTo: "#mobile-menu-wrap",
        allowParentLinks: true,
    });
    $(".categories-slider").owlCarousel({
        loop: true,
        margin: 0,
        items: 4,
        dots: false,
        nav: true,
        navText: [
            "<span class='fa fa-angle-left'><span/>",
            "<span class='fa fa-angle-right'><span/>",
        ],
        animateOut: "fadeOut",
        animateIn: "fadeIn",
        smartSpeed: 1200,
        autoHeight: false,
        autoplay: true,
        responsive: {
            0: { items: 1 },
            480: { items: 2 },
            768: { items: 3 },
            992: { items: 4 },
        },
    });
    $(".hero-categories-all").on("click", function () {
        $(".hero-categories ul").slideToggle(400);
    });
    $(".latest-product-slider").owlCarousel({
        loop: true,
        margin: 0,
        items: 1,
        dots: false,
        nav: true,
        navText: [
            "<span class='fa fa-angle-left'><span/>",
            "<span class='fa fa-angle-right'><span/>",
        ],
        smartSpeed: 1200,
        autoHeight: false,
        autoplay: true,
    });
    $(".product-discount-slider").owlCarousel({
        loop: true,
        margin: 0,
        items: 3,
        dots: true,
        smartSpeed: 1200,
        autoHeight: false,
        autoplay: true,
        responsive: {
            320: { items: 1 },
            480: { items: 2 },
            768: { items: 2 },
            992: { items: 3 },
        },
    });
    $(".product-details-pic-slider").owlCarousel({
        loop: true,
        margin: 20,
        items: 4,
        dots: true,
        smartSpeed: 1200,
        autoHeight: false,
        autoplay: true,
    });

    var rangeSlider = $(".price-range"),
        minamount = $("#minamount"),
        maxamount = $("#maxamount"),
        minPrice = rangeSlider.data("min"),
        maxPrice = rangeSlider.data("max");

    if (rangeSlider) {
        rangeSlider.slider({
            range: true,
            min: minPrice,
            max: maxPrice,
            values: [minPrice, maxPrice],
            slide: function (event, ui) {
                minamount.val("$" + ui.values[0]);
                maxamount.val("$" + ui.values[1]);
            },
        });
        minamount.val("$" + rangeSlider.slider("values", 0));
        maxamount.val("$" + rangeSlider.slider("values", 1));
    }
    $("select").niceSelect();
    $(".product-details-pic-slider img").on("click", function () {
        var imgurl = $(this).data("imgbigurl");
        var bigImg = $(".product-details-pic-item--large").attr("src");
        if (imgurl != bigImg) {
            $(".product-details-pic-item--large").attr({ src: imgurl });
        }
    });

    var proQty = $(".pro-qty");
    proQty.prepend('<span class="dec qtybtn">-</span>');
    proQty.append('<span class="inc qtybtn">+</span>');
    proQty.on("click", ".qtybtn", function () {
        var $button = $(this);
        var oldValue = $button.parent().find("input").val();
        if ($button.hasClass("inc")) {
            var newVal = parseFloat(oldValue) + 1;
        } else {
            if (oldValue > 0) {
                var newVal = parseFloat(oldValue) - 1;
            } else {
                newVal = 0;
            }
        }
        $button.parent().find("input").val(newVal);

        if (typeof window["qtyChanged"] == "function") {
            window["qtyChanged"](newVal, $($button).closest("tr")[0]);
        }
    });

    //   $(".imager").imgadd();
})(jQuery);

function qtyChanged2(value, tr) {
    let priceStr = $(tr).find(".shoping-cart-price").text().trim();
    let price = priceStr.substring(1);
    let symb = priceStr.substring(0, 1);
    let total = (price * value).toFixed(2);
    $(tr).find(".shoping-cart-total").text(`${symb}${total}`);

    // yuxaridaki sekilde tehlukelidir, cunki, yoxlanis olmur.
}
function qtyChanged(value, tr) {
    // asagidaki sekilde tehlukesizdir:

    let priceStr = $(tr).find("td.shoping-cart-price").text().trim();
    let groups = /^(\$)(\d+\.\d{1,2})$/.exec(priceStr);
    if (groups != null) {
        let symb = groups[1];
        let price = groups[2];
        let amount = (price * value).toFixed(2);
        $(tr).find("td.shoping-cart-total").text(`${symb}${amount}`);
        computeTotalSum();
    }
}

function computeTotalSum() {

    let prices = $("td.shoping-cart-total").map((i, p) => {
        let groups = /^(\$)(\d+\.\d{1,2})$/.exec($(p).text().trim());
        if (groups == null) return 0;
        let price = groups[2];
        return parseFloat(price);
    });

    let sum = 0;
    if (prices.length != 0) {
        sum = prices.toArray().reduce(function (a, b) {
            return a + b;
        });
    }

    $("#subtotal").text(`$${sum.toFixed(2)}`);
    $("#total").text(`$${sum.toFixed(2)}`);
}
function computeTotalSum2() {
    let prices = $("td.shoping-cart-price")
        .toArray()
        .map((p) => {
            let input = $(p).closest("tr").find('.pro-qty input[type="text"]').val();
            let groups = /^(\$)(\d+\.\d{1,2})$/.exec(p.innerText);
            if (groups == null) return 0;
            let price = groups[2];

            return parseFloat(price) * parseFloat(input);
        });

    if (prices.length == 0) {
        $("#subtotal").text(`$0.00`);
        return;
    }
    let sum = 0;
    if (prices.length != 0) {
        sum = prices.reduce(function (a, b) {
            return a + b;
        });
    }

    $("#subtotal").text(`$${sum.toFixed(2)}`);
}
if ($("td.shoping-cart-total").length != 0) {
    computeTotalSum();
}
$(".shoping-cart-item-close").on("click", function (e) {
    e.preventDefault();
    $(e.currentTarget).closest("tr").remove();

    computeTotalSum();
});
