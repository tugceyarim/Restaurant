#pragma checksum "C:\Users\tgcey\OneDrive\Masaüstü\restaurant\restaurant\Areas\Musteri\Views\Home\Menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f19e3f303047b2b69109291d548dc8fb3813e654"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Musteri_Views_Home_Menu), @"mvc.1.0.view", @"/Areas/Musteri/Views/Home/Menu.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f19e3f303047b2b69109291d548dc8fb3813e654", @"/Areas/Musteri/Views/Home/Menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33a8794206979814e79cd63a88fb176e06f85510", @"/Areas/Musteri/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Musteri_Views_Home_Menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<restaurant.Models.Menu>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\tgcey\OneDrive\Masaüstü\restaurant\restaurant\Areas\Musteri\Views\Home\Menu.cshtml"
  
    ViewData["Title"] = "Menu";
    Layout = "~/Views/Shared/MasterPage.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Title Page -->
<section class=""bg-title-page flex-c-m p-t-160 p-b-80 p-l-15 p-r-15"" style=""background-image: url(/WebSite/images/bg-title-page-01.jpg);"">
	<h2 class=""tit6 t-center"">
		Menü Lİstesİ
	</h2>
</section>
<div class=""section-gallery p-t-20"">
    ");
#nullable restore
#line 14 "C:\Users\tgcey\OneDrive\Masaüstü\restaurant\restaurant\Areas\Musteri\Views\Home\Menu.cshtml"
Write(await Component.InvokeAsync("CategoryList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <!--CategoryList class çağırmak için bu işlemi yaptık-->\r\n</div>\r\n\r\n<section class=\"section-lunch bgwhite\">\r\n\r\n    <div class=\"container\">\r\n        <div class=\"row p-t-10\">\r\n");
#nullable restore
#line 22 "C:\Users\tgcey\OneDrive\Masaüstü\restaurant\restaurant\Areas\Musteri\Views\Home\Menu.cshtml"
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
            BeginWriteAttribute("src", " src=\"", 960, "\"", 977, 1);
#nullable restore
#line 28 "C:\Users\tgcey\OneDrive\Masaüstü\restaurant\restaurant\Areas\Musteri\Views\Home\Menu.cshtml"
WriteAttributeValue("", 966, item.Image, 966, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"IMG-MENU\"></a>\r\n                        </div>\r\n\r\n                        <div class=\"text-blo3 size21 flex-col-l-m\">\r\n                            <a class=\"txt21 m-b-3\">\r\n                                ");
#nullable restore
#line 33 "C:\Users\tgcey\OneDrive\Masaüstü\restaurant\restaurant\Areas\Musteri\Views\Home\Menu.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n\r\n                            <span class=\"txt23\">\r\n                                ");
#nullable restore
#line 37 "C:\Users\tgcey\OneDrive\Masaüstü\restaurant\restaurant\Areas\Musteri\Views\Home\Menu.cshtml"
                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </span>\r\n\r\n                            <span class=\"txt22 m-t-20\">\r\n                                ");
#nullable restore
#line 41 "C:\Users\tgcey\OneDrive\Masaüstü\restaurant\restaurant\Areas\Musteri\Views\Home\Menu.cshtml"
                           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (₺)\r\n                            </span>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 46 "C:\Users\tgcey\OneDrive\Masaüstü\restaurant\restaurant\Areas\Musteri\Views\Home\Menu.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
