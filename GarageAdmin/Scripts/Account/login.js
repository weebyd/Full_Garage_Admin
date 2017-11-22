function login() {
    var username = $("#username").val();
    var password = $("#password").val();

    $.ajax({
        type: "POST",
        //url: API_URL + "Account/SignIn",
        url: "http://35.197.92.104:80/api/" + "Account/Login",
        data: {
            username: username,
            password: password
        },
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function () {
            debugger
        },
        error: function () {
            debugger
        }
    });

}
