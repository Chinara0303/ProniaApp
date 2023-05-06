$(function () {
    //delete slider

    $(document).on("click", ".delete", function (e) {
        e.preventDefault();
        let deleteElem = $(this).parent().parent();
        let id = $(this).parent().attr("data-id");
        let data = { id: id };
        let tbody = $(deleteElem).parent().children();
        $.ajax({
            url: "Slider/Delete",
            type: "Post",
            data: data,
            success: function () {
                if ($(tbody).length == 1) {
                    $(".table").remove();
                }
                $(deleteElem).remove();
            }
        })
    })



})