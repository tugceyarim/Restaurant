#pragma checksum "C:\Users\tgcey\OneDrive\Masaüstü\restaurant\restaurant\Areas\Musteri\Views\Home\Galeri.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f57c6fc24011ff031a9ba53154f9463ab15d14aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Musteri_Views_Home_Galeri), @"mvc.1.0.view", @"/Areas/Musteri/Views/Home/Galeri.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f57c6fc24011ff031a9ba53154f9463ab15d14aa", @"/Areas/Musteri/Views/Home/Galeri.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33a8794206979814e79cd63a88fb176e06f85510", @"/Areas/Musteri/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Musteri_Views_Home_Galeri : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<restaurant.Models.Galeri>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\tgcey\OneDrive\Masaüstü\restaurant\restaurant\Areas\Musteri\Views\Home\Galeri.cshtml"
  
    ViewData["Title"] = "Galeri";
    Layout = "~/Views/Shared/MasterPage.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Title Page -->
<section class=""bg-title-page flex-c-m p-t-160 p-b-80 p-l-15 p-r-15"" style=""background-image: url(/WebSite/images/bg-title-page-02.jpg);"">
    <h2 class=""tit6 t-center"">
        Galerİ
    </h2>
</section>


<!-- Gallery -->
<div class=""section-gallery p-t-118 p-b-100"">

    <div class=""wrap-gallery isotope-grid flex-w p-l-25 p-r-25"">
        <!-- - -->
");
#nullable restore
#line 20 "C:\Users\tgcey\OneDrive\Masaüstü\restaurant\restaurant\Areas\Musteri\Views\Home\Galeri.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"item-gallery isotope-item bo-rad-10 hov-img-zoom events guests\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 688, "\"", 705, 1);
#nullable restore
#line 23 "C:\Users\tgcey\OneDrive\Masaüstü\restaurant\restaurant\Areas\Musteri\Views\Home\Galeri.cshtml"
WriteAttributeValue("", 694, item.Image, 694, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"IMG-GALLERY\" height=\"300\">\r\n            </div>\r\n");
#nullable restore
#line 25 "C:\Users\tgcey\OneDrive\Masaüstü\restaurant\restaurant\Areas\Musteri\Views\Home\Galeri.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<restaurant.Models.Galeri>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591