#pragma checksum "/Users/dogukan/Projects/BilgisayarAglarinaGirisProje/BilgisayarAglarinaGirisProje/Views/Login/SignUp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fadc824fbcfec5859f0b64fb9188b336800e2e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_SignUp), @"mvc.1.0.view", @"/Views/Login/SignUp.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fadc824fbcfec5859f0b64fb9188b336800e2e2", @"/Views/Login/SignUp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fb1c6868aadd253b150ee8ccaced53ebbd4729c", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_SignUp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/SignUp.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/dogukan/Projects/BilgisayarAglarinaGirisProje/BilgisayarAglarinaGirisProje/Views/Login/SignUp.cshtml"
  
    ViewData["Title"] = "Sign Up";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"signup-box\">\n    <h1>Sign Up</h1>\n    <h4>Ücretsiz Kaydolun!</h4>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fadc824fbcfec5859f0b64fb9188b336800e2e24096", async() => {
                WriteLiteral("\n        <label>Ad</label>\n        <input id=\"SignInAd\" type=\"text\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 196, "\"", 210, 0);
                EndWriteAttribute();
                WriteLiteral(">\n        <label>Soyad</label>\n        <input id=\"SignInSoyad\" type=\"text\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 285, "\"", 299, 0);
                EndWriteAttribute();
                WriteLiteral(">\n        <label>Email</label>\n        <input id=\"SignInEmail\" type=\"text\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 374, "\"", 388, 0);
                EndWriteAttribute();
                WriteLiteral(">\n        <label>Username</label>\n        <input id=\"SignInUsername\" type=\"text\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 469, "\"", 483, 0);
                EndWriteAttribute();
                WriteLiteral(">\n        <label>Password</label>\n        <input id=\"SignInPassword\" type=\"text\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 564, "\"", 578, 0);
                EndWriteAttribute();
                WriteLiteral(">\n        <label>Confirm Password</label>\n        <input id=\"SignInPasswordConf\" type=\"text\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 671, "\"", 685, 0);
                EndWriteAttribute();
                WriteLiteral(">\n        <div id=\"conferr\" style=\"display:none\">Şifreler uyuşmuyor!</div>\n        <input onclick=\"SignUp()\" type=\"button\" value=\"Kaydet\">\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    <p> Sign Up butonuna tıkladığında koşullarımızı kabul etmiş olursun.</p>\n</div>\n<p class=\"para-2\">Mevcut hesabın var mı? <a href=\"Login\"> Login Here</a></p>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fadc824fbcfec5859f0b64fb9188b336800e2e27100", async() => {
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