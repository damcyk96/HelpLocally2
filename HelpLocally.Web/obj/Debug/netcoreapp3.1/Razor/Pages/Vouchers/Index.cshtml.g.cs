#pragma checksum "/Users/trojan/Desktop/HelpLocally/HelpLocally.Web/Pages/Vouchers/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6942fd2aa3b03b36398c167aac3ecde76546e52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HelpLocally.Web.Pages.Vouchers.Pages_Vouchers_Index), @"mvc.1.0.razor-page", @"/Pages/Vouchers/Index.cshtml")]
namespace HelpLocally.Web.Pages.Vouchers
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
#line 1 "/Users/trojan/Desktop/HelpLocally/HelpLocally.Web/Pages/_ViewImports.cshtml"
using HelpLocally.Web;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6942fd2aa3b03b36398c167aac3ecde76546e52", @"/Pages/Vouchers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9129721cfa4840c7f16f3cba05845c6de96a855f", @"/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6cab3867fc16094539bd4ceae3926018f2fd44e", @"/Pages/Vouchers/_ViewImports.cshtml")]
    public class Pages_Vouchers_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "/Users/trojan/Desktop/HelpLocally/HelpLocally.Web/Pages/Vouchers/Index.cshtml"
Write(await Html.PartialAsync("_NavigationPartial", "vouchers"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n\t<thead>\r\n\t<tr>\r\n\t\t<th class=\"col\">Start amount</th>\r\n\t\t<th class=\"col\">Current amount</th>\r\n\t\t<th class=\"col\">Expiration date</th>\r\n\t</tr>\r\n\t</thead>\r\n\t<tbody>\r\n");
#nullable restore
#line 15 "/Users/trojan/Desktop/HelpLocally/HelpLocally.Web/Pages/Vouchers/Index.cshtml"
     foreach (var item in Model.Vouchers)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<tr>\r\n\t\t\t<td>");
#nullable restore
#line 18 "/Users/trojan/Desktop/HelpLocally/HelpLocally.Web/Pages/Vouchers/Index.cshtml"
           Write(item.StartAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t<td>");
#nullable restore
#line 19 "/Users/trojan/Desktop/HelpLocally/HelpLocally.Web/Pages/Vouchers/Index.cshtml"
           Write(item.CurrentAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t<td>");
#nullable restore
#line 20 "/Users/trojan/Desktop/HelpLocally/HelpLocally.Web/Pages/Vouchers/Index.cshtml"
           Write(item.ExpirationDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t</tr>\r\n");
#nullable restore
#line 22 "/Users/trojan/Desktop/HelpLocally/HelpLocally.Web/Pages/Vouchers/Index.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</tbody>\r\n\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
