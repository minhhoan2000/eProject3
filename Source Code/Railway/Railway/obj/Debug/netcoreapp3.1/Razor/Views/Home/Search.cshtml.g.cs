#pragma checksum "D:\eProject3\Source Code\Railway\Railway\Views\Home\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3eb57316fcd130c0c3d2da745825fe3496985e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Search), @"mvc.1.0.view", @"/Views/Home/Search.cshtml")]
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
#line 1 "D:\eProject3\Source Code\Railway\Railway\Views\_ViewImports.cshtml"
using Railway;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\eProject3\Source Code\Railway\Railway\Views\_ViewImports.cshtml"
using Railway.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3eb57316fcd130c0c3d2da745825fe3496985e2", @"/Views/Home/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50c70203ba9ba02a9bceefd764ce9a20be4f821d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Railway.Models.Station>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "D:\eProject3\Source Code\Railway\Railway\Views\Home\Search.cshtml"
  
    ViewData["Title"] = "Search Policy";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 7 "D:\eProject3\Source Code\Railway\Railway\Views\Home\Search.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
<div style=""border-style: solid;
        border-color: blue;
    "">
    <table class=""table"" style=""color:red;"">
        <thead>
            <tr>
                <th>
                    Train Name
                </th>
                <th>
                    ");
#nullable restore
#line 18 "D:\eProject3\Source Code\Railway\Railway\Views\Home\Search.cshtml"
               Write(Html.DisplayNameFor(model => model.FromWhere));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 21 "D:\eProject3\Source Code\Railway\Railway\Views\Home\Search.cshtml"
               Write(Html.DisplayNameFor(model => model.ToWhere));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 24 "D:\eProject3\Source Code\Railway\Railway\Views\Home\Search.cshtml"
               Write(Html.DisplayNameFor(model => model.TimeStart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 27 "D:\eProject3\Source Code\Railway\Railway\Views\Home\Search.cshtml"
               Write(Html.DisplayNameFor(model => model.StationName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 32 "D:\eProject3\Source Code\Railway\Railway\Views\Home\Search.cshtml"
             foreach (var item in ViewBag.trains)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                       ");
#nullable restore
#line 36 "D:\eProject3\Source Code\Railway\Railway\Views\Home\Search.cshtml"
                  Write(item.TrainName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 39 "D:\eProject3\Source Code\Railway\Railway\Views\Home\Search.cshtml"
                   Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral(" => item.FromWhere\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 42 "D:\eProject3\Source Code\Railway\Railway\Views\Home\Search.cshtml"
                   Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral(" => item.ToWhere\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 45 "D:\eProject3\Source Code\Railway\Railway\Views\Home\Search.cshtml"
                   Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral(" => item.TimeStart\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 48 "D:\eProject3\Source Code\Railway\Railway\Views\Home\Search.cshtml"
                   Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral(" => item.StationName\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 52 "D:\eProject3\Source Code\Railway\Railway\Views\Home\Search.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Railway.Models.Station>> Html { get; private set; }
    }
}
#pragma warning restore 1591
