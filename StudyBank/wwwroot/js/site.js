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
