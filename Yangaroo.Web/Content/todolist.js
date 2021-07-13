

$(document).ready(function () {
    $("button").prop('disabled', true);

    $("form#addEntry").submit(function (e) {
        e.preventDefault();
        if ($("#todoitem").val().length == 0) {
            alert("Please enter a to-do list item");
            return;
        }
        $.ajax({
            url: "/ToDoList/AddItem",
            data: { "item": $("#todoitem").val() },
            type: "POST",
            success: function (result) {
                if (result != undefined && result.result) {
                    var data = result.data;
                    $("#todo").empty();
                    data.forEach(function (item) {
                        $("#todo").append("<li>" + item.ListItem + "</li");
                    });
                    $('form').trigger("reset");
                }
                else {
                    console.log("adding to to-do list failed!")
                }
            },
            error: function () {
                console.log("error");
            }
        })
    });
    $('#todoitem').on('input', function () {
        if ($(this).val().length > 0)
            $("button").prop('disabled', false);
        else
            $("button").prop('disabled', true);
    });

})