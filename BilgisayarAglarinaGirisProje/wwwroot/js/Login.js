function Login() {
    var EMail = $("#loginEmail").val();
    var Password = $("#loginPassword").val();
    var loginViewModel = {
        EMail: EMail,
        Password: Password
    };
    $.ajax({
        type: "POST",
        url: "/LoginUser",
        data: loginViewModel,
        async: false,
        success: function (result) {
            if (result !== null) {
                $("#userId").val(result.id)
                window.location.assign("/Blog/Blog")
            }
            else {
                alert();
            }
        },
        error: function (xhr, status, p3, p4) {
            console.log(err);
        },
    });
}