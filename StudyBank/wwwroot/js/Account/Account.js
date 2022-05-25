$(document).ready(function () {
    LoadPage();
});

model = JSON.parse(localStorage.getItem("User"));

function LoadPage() {
    $("#Name").html(model.person.name);
    $("#Amount").append(model.amount);
    $("#Credit").append(model.credit);
}

$("#Transfer").click(function () {
    $("#TransferModal").modal();
})

function Transfer() {
    url = "/Account/Transfer"

    model = {
        Amount: $("#TransferAmount").val(),
        Taxnumber: $("#Taxnumber").val()
    }

    $.ajax({
        url: url,
        type: 'POST',
        data: model,
        success: function (response) {
            alert(response)
        }
    });
}