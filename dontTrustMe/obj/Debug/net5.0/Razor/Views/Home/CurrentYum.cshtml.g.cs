#pragma checksum "C:\Users\ASUS\YandexDisk\dontTrustMe\dontTrustMe\Views\Home\CurrentYum.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eee8a28bad500df0b26d897476973ffc9ebe8b12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CurrentYum), @"mvc.1.0.view", @"/Views/Home/CurrentYum.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eee8a28bad500df0b26d897476973ffc9ebe8b12", @"/Views/Home/CurrentYum.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a8ebe78407fa94e4310a91d84714e0f48fb46d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CurrentYum : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dontTrustMe.Models.Yummy>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ASUS\YandexDisk\dontTrustMe\dontTrustMe\Views\Home\CurrentYum.cshtml"
  
    Layout = "~/Views/_Yummie.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <p>");
#nullable restore
#line 6 "C:\Users\ASUS\YandexDisk\dontTrustMe\dontTrustMe\Views\Home\CurrentYum.cshtml"
  Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 119, "\"", 135, 1);
#nullable restore
#line 7 "C:\Users\ASUS\YandexDisk\dontTrustMe\dontTrustMe\Views\Home\CurrentYum.cshtml"
WriteAttributeValue("", 125, Model.Img, 125, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n    <p>");
#nullable restore
#line 8 "C:\Users\ASUS\YandexDisk\dontTrustMe\dontTrustMe\Views\Home\CurrentYum.cshtml"
  Write(Model.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 9 "C:\Users\ASUS\YandexDisk\dontTrustMe\dontTrustMe\Views\Home\CurrentYum.cshtml"
  Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" руб.</p>
</div>
<div class=""form_block"" id=""output"">
    <form class=""forma"" id=""benderform"" action=""https://localhost:5001/api/Comment"" >
        <p class=""form_txt""><b>Оставьте свой комментарий:</b></p>
        <input class=""form_input"" type=""text"" maxlength=""100"" name=""nick"" placeholder=""введите никнейм"">
        <textarea class=""area"" maxlength=""1000"" name=""comm"" placeholder=""Оставьте комментарий""></textarea><br>
        <input type=""submit"" value="" Отправить"">
    </form>
    <script>
        document.getElementById('benderform').addEventListener('submit', submitForm);
        let k = document.getElementById('benderform');
        function submitForm(event) {

            event.preventDefault();

            let obj = {
                nick: k.children.item(1).value,
                text: k.children.item(2).value,
                dt: new Date()
            };

            var json = JSON.stringify(obj);

            var xhr = new XMLHttpRequest();
            xhr.open(""POST"", ev");
            WriteLiteral("ent.target.action, true)\r\n            xhr.setRequestHeader(\'Content-type\', \'application/json; charset=utf-8\');\r\n            xhr.send(json);\r\n        }\r\n    </script>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dontTrustMe.Models.Yummy> Html { get; private set; }
    }
}
#pragma warning restore 1591
