let blogId = decodeURI(location.pathname.split("/").pop());
let MediaId = 0;
$(document).ready(function () {
    GetBlogs();
})
const setupBlog = (data) => {
    const banner = document.querySelector('.banner');
    const blogTitle = document.querySelector('.title');
    const titleTag = document.querySelector('title');
    const publish = document.querySelector('.published');
    
    banner.style.backgroundImage = `url(${data.bannerImage})`;

    titleTag.innerHTML += blogTitle.innerHTML = data.title;
    publish.innerHTML += data.publishedAt;

    const article = document.querySelector('.article');
    addArticle(article, data.article);
}

const addArticle = (ele, data) => {
    data = data.split("\n").filter(item => item.length);
    // console.log(data);

    data.forEach(item => {
        // check for heading
        if(item[0] == '#'){
            let hCount = 0;
            let i = 0;
            while(item[i] == '#'){
                hCount++;
                i++;
            }
            let tag = `h${hCount}`;
            ele.innerHTML += `<${tag}>${item.slice(hCount, item.length)}</${tag}>`
        } 
        //checking for image format
        else if(item[0] == "!" && item[1] == "["){
            let seperator;

            for(let i = 0; i <= item.length; i++){
                if(item[i] == "]" && item[i + 1] == "(" && item[item.length - 1] == ")"){
                    seperator = i;
                }
            }

            let alt = item.slice(2, seperator);
            let src = item.slice(seperator + 2, item.length - 1);
            ele.innerHTML += `
            <img src="${src}" alt="${alt}" class="article-image">`;
        }

        else{
            ele.innerHTML += `<p>${item}</p>`;
        }
    })
}

function AddBlog() {
    if (MediaId !== 0) {
        BlogViewModel = {
            Header: $("#titleIn").val(),
            Content: $("#contentIn").val(),
            HeaderMediaId: MediaId,
        };
        $.ajax({
            type: "POST",
            url: "/CreateBlogPost",
            data: BlogViewModel,
            async: false,
            success: function (result) {
                if (result.isSuccess) {

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
    else {
        alert("Medya Boş Olamaz")
    }
}

function GetBlogs() {
        $.ajax({
            type: "GET",
            url: "/GetBlogPosts",
            async: false,
            success: function (result) {
                if (result) {
                    Blogs = result;
                    var html = "";
                    for (var i = 0; i < result.length; i++) {
                        var chat = result[i]
                        html += "<div class='ml-2 card col-3 col-md-6 col-lg-3 pt-3' >\
                            <img class='card-img-top' src='/"+ result[i].headerMediaUrl + "' alt='" + result[i].writer.username + "'>\
                            <div class='card-body'>\
                                <h5 class='card-title font-weight-bold'>"+ result[i].header + "</h5>\
                                <span class='d-block'><span class='font-weight-bold'>Yazar: </span>  "+ result[i].writer.username+"</span> \
                                <span class='card-text d-block'>"+ result[i].content.slice(0, 20) + "...</span>\
                                <a href='/Blog/BlogDetail?id="+ result[i].id +"' class='btn btn-primary mt-2'>Oku</a>\
                            </div>\
                        </div>"
                    }
                    $("#Blogs").append(html);
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
                MediaId = result;
                $("#dosya").css("display", "inline");

            }
        },
        error: function (err) {
            console.log(err)
        }
    });
}