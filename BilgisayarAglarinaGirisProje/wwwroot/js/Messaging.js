MessageId = 0;
Messages = [];
LastMessageId = 0;
MediaId = 0;
let ChatId = 0;

$(document).ready(function () {
    setInterval(function () {
        if (ChatId !== 0) {
            checkNewMessages();
        }
    }, 3000);
})


function GetMessages(id) {
    var chat = Chats.filter(x => x.id === id)[0];
    $("#chatUsername").text(chat.userViewModelSender.id === userId ? chat.userViewModelGetter.username : chat.userViewModelSender.username );
    $("#MessageRoot").empty();
    ChatId = chat.id
    MessageId = id;
    $.ajax({
        type: "GET",
        url: "/GetMessages/"+id,
        async: false,
        success: function (result) {
            if (result) {
                Messages = result;
                var html = "";
                for (var i = 0; i < result.length; i++) {
                    var message = result[i];
                    if (message.senderUserViewModel.id === userId) {
                        html += `<li class='clearfix'>
                                <div class='message other-message float-right'>`
                        html += message.mediaUrl === null ? "" : `<img style=" max-width: 20rem;" src='/` + message.mediaUrl + `' />`
                        html += ` <div class="text-right" >`+ message.content +
                            `</div></div>
                            </li>`
                    }
                    else {
                        html += `<li class='clearfix'>
                                <div class='message other-message float-left'>`
                        html += message.mediaUrl === null ? "" : `<img style=" max-width: 20rem;" src='/` + message.mediaUrl + `' />`
                        html += ` <div class="text-left" >`+ message.content +
                            `</div></div>
                            </li>`
                    }
                }
                $("#MessageRoot").append(html);
                LastMessageId = result[result.length - 1].id;
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

function getNewMessages() {
    var model = {
        ChatId: ChatId,
        LastMessageId: LastMessageId
    }
    $.ajax({
        type: "POST",
        url: "/GetNewMessages",
        data: model,
        async: false,
        success: function (result) {
            if (result) {
                var html = "";
                for (var i = 0; i < result.length; i++) {
                    var message = result[i];
                    if (message.senderUserViewModel.id === userId) {
                        html += `<li class='clearfix'>
                                <div class='message other-message float-right'>`
                        html += message.mediaUrl === null ? "" : `<img style=" max-width: 20rem;" src='/` + message.mediaUrl + `' />`
                        html += ` <div class="text-right" >` + message.content +
                            `</div></div>
                            </li>`
                    }
                    else {
                        html += `<li class='clearfix'>
                                <div class='message other-message float-left'>`
                        html += message.mediaUrl === null ? "" : `<img style=" max-width: 20rem;" src='/` + message.mediaUrl + `' />`
                        html += ` <div class="text-left" >` + message.content +
                            `</div></div>
                            </li>`
                    }
                    Messages.push(result[i]);
                }
                $("#MessageRoot").append(html);
                LastMessageId = result[result.length - 1].id
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


function sendNewMessage() {
    var messageModel = {
        Content: $("#message").val(),
        MediaId: MediaId === 0 ? null : MediaId,
        ChatId: ChatId
    }
    $.ajax({
        type: "POST",
        url: "/SendNewMessage",
        data: messageModel,
        async: false,
        success: function (result) {
            if (result) {
                $("#message").val("")
                $("#dosya").css("display", "none")
                MediaId = 0;
                getNewMessages();
              
            }
        },
        error: function (xhr, status, p3, p4) {
            console.log(err);
        },
    });
}

function checkNewMessages() {
    var model = {
        ChatId: ChatId,
        LastMessageId: LastMessageId
    };
    $.ajax({
        type: "POST",
        url: "/checkNewMessages",
        data: model,
        async: false,
        success: function (result) {
            if (result) {
                getNewMessages();
            }

        },
        error: function (xhr, status, p3, p4) {
            console.log(err);
        },
    });
}

function UploadMedia(e) {
    var formData = new FormData();
    var elem = $(e)[0];
    var file = elem.files[0];
    formData.append("file", file);
    $.ajax({
        type: "POST",
        url: "/Media/UploadMedia",
        contentType: false,
        processData: false,
        data: formData,
        success: function (result) {
            if (result) {
                MediaId = result
                $("#dosya").css("display","inline")
            }
        },
        error: function (err) {
            console.log(err)
        }
    });
}