$(function () {


    $(document).on("click", "#products .add-basket", function () {
        let id = parseInt($(this).attr("data-id"));

        $.ajax({
            type: "POST",
            url:`home/addproducttobasket?id=${id}`,
            success: function (response) {
                $(".rounded-circle").text(response.count)
                $(".rounded-circle").next().text(`CART ($${response.totalPrice})`)

            }
        });


    })




    $(document).on("click", "#cart-page .fa-trash-alt", function () {
        let id = parseInt($(this).attr("data-id"));

        $.ajax({
            type: "POST",
            url: `cart/DeleteProductFromBasket?id=${id}`,
            success: function (response) {
                $(".rounded-circle").text(response.totalCount);
                $(".rounded-circle").next().text(`CART ($${response.totalPrice})`);
                $(".cart-grand-total").text(`$${response.totalPrice}`);
                $(".total-basket-count").text(`You have ${response.basketCount} items in your cart`);
                $(`[data-id=${id}]`).closest(".card").remove();
            }
        });
    })


    $(document).on("click", ".plus", function () {
        let id = parseInt($(this).attr("data-id"));
        let finalCount = parseInt($(this).parent().find(".count").text())

        finalCount++

        $(this).parent().find(".count").text(finalCount)

        $.ajax({
            type: "POST",
            url: `cart/increseDecreasebasketcount?id=${id}&count=${finalCount}`,
            success: function (response) {
                $(".rounded-circle").text(response.totalCount);
                $(".rounded-circle").next().text(`CART ($${response.totalPrice})`);
                $(".cart-grand-total").text(`$${response.totalPrice}`);
            }
        });
    })

    $(document).on("click", ".minus", function () {
        let id = parseInt($(this).attr("data-id"));
        let finalCount = parseInt($(this).parent().find(".count").text())


        finalCount--

        if (finalCount > 0) {
            $(this).parent().find(".count").text(finalCount)

            $.ajax({
                type: "POST",
                url: `cart/increseDecreasebasketcount?id=${id}&count=${finalCount}`,
                success: function (response) {
                    $(".rounded-circle").text(response.totalCount);
                    $(".rounded-circle").next().text(`CART ($${response.totalPrice})`);
                    $(".cart-grand-total").text(`$${response.totalPrice}`);
                }
            });
        }

        
    })




})
