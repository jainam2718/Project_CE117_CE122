#pragma checksum "C:\Users\ASUS\Documents\WDDN\ExamPortal\first\WDDN-Project-master\WddnProject\Areas\Identity\Pages\_AuthLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05e82a20b9b39a03eef5e4a741ab85df4bcdb298"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages__AuthLayout), @"mvc.1.0.view", @"/Areas/Identity/Pages/_AuthLayout.cshtml")]
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
#line 1 "C:\Users\ASUS\Documents\WDDN\ExamPortal\first\WDDN-Project-master\WddnProject\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Documents\WDDN\ExamPortal\first\WDDN-Project-master\WddnProject\Areas\Identity\Pages\_ViewImports.cshtml"
using WDDNProject.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Documents\WDDN\ExamPortal\first\WDDN-Project-master\WddnProject\Areas\Identity\Pages\_ViewImports.cshtml"
using WDDNProject.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ASUS\Documents\WDDN\ExamPortal\first\WDDN-Project-master\WddnProject\Areas\Identity\Pages\_ViewImports.cshtml"
using WDDNProject.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05e82a20b9b39a03eef5e4a741ab85df4bcdb298", @"/Areas/Identity/Pages/_AuthLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b52eff59df91abfb91222625b2f91a36f983e8c", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    public class Areas_Identity_Pages__AuthLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ASUS\Documents\WDDN\ExamPortal\first\WDDN-Project-master\WddnProject\Areas\Identity\Pages\_AuthLayout.cshtml"
   Layout = "/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"" style=""position:center"">
    <div class=""col-md-6 offset-md-3"">
        <div class=""card login-logout-tab"">
            <div class=""card-header"">
                <ul class=""nav nav-tabs card-header-tabs"">
                    <li class=""nav-item"">
                        <a class=""nav-link"" href='/Identity/Account/Login'>Sign In</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href='/Identity/Account/Register'>Sign Up</a>
                    </li>
                </ul>
            </div>
            <div class=""card-content"">
                <div class=""col-md-12"">
                    ");
#nullable restore
#line 18 "C:\Users\ASUS\Documents\WDDN\ExamPortal\first\WDDN-Project-master\WddnProject\Areas\Identity\Pages\_AuthLayout.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
#nullable restore
#line 26 "C:\Users\ASUS\Documents\WDDN\ExamPortal\first\WDDN-Project-master\WddnProject\Areas\Identity\Pages\_AuthLayout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <script>
        $(function () {
            var current = location.pathname;
            $('.card-header-tabs li a').each(function () {
                var $this = $(this);
                if (current.indexOf($this.attr('href')) !== -1) {
                    $this.addClass('active');
                }
            })
        })
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591