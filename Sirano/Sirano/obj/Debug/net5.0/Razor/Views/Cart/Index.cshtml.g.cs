#pragma checksum "C:\Users\29\Documents\GitHub\OOAD-G5-Sirano\Sirano\Sirano\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "227b9b99cfb3d5f2fca93f51ac9f8646aea9a400"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#line 1 "C:\Users\29\Documents\GitHub\OOAD-G5-Sirano\Sirano\Sirano\Views\_ViewImports.cshtml"
using Sirano;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\29\Documents\GitHub\OOAD-G5-Sirano\Sirano\Sirano\Views\_ViewImports.cshtml"
using Sirano.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"227b9b99cfb3d5f2fca93f51ac9f8646aea9a400", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9378229da277ad5011ea4ab2220744d8c7236276", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Sirano.Models.Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Header", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Order/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\29\Documents\GitHub\OOAD-G5-Sirano\Sirano\Sirano\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Cart";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "227b9b99cfb3d5f2fca93f51ac9f8646aea9a4004235", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<style>
    .container {
        display: flex;
        flex-wrap: wrap;
        justify-content: left;
        align-items: center;
        max-width: 1150px;
        min-height: 340px;
        min-width: 1000px;
    }

    .product-card {
        width: 170px;
        height: 270px;
        justify-content: right;
        align-items: center;
        margin: 20px;
    }

    .product-image {
        max-width: 100%;
        max-height: 100%;
    }

    .button5 {
        background-color: WHITE;
        border-color: black;
        border-radius: 1px;
        color: BLACK;
        padding: 7px 70px;
        text-align: center;
        font-weight: 100;
        text-decoration: none;
        display: inline-block;
        font-size: 14px;
        margin: 2px 2px;
        cursor: pointer;
        white-space: nowrap;
    }

    .button5:disabled {
        background-color: #cccccc;
        color: #666666;
        cursor: not-allowed;
    }
</style>

<div class=");
            WriteLiteral("\"container\">\r\n");
#nullable restore
#line 54 "C:\Users\29\Documents\GitHub\OOAD-G5-Sirano\Sirano\Sirano\Views\Cart\Index.cshtml"
     foreach (var product in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"product-card\" style=\"margin-bottom:80px;\">\r\n            <div>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 1294, "\"", 1314, 1);
#nullable restore
#line 58 "C:\Users\29\Documents\GitHub\OOAD-G5-Sirano\Sirano\Sirano\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1300, product.Image, 1300, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Product Image\" class=\"product-image\">\r\n            </div>\r\n            <div style=\"text-align: center;\">\r\n                <p>");
#nullable restore
#line 61 "C:\Users\29\Documents\GitHub\OOAD-G5-Sirano\Sirano\Sirano\Views\Cart\Index.cshtml"
              Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div style=\"text-align: center;\">\r\n                <p>Price: $");
#nullable restore
#line 64 "C:\Users\29\Documents\GitHub\OOAD-G5-Sirano\Sirano\Sirano\Views\Cart\Index.cshtml"
                      Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 67 "C:\Users\29\Documents\GitHub\OOAD-G5-Sirano\Sirano\Sirano\Views\Cart\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n<div style=\"margin-top:150px;display: flex;\">\r\n    <div>\r\n        <p style=\"font-family: IBM Plex Sans; font-size: 17px; font-weight: 100; margin-top:8px; margin-left: 730px; color: rgba(20, 20, 20, 0.7);\">TOTAL: $");
#nullable restore
#line 71 "C:\Users\29\Documents\GitHub\OOAD-G5-Sirano\Sirano\Sirano\Views\Cart\Index.cshtml"
                                                                                                                                                       Write(Model.Sum(p => Convert.ToDecimal(p.Price)).ToString("F2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "227b9b99cfb3d5f2fca93f51ac9f8646aea9a4008792", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 75 "C:\Users\29\Documents\GitHub\OOAD-G5-Sirano\Sirano\Sirano\Views\Cart\Index.cshtml"
             if (Model.Any())
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <button type=\"submit\" class=\"button5\" style=\"margin-left: 15px; margin-bottom: 50px;\">CONTINUE</button>\r\n");
#nullable restore
#line 78 "C:\Users\29\Documents\GitHub\OOAD-G5-Sirano\Sirano\Sirano\Views\Cart\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <button type=\"submit\" class=\"button5\" style=\"margin-left: 15px; margin-bottom: 50px;\" disabled>CONTINUE</button>\r\n");
#nullable restore
#line 82 "C:\Users\29\Documents\GitHub\OOAD-G5-Sirano\Sirano\Sirano\Views\Cart\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Sirano.Models.Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
