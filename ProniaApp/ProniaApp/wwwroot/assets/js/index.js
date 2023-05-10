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
   
})