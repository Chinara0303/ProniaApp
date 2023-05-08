$(function () {
    //delete 

    RemoveItem("/Admin/Slider/Delete");
    RemoveItem("/Admin/Advert/Delete");
    RemoveItem("/Admin/Category/Delete");
    RemoveItem("/Admin/Size/Delete");
    RemoveItem("/Admin/Testimonial/Delete");
    RemoveItem("/Admin/Color/Delete");
    RemoveItem("/Admin/Tag/Delete");
    RemoveItem("/Admin/Banner/Delete");
    RemoveItem("/Admin/Brand/Delete");

    function RemoveItem(url) {
        $(document).on("click", ".delete", function (e) {
            e.preventDefault()
            let deleteElem = $(this).parent().parent();
            let id = $(this).parent().parent().attr("data-id");
            let data = { id: id };
            let tbody = $(deleteElem).parent().children();
            $.ajax({
                url: url,
                type: "Post",
                data: data,
                success: function () {
                    if ($(tbody).length == 1) {
                        $(".table").remove();
                    }
                    for (let item of deleteElem) {
                        if ($(item).attr("data-id") == id) {
                            $(item).remove();
                            $(".tooltip-inner").remove()
                            $(".arrow").remove()
                        }
                    }
                }
            })
        })
    }


   
})