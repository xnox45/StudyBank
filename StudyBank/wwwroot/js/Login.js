$(document).ready(function () {
    localStorage.clear();
});

function storage() {

    url = '/Login/GetAccount'

    model = {
        email: $("#email").val(),
        password: $("#password").val(),
    }

    $.ajax({
        url: url,
        type: 'POST',
        data: model,
        success: function (response) {
            localStorage.setItem("User", JSON.stringify(response));
        }
    });
}