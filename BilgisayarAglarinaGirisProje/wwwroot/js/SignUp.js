$('#SignInPassword').on('input', function (e) {
    var password = $("#SignInPassword").val();
    var conf = $("#SignInPasswordConf").val();
    if (password !== conf) {
        $("#conferr").css("display", "block")
    }
    else {
        $("#conferr").css("display", "none")
    }
});

$('#SignInPasswordConf').on('input', function (e) {
    var password = $("#SignInPassword").val();
    var conf = $("#SignInPasswordConf").val();
    if (password !== conf) {
        $("#conferr").css("display", "block")
    }
    else {
        $("#conferr").css("display", "none")
    }
});

function SignUp() {
    var password = $("#SignInPassword").val();
    var conf = $("#SignInPasswordConf").val();
    if (password === conf) {
        var Ad = $("#SignInAd").val();
        var Soyad = $("#SignInSoyad").val();
        var EMail = $("#SignInEmail").val();
        var Password = $("#SignInPassword").val();
        var Username = $("#SignInUsername").val();
        var SignUpViewModel = {
            Ad: Ad,
            Soyad: Soyad,
            EMail: EMail,
            Password: Password,
            Username: Username
        };
        $.ajax({
            type: "POST",
            url: "/SignUp",
            data: SignUpViewModel,
            async: false,
            success: function (result) {
                if (result === 1) {
                    window.location.href = "/Login/Login";
                }
                else {
                    alert();
                }
            },
            error: function (err) {
                console.log(err);
            },
        });
    }
}