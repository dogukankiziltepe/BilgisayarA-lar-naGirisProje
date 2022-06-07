#pragma checksum "/Users/dogukan/Projects/BilgisayarAglarinaGirisProje/BilgisayarAglarinaGirisProje/Views/Messaging/Chat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f82bbf34bfe6a447ffc6eb99221356f30cb8318f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Messaging_Chat), @"mvc.1.0.view", @"/Views/Messaging/Chat.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/dogukan/Projects/BilgisayarAglarinaGirisProje/BilgisayarAglarinaGirisProje/Views/_ViewImports.cshtml"
using BilgisayarAglarinaGirisProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/dogukan/Projects/BilgisayarAglarinaGirisProje/BilgisayarAglarinaGirisProje/Views/_ViewImports.cshtml"
using BilgisayarAglarinaGirisProje.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f82bbf34bfe6a447ffc6eb99221356f30cb8318f", @"/Views/Messaging/Chat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fb1c6868aadd253b150ee8ccaced53ebbd4729c", @"/Views/_ViewImports.cshtml")]
    public class Views_Messaging_Chat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Messaging.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/chat.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/dogukan/Projects/BilgisayarAglarinaGirisProje/BilgisayarAglarinaGirisProje/Views/Messaging/Chat.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row clearfix"">
        <div class=""col-lg-12"">
            <div class=""card chat-app"">
                <div id=""plist"" class=""people-list"">
                    <div class=""input-group"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text""><i onclick=""createChat()"" class=""fa fa-add""></i></span>
                        </div>
                        <input id=""getterUsername"" type=""text"" class=""form-control"" placeholder=""Eklemek için username giriniz."">
                    </div>
                    <ul id=""ChatList"" class=""list-unstyled chat-list mt-2 mb-0"">

                    </ul>
                </div>
                <div class=""chat"">
                    <div class=""chat-header clearfix"">
                        <div class=""row"">
                            <div class=""col-lg-6"">
                                <a href=""javascript:void(0);"" data-toggle=""modal"" data-target=""#view_info"">
              ");
            WriteLiteral(@"                      <img src=""https://bootdey.com/img/Content/avatar/avatar3.png"" alt=""avatar"">
                                </a>
                                <div class=""chat-about"">
                                    <h6 id=""chatUsername"" class=""m-b-0""></h6>
                                </div>
                            </div>
                            <div class=""col-lg-6 hidden-sm text-right"">
                            </div>
                        </div>
                    </div>
                    <div class=""chat-history overflow-auto"">
                        <ul id=""MessageRoot"" class=""m-b-0"">
                            
                        </ul>
                    </div>
                    <div class=""chat-message clearfix "">
                        <div class=""input-group mb-0"">
                            <div class=""input-group-prepend"">
                                <span onclick=""sendNewMessage()"" class=""input-group-text""><i class=""fa fa-send""></i></span>
          ");
            WriteLiteral(@"                  </div>
                            <input id=""message"" type=""text"" class=""form-control"" placeholder=""Enter text here..."">
                            <div class=""custom-file"">
                                <input onchange=""UploadMedia(this)"" type=""file"" class=""custom-file-input form-control-xs"" id=""inputGroupFile01"">
                                <div class=""custom-file-label"" for=""inputGroupFile01"" style=""width: 0px;""></div>
                                <div style=""display:none"" id=""dosya"">Dosya Yüklendi</div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f82bbf34bfe6a447ffc6eb99221356f30cb8318f7008", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f82bbf34bfe6a447ffc6eb99221356f30cb8318f8031", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591