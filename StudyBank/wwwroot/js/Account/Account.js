$(document).ready(function () {
    LoadPage();
});

user = JSON.parse(localStorage.getItem("User"));

function LoadPage() {
    $("#Name").html(user.person.name);
    $("#Amount").append(user.amount);
    $("#Credit").append(user.credit);
}


$("#Transfer").click(function () {
    $("#TransferModal").modal();
})

function Transfer() {
    url = "/Account/Transfer"

    model = {
        Amount: $("#TransferAmount").val(),
        InTaxnumber: $("#Taxnumber").val(),
        OutTaxnumber: user.person.taxNumber

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