#pragma checksum "/Users/trojan/Desktop/HelpLocally/HelpLocally.Web/Pages/_NavigationPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef62d382f75381268f820b686baf6ed9ddf84d26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HelpLocally.Web.Pages.Pages__NavigationPartial), @"mvc.1.0.view", @"/Pages/_NavigationPartial.cshtml")]
namespace HelpLocally.Web.Pages
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
#nullable restore
#line 1 "/Users/trojan/Desktop/HelpLocally/HelpLocally.Web/Pages/_NavigationPartial.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/trojan/Desktop/HelpLocally/HelpLocally.Web/Pages/_NavigationPartial.cshtml"
using HelpLocally.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef62d382f75381268f820b686baf6ed9ddf84d26", @"/Pages/_NavigationPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9129721cfa4840c7f16f3cba05845c6de96a855f", @"/Pages/_ViewImports.cshtml")]
    public class Pages__NavigationPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "/Users/trojan/Desktop/HelpLocally/HelpLocally.Web/Pages/_NavigationPartial.cshtml"
 if (User.Claims.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<ul class=\"nav nav-tabs\">\r\n\t\t<li class=\"nav-item\">\r\n\t\t\t<a");
            BeginWriteAttribute("class", " class=\"", 161, "\"", 227, 3);
            WriteAttributeValue("", 169, "nav-link", 169, 8, true);
            WriteAttributeValue(" ", 177, "btn", 178, 4, true);
#nullable restore
#line 9 "/Users/trojan/Desktop/HelpLocally/HelpLocally.Web/Pages/_NavigationPartial.cshtml"
WriteAttributeValue(" ", 181, Model == "users" ? "active" : string.Empty, 182, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"/Users\">Users</a>\r\n\t\t</li>\r\n\t\t<li class=\"nav-item\">\r\n\t\t\t<a");
            BeginWriteAttribute("class", " class=\"", 293, "\"", 364, 3);
            WriteAttributeValue("", 301, "nav-link", 301, 8, true);
            WriteAttributeValue(" ", 309, "btn", 310, 4, true);
#nullable restore
#line 12 "/Users/trojan/Desktop/HelpLocally/HelpLocally.Web/Pages/_NavigationPartial.cshtml"
WriteAttributeValue(" ", 313, Model == "offerTypes" ? "active" : string.Empty, 314, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"/OfferTypes\">Offer types</a>\r\n\t\t</li>\r\n\t\t<li class=\"nav-item\">\r\n\t\t\t<a");
            BeginWriteAttribute("class", " class=\"", 441, "\"", 508, 3);
            WriteAttributeValue("", 449, "nav-link", 449, 8, true);
            WriteAttributeValue(" ", 457, "btn", 458, 4, true);
#nullable restore
#line 15 "/Users/trojan/Desktop/HelpLocally/HelpLocally.Web/Pages/_NavigationPartial.cshtml"
WriteAttributeValue(" ", 461, Model == "offers" ? "active" : string.Empty, 462, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"/Offers\">Offers</a>\r\n\t\t</li>\r\n\t\t<li class=\"nav-item\">\r\n\t\t\t<a");
            BeginWriteAttribute("class", " class=\"", 576, "\"", 646, 3);
            WriteAttributeValue("", 584, "nav-link", 584, 8, true);
            WriteAttributeValue(" ", 592, "btn", 593, 4, true);
#nullable restore
#line 18 "/Users/trojan/Desktop/HelpLocally/HelpLocally.Web/Pages/_NavigationPartial.cshtml"
WriteAttributeValue(" ", 596, Model == "companies" ? "active" : string.Empty, 597, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"/Companies\">Companies</a>\r\n\t\t</li>\r\n\t\t<li class=\"nav-item\">\r\n\t\t\t<a");
            BeginWriteAttribute("class", " class=\"", 720, "\"", 789, 3);
            WriteAttributeValue("", 728, "nav-link", 728, 8, true);
            WriteAttributeValue(" ", 736, "btn", 737, 4, true);
#nullable restore
#line 21 "/Users/trojan/Desktop/HelpLocally/HelpLocally.Web/Pages/_NavigationPartial.cshtml"
WriteAttributeValue(" ", 740, Model == "vouchers" ? "active" : string.Empty, 741, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"/Vouchers\">Vouchers</a>\r\n\t\t</li>\r\n\t</ul>\r\n");
#nullable restore
#line 24 "/Users/trojan/Desktop/HelpLocally/HelpLocally.Web/Pages/_NavigationPartial.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
