Chats = []
let userId = 0

$(document).ready(function () {
    getChats();
})

function getChats() {
    $.ajax({
        type: "GET",
        url: "/getChats",
        async: false,
        success: function (result) {
            if (result) {
                Chats = result;
                var html = "";
                for (var i = 0; i < result.length; i++) {
                    var chat = result[i]
                    html += `<li onclick="GetMessages(` + result[i].id + `)" class="clearfix"><img src="https://bootdey.com/img/Content/avatar/avatar3.png" alt="avatar"/><div class='about'><div class="name">`
                    html += result[i].userViewModelSender.id === result[i].userid ? result[i].userViewModelGetter.username : result[i].userViewModelSender.username
                    html += `</div><div class="status"> <i class='fa fa-circle offline'></i></div></div></li>`
                }
                userId = result[0].userid;
                $("#ChatList").append(html);
            }
            else {
                alert();
            }
        },
        error: function (xhr, status, p3, p4) {
            console.log(err);
        },
    })
}

function createChat() {
    var username = $("#getterUsername").val();
    var model = {
        UserViewModelSender: {
            id:0
        },
        UserViewModelGetter: {
            Username: username
        }
    };
    $.ajax({
        type: "POST",
        url: "/createNewChat",
        data: model,
        async: false,
        success: function (result) {
            window.location.reload();
        },
        error: function (err) {
            alert("Kullanıcı adını kontrol edin!")
        },
    })
}