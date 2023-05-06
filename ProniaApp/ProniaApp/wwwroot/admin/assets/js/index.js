$(function () {
    //delete slider

    //$(document).on("click", ".delete", function (e) {
    //    RemoveItem(".delete")
    //    e.preventDefault();
    //    let deleteElem = $(this).parent().parent();
    //    let id = $(this).parent().attr("data-id");
    //    let data = { id: id };
    //    let tbody = $(deleteElem).parent().children();
    //    $.ajax({
    //        url: "Slider/Delete",
    //        type: "Post",
    //        data: data,
    //        success: function () {
    //            if ($(tbody).length == 1) {
    //                $(".table").remove();
    //            }
    //            $(deleteElem).remove();
    //        }
    //    })
    //})

    RemoveItem(".delete", "/Admin/Slider/Delete");
    RemoveItem(".delete-advert", "/Admin/Advert/Delete");

    function RemoveItem(clickedElem, url) {
        $(document).on("click", clickedElem, function (e) {
            debugger
            e.preventDefault();
            console.log($(this))
            let deleteElem = $(clickedElem).parent().parent();
            let id = $(clickedElem).parent().attr("data-id");
            let data = { id: id };
            let tbody = $(deleteElem).parent().children();
            $.ajax({
                url: url,
                type: "Post",
                data: data,
                success: function () {
                    debugger
                    //if ($(tbody).length == 1) {
                    //    debugger
                    //    $(".table").remove();
                    //}
                    for (var item of deleteElem) {
                        debugger
                        if (item.attr("data-id") == id) {
                            item.remove();
                        }
                    }       
                    
                    //$(deleteElem).remove();
                }
            })
        })
    }
})