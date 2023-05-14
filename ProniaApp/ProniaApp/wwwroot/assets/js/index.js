$(function () {

    function GetProductsById(clickedElem, url) {
        $(document).on("click", clickedElem, function (e) {
            e.preventDefault();
            let id = $(this).attr("data-id");
            let data = { id: id };
            let parent = $(".product-grid-view")
            $.ajax({
                url: url,
                type: "Get",
                data: data,
                success: function (res) {
                    $(parent).html(res);
                }
            })
        })

    }

    GetProducts(".all", "/Shop/GetProducts")

    function GetProducts(clickedElem,url) {
        $(document).on("click", clickedElem, function (e) {
            e.preventDefault();
            let parent = $(".product-grid-view")
            $.ajax({
                url: url,
                type: "Get",
                success: function (res) {
                    $(parent).html(res);
                }
            })
        })

    }

    GetProductsById(".category", "/Shop/GetProductsByCategory")
    GetProductsById(".color", "/Shop/GetProductsByColor")
    GetProductsById(".tag", "/Shop/GetProductsByTag")


    //add cart
    AddToCart(".add-to-cart-btn", "/Shop/AddToCart");

    function AddToCart(clickedElem, url) {
        $(document).on("click", clickedElem, function (e) {
            debugger
            let id = $(this).attr("data-id");
            let data = { id: id };
            $.ajax({
                type: "Post",
                url: url,
                data: data,
                success: function (res) {
                    $(".minicart-list").empty();
                    $(".minicart-list").html(res);
                    //$(".empty-msg").removeClass("d-block")
                }
            })
            return false;
        })
    }

    //delete product from basket
    $(document).on("click", ".delete-product", function () {

        let id = $(this).parent().parent().attr("data-id");
        let prod = $(this).parent().parent();
        let tbody = $(".tbody").children();
        let data = { id: id };

        $.ajax({
            type: "Post",
            url: `Cart/DeleteDataFromBasket`,
            data: data,
            success: function () {
                if ($(tbody).length == 1) {
                    $(".product-table").addClass("d-none");
                    //$(".footer-alert").removeClass("d-none")
                }
                $(prod).remove();
                //$(".rounded-circle").text(res)
                grandTotal();
            }
        })
        return false;
    })

    //change product count
    $(document).on("click", ".inc", function () {
        let id = $(this).parent().parent().parent().attr("data-id");
        let nativePrice = parseFloat($(this).parent().parent().prev().children().eq(1).text());
        let total = $(this).parent().parent().next().children().eq(1);
        let count = $(this).prev().prev();

        $.ajax({
            type: "Post",
            url: `Cart/IncrementProductCount?id=${id}`,
            success: function (res) {
                res++;
                subTotal(res, nativePrice, total, count)
                grandTotal();
            }
        })
    })

    $(document).on("click", ".dec", function () {
        let id = $(this).parent().parent().parent().attr("data-id");
        let nativePrice = parseFloat($(this).parent().parent().prev().children().eq(1).text());
        let total = $(this).parent().parent().next().children().eq(1);
        let count = $(this).next();

        $.ajax({
            type: "Post",
            url: `Cart/DecrementProductCount?id=${id}`,
            success: function (res) {
                if ($(count).val() == 1) {
                    return;
                }
                res--;
                subTotal(res, nativePrice, total, count)
                grandTotal();
            }
        })
    })


    function grandTotal() {
        let tbody = $(".tbody").children()
        let sum = 0;
        for (var prod of tbody) {
            let price = parseFloat($(prod).children().eq(5).children().eq(1).text())
            sum += price
        }
        $(".grand-total").text(sum);
    }

    function subTotal(res, nativePrice, total, count) {
        $(count).val(res);
        let subtotal = parseFloat(nativePrice * $(count).val());
        $(total).text(subtotal);
    }



    $(document).on("submit", ".hm-searchbox", function () {
        console.log($(this))
        let value = $(".input-search").val();

        let url = `/Shop/Search?searchText=${value}`;
        window.location.assign(url);
        return false;
     
    })
})