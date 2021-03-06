#pragma checksum "D:\dotNet\Vidly\Vidly\Views\Customers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "495f2e4d4677b29b677e3c5a39fa602a9a7d8188"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_Index), @"mvc.1.0.view", @"/Views/Customers/Index.cshtml")]
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
#line 1 "D:\dotNet\Vidly\Vidly\Views\_ViewImports.cshtml"
using Vidly;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dotNet\Vidly\Vidly\Views\_ViewImports.cshtml"
using Vidly.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"495f2e4d4677b29b677e3c5a39fa602a9a7d8188", @"/Views/Customers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5f1cd008877cdb7a8309a52d389048c655f591a", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Vidly.Models.Customer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\dotNet\Vidly\Vidly\Views\Customers\Index.cshtml"
  
    ViewBag.Title = "Customers";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Customers</h2>\r\n");
#nullable restore
#line 12 "D:\dotNet\Vidly\Vidly\Views\Customers\Index.cshtml"
 if (!Model.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>We don\'t have any customers yet.</p>\r\n");
#nullable restore
#line 15 "D:\dotNet\Vidly\Vidly\Views\Customers\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-bordered table-hover\">\r\n        <thead>\r\n            <tr>\r\n                <th>Customer</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 25 "D:\dotNet\Vidly\Vidly\Views\Customers\Index.cshtml"
             foreach (var customer in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 28 "D:\dotNet\Vidly\Vidly\Views\Customers\Index.cshtml"
                   Write(Html.ActionLink(customer.Name, "Details", "Customers", new { id = customer.Id }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 30 "D:\dotNet\Vidly\Vidly\Views\Customers\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 33 "D:\dotNet\Vidly\Vidly\Views\Customers\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Vidly.Models.Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
