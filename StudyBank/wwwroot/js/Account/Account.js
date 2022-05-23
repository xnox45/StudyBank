$(document).ready(function () {
    LoadPage();
});

model = JSON.parse(localStorage.getItem("User"));

function LoadPage() {
    $("#Name").html(model.Person.Name);
    $("#Amount").append(model.Amount);
    $("#Credit").append(model.Credit);
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