#pragma checksum "C:\Users\tgcey\OneDrive\Masaüstü\restaurant\restaurant\Areas\Musteri\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2d2c734076bd310cbf6a86b4755d600dde9062f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Musteri_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Musteri/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\tgcey\OneDrive\Masaüstü\restaurant\restaurant\Areas\Musteri\Views\_ViewImports.cshtml"
using restaurant;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tgcey\OneDrive\Masaüstü\restaurant\restaurant\Areas\Musteri\Views\_ViewImports.cshtml"
using restaurant.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2d2c734076bd310cbf6a86b4755d600dde9062f", @"/Areas/Musteri/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33a8794206979814e79cd63a88fb176e06f85510", @"/Areas/Musteri/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Musteri_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<restaurant.Models.Menu>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Musteri", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Menu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn1 flex-c-m size1 txt3 trans-0-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\tgcey\OneDrive\Masaüstü\restaurant\restaurant\Areas\Musteri\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/MasterPage.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""section-slide"">
    <div class=""wrap-slick1"">
        <div class=""slick1"">
            <div class=""item-slick1 item1-slick1"" style=""background-image: url(/WebSite/images/slide1-01.jpg);"">
                <div class=""wrap-content-slide1 sizefull flex-col-c-m p-l-15 p-r-15 p-t-150 p-b-170"">
                    <span class=""caption1-slide1 txt1 t-center animated visible-false m-b-15"" data-appear=""fadeInDown"">
                        Pita Restaurant'a
                    </span>

                    <h2 class=""caption2-slide1 tit1 t-center animated visible-false m-b-37"" data-appear=""fadeInUp"">
                        Hoş Geldİnİz
                    </h2>

                    <div class=""wrap-btn-slide1 animated visible-false"" data-appear=""zoomIn"">
                        <!-- Button1 -->
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2d2c734076bd310cbf6a86b4755d600dde9062f5661", async() => {
                WriteLiteral("\r\n                            Menüler\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
            </div>

            <div class=""item-slick1 item2-slick1"" style=""background-image: url(/WebSite/images/master-slides-02.jpg);"">
                <div class=""wrap-content-slide1 sizefull flex-col-c-m p-l-15 p-r-15 p-t-150 p-b-170"">
                    <span class=""caption1-slide1 txt1 t-center animated visible-false m-b-15"" data-appear=""rollIn"">
                        Pita Restaurant'a
                    </span>

                    <h2 class=""caption2-slide1 tit1 t-center animated visible-false m-b-37"" data-appear=""lightSpeedIn"">
                        Hoş Geldİnİz
                    </h2>

                    <div class=""wrap-btn-slide1 animated visible-false"" data-appear=""slideInUp"">
                        <!-- Button1 -->
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2d2c734076bd310cbf6a86b4755d600dde9062f8224", async() => {
                WriteLiteral("\r\n                            Menüler\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
            </div>

            <div class=""item-slick1 item3-slick1"" style=""background-image: url(/WebSite/images/master-slides-01.jpg);"">
                <div class=""wrap-content-slide1 sizefull flex-col-c-m p-l-15 p-r-15 p-t-150 p-b-170"">
                    <span class=""caption1-slide1 txt1 t-center animated visible-false m-b-15"" data-appear=""rotateInDownLeft"">
                        Pita Restaurant'a
                    </span>

                    <h2 class=""caption2-slide1 tit1 t-center animated visible-false m-b-37"" data-appear=""rotateInUpRight"">
                        Hoş Geldİnİz
                    </h2>

                    <div class=""wrap-btn-slide1 animated visible-false"" data-appear=""rotateIn"">
                        <!-- Button1 -->
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2d2c734076bd310cbf6a86b4755d600dde9062f10799", async() => {
                WriteLiteral("\r\n                            Menüler\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n        <div class=\"wrap-slick1-dots\"></div>\r\n    </div>\r\n</section>\r\n<div class=\"section-gallery p-t-20\">\r\n    ");
#nullable restore
#line 73 "C:\Users\tgcey\OneDrive\Masaüstü\restaurant\restaurant\Areas\Musteri\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("CategoryList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <!--CategoryList class çağırmak için bu işlemi yaptık-->\r\n</div>\r\n\r\n<section class=\"section-lunch bgwhite\">\r\n\r\n    <div class=\"container\">\r\n        <div class=\"row p-t-10\">\r\n");
#nullable restore
#line 81 "C:\Users\tgcey\OneDrive\Masaüstü\restaurant\restaurant\Areas\Musteri\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-md-12 col-lg-6"">
                    <!-- Block3 -->
                    <div class=""blo3 flex-w flex-col-l-sm m-b-30"">
                        <div class=""pic-blo3 size20 bo-rad-10 hov-img-zoom m-r-28"">
                            <a><img");
            BeginWriteAttribute("src", " src=\"", 3964, "\"", 3981, 1);
#nullable restore
#line 87 "C:\Users\tgcey\OneDrive\Masaüstü\restaurant\restaurant\Areas\Musteri\Views\Home\Index.cshtml"
WriteAttributeValue("", 3970, item.Image, 3970, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"IMG-MENU\"></a>\r\n                        </div>\r\n\r\n                        <div class=\"text-blo3 size21 flex-col-l-m\">\r\n                            <a class=\"txt21 m-b-3\">\r\n                                ");
#nullable restore
#line 92 "C:\Users\tgcey\OneDrive\Masaüstü\restaurant\restaurant\Areas\Musteri\Views\Home\Index.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n\r\n                            <span class=\"txt23\">\r\n                                ");
#nullable restore
#line 96 "C:\Users\tgcey\OneDrive\Masaüstü\restaurant\restaurant\Areas\Musteri\Views\Home\Index.cshtml"
                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </span>\r\n\r\n                            <span class=\"txt22 m-t-20\">\r\n                                ");
#nullable restore
#line 100 "C:\Users\tgcey\OneDrive\Masaüstü\restaurant\restaurant\Areas\Musteri\Views\Home\Index.cshtml"
                           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (₺)\r\n                            </span>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 105 "C:\Users\tgcey\OneDrive\Masaüstü\restaurant\restaurant\Areas\Musteri\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<restaurant.Models.Menu>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
