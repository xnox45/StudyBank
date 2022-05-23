// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function Home() {
    model = JSON.parse(localStorage.getItem("User"));

    req = {
        type: 'POST',
        data: model,
        url: '/home/Index',
        success: function (response) {
            window.location.href("home/Index")
        }
    }

    $.ajax(req)
}


function Account() {

    model = JSON.parse(localStorage.getItem("User"));

    req = {
        type: 'POST',
        data: model,
        url: '/home/account',
        success: function (response) {
            $("#divContent").html(response);
        }
    }

    $.ajax(req)
}
