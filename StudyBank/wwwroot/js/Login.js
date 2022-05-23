$(document).ready(function () {
    storage()
});


function storage() {
    model = {
        Credit: $("#Credit").val(),
        Amount: $("#Amount").val(),
        Person: {
            Taxnumber: $("#Taxnumber").val(),
            Name: $("#Name").val(),
            BirthDate: $("#BirthDate").val()
        }
    };

    sessionStorage.setItem("User", JSON.stringify(model));
}

function SignIn() {

    url = "Login/SignIn"

    user = {
       email: $("#email").val(),
       password: $("#password").val()
    }

    storage.setItem("User", user);

    $.post(url, user, function (data) {
        alert(data)
    })


    //$.ajax({
    //    type: "POST",
    //    url: url,
    //    data: user,
    //    success: function (response) {
    //        window.location.href = "./Home/Index";
    //    }
    //});

    console.log("show");
}