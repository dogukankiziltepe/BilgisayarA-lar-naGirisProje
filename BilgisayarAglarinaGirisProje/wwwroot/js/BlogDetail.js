var Blog = {

};

$(document).ready(function () {
    var id = qstring('id');
    getPost(id);
})

function qstring(name) {
    name = name.replace(/[\[]/, "\\[").replace(/[\]]/, "\\]");
    var regex = new RegExp("[\\?&]" + name + "=([^&#]*)"),
        results = regex.exec(location.search);
    return results === null ? "" : decodeURIComponent(results[1].replace(/\+/g, " "));
}

function getPost(id) {
    $.ajax({
        type: "GET",
        url: "/GetBlogPost/" + id,
        async: false,
        success: function (result) {
            if (result) {
                Blog = result;
                var html = "";
                html += `<div class="p-4" id="blogDetail">
            <img class="img-fluid" src="/`+ result.headerMediaUrl + `" style="
    image-orientation: inherit;">
            <h3 class="mt-3">`+ result.header + `</h3>
            <div>
                <span>Yazar: <span class="font-weight-bold">`+ result.writer.username + `</span></span>
                <div style="">
                    <p class="" style="
    word-wrap: normal;
    text-align: left;
">`+ result.content+`</p>
                </div>
            </div>
        </div>`
                $("#blogDetail").append(html);
            }
            else {
                alert();
            }
        }
    });
}