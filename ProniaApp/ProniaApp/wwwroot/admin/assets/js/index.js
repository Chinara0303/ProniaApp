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
    RemoveItem("/Admin/Blog/Delete");

   
  
    SetStatus("/Admin/Blog/SetStatus");

    RemoveImage("/Admin/Blog/DeleteBlogImage");
   

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
    function RemoveImage(url) {
        $(document).on("click", ".delete-image", function (e) {
            e.preventDefault()
            let deleteItem = $(this).parent().parent();
            let imageId = $(this).parent().attr("data-id");
            let data = { id: imageId }
            $.ajax({
                url: url,
                type: "Post",
                data: data,
                success: function (res) {
                    if (res.result) {
                        $(deleteItem).remove();
                        let imagesId = $(".images").children().eq(0).attr("data-id");
                        let data = $(".images").children().eq(0);
                        let changeElem = $(data).children().eq(1).children().eq(1);

                        if (res.id == imagesId) {
                            if ($(changeElem).children().hasClass("de-active")) {
                                $(changeElem).children().eq(0).addClass("active-status");
                                $(changeElem).children().eq(0).removeClass("de-active");
                            }
                        }
                    }
                    else {
                        Swal.fire({
                            position: 'top-end',
                            icon: 'success',
                            title: 'Blog image must be minimum one',
                            showConfirmButton: false,
                            timer: 1500
                        })

                    }
                }
            })
        })
    }
    function SetStatus(url) {
        $(document).on("click", ".statuses .image-status", function () {
            let imageId = $(this).parent().parent().attr("data-id");
            let elems = $(".image-status")
            let changeElem = $(this);
            let data = { id: imageId }
            $.ajax({
                url: url,
                type: "Post",
                data: data,
                success: function (res) {
                    if (res) {
                        for (var elem of elems) {
                            debugger
                            if ($(elem).hasClass("active-status")) {
                                debugger
                                $(elem).removeClass("active-status")
                                $(elem).addClass("de-active")
                            }
                            else {
                                $(elem).addClass("de-active")
                                $(elem).addClass("active-status")
                            }
                        }
                        if ($(changeElem).hasClass("de-active")) {
                            debugger
                            $(changeElem).removeClass("de-active");
                            $(changeElem).addClass("active-status");
                        }
                    }
                    else {
                        debugger
                        for (var elem of elems) {
                            if ($(elem).hasClass("de-active")) {
                                debugger
                                $(elem).removeClass("de-active")
                                $(elem).addClass("active-status")
                            }
                        }
                        if ($(changeElem).hasClass("active-status")) {
                            debugger
                            $(changeElem).removeClass("active-status");
                            $(changeElem).addClass("de-active");
                        }
                    }
                }
            })
        })
    }
})