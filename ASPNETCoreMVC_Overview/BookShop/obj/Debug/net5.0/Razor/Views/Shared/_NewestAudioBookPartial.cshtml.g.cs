#pragma checksum "C:\Aktueller Kurs\ASPNETCore_MVC\ASPNETCoreMVC_Overview\BookShop\Views\Shared\_NewestAudioBookPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49c269f76957f4bb682d14e07a2656da6c028806"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__NewestAudioBookPartial), @"mvc.1.0.view", @"/Views/Shared/_NewestAudioBookPartial.cshtml")]
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
#line 1 "C:\Aktueller Kurs\ASPNETCore_MVC\ASPNETCoreMVC_Overview\BookShop\Views\_ViewImports.cshtml"
using BookShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Aktueller Kurs\ASPNETCore_MVC\ASPNETCoreMVC_Overview\BookShop\Views\_ViewImports.cshtml"
using BookShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49c269f76957f4bb682d14e07a2656da6c028806", @"/Views/Shared/_NewestAudioBookPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ee4735df80bb67d1ce7d40fc94d37240032cc50", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__NewestAudioBookPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookShop.ViewModels.BooksVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Aktueller Kurs\ASPNETCore_MVC\ASPNETCoreMVC_Overview\BookShop\Views\Shared\_NewestAudioBookPartial.cshtml"
 if (Model.NewestPublishedAudioBook.ID > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Newest Audio Book</p>\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <p>");
#nullable restore
#line 8 "C:\Aktueller Kurs\ASPNETCore_MVC\ASPNETCoreMVC_Overview\BookShop\Views\Shared\_NewestAudioBookPartial.cshtml"
          Write(Model.NewestPublishedAudioBook.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>");
#nullable restore
#line 9 "C:\Aktueller Kurs\ASPNETCore_MVC\ASPNETCoreMVC_Overview\BookShop\Views\Shared\_NewestAudioBookPartial.cshtml"
          Write(Model.NewestPublishedAudioBook.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>");
#nullable restore
#line 10 "C:\Aktueller Kurs\ASPNETCore_MVC\ASPNETCoreMVC_Overview\BookShop\Views\Shared\_NewestAudioBookPartial.cshtml"
          Write(Model.NewestPublishedAudioBook.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>");
#nullable restore
#line 11 "C:\Aktueller Kurs\ASPNETCore_MVC\ASPNETCoreMVC_Overview\BookShop\Views\Shared\_NewestAudioBookPartial.cshtml"
          Write(Model.NewestPublishedAudioBook.Published);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 14 "C:\Aktueller Kurs\ASPNETCore_MVC\ASPNETCoreMVC_Overview\BookShop\Views\Shared\_NewestAudioBookPartial.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookShop.ViewModels.BooksVM> Html { get; private set; }
    }
}
#pragma warning restore 1591