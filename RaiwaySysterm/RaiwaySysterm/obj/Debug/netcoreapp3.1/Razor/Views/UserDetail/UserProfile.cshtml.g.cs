#pragma checksum "D:\sem3\thi\RaiwaySysterm\RaiwaySysterm\Views\UserDetail\UserProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26af6d7e8ac17c7c124d241f8e4d84e343b61146"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserDetail_UserProfile), @"mvc.1.0.view", @"/Views/UserDetail/UserProfile.cshtml")]
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
#line 1 "D:\sem3\thi\RaiwaySysterm\RaiwaySysterm\Views\_ViewImports.cshtml"
using RaiwaySysterm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\sem3\thi\RaiwaySysterm\RaiwaySysterm\Views\_ViewImports.cshtml"
using RaiwaySysterm.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26af6d7e8ac17c7c124d241f8e4d84e343b61146", @"/Views/UserDetail/UserProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb812565c2420b34ad12033cbc25387c6eeee185", @"/Views/_ViewImports.cshtml")]
    public class Views_UserDetail_UserProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RaiwaySysterm.Models.UserDetail>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\sem3\thi\RaiwaySysterm\RaiwaySysterm\Views\UserDetail\UserProfile.cshtml"
  
    ViewData["Title"] = "UserProfile";
    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />

<div id=""layoutAuthentication"">
    <div id=""layoutAuthentication_content"">
        <main>
            <div class=""container animate-box"">
                <div class=""row justify-content-center"">
                    <div class=""col-lg-7"">
                        <div class=""card shadow-lg border-0 rounded-lg mt-5"">
                            <div class=""card-header""><h3 class=""text-center font-weight-light my-4"">Profile User</h3></div>
                            <div class=""card-body"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26af6d7e8ac17c7c124d241f8e4d84e343b611464102", async() => {
                WriteLiteral(@"
                                    <table class=""table-bordered"">
                                        <dl class=""dl-horizontal"">
                                            <dt>
                                                <label>Full Name</label>
                                            </dt>
                                            <dd>
                                                ");
#nullable restore
#line 26 "D:\sem3\thi\RaiwaySysterm\RaiwaySysterm\Views\UserDetail\UserProfile.cshtml"
                                           Write(Html.DisplayFor(model => model.FullName));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                            </dd>
                                            <dt>
                                                <label>Age</label>
                                            </dt>
                                            <dd>
                                                ");
#nullable restore
#line 32 "D:\sem3\thi\RaiwaySysterm\RaiwaySysterm\Views\UserDetail\UserProfile.cshtml"
                                           Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                            </dd>
                                            <dt>
                                                <label>Gender</label>
                                            </dt>
                                            <dd>
                                                ");
#nullable restore
#line 38 "D:\sem3\thi\RaiwaySysterm\RaiwaySysterm\Views\UserDetail\UserProfile.cshtml"
                                           Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            </dd>\r\n                                            \r\n                                            <div>\r\n                                                ");
#nullable restore
#line 42 "D:\sem3\thi\RaiwaySysterm\RaiwaySysterm\Views\UserDetail\UserProfile.cshtml"
                                           Write(Html.ActionLink("Edit", "UpdateUser", "UserDetail"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            </div>\r\n                                        </dl>\r\n                                    </table>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </main>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RaiwaySysterm.Models.UserDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
