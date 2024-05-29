$(function () {
    $(document).on("click", "#edit .delete", function () {
        let id = parseInt($(this).attr("data-id"));


        $.ajax({
            type: "POST",
            url: `/admin/product/imagedelete?id=${id}`,
            success: function () {
                $(`[data-id=${id}]`).closest(".img-area").remove() 

            }
            
        });


    })

    $(document).on("click", "#edit .ismain", function () {
        let id = parseInt($(this).attr("data-id"));
        console.log(id)

        $.ajax({
            type: "POST",
            url: `/admin/product/ismain?id=${id}`,
            success: function () {
                $("img").removeClass("ismain-border")
                $(`[data-id=${id}]`).closest(".img-area").find("img").addClass("ismain-border")
                $(".buttons").removeClass("d-none")
                $(`[data-id=${id}]`).closest(".buttons").addClass("d-none")

            }

        });


    })
})
