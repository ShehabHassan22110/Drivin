#pragma checksum "F:\Drivin\Drivin\Views\Courses\WebsiteIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1361f9f3c67f58c85bb10c9d735f8105364d7622"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_WebsiteIndex), @"mvc.1.0.view", @"/Views/Courses/WebsiteIndex.cshtml")]
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
#line 1 "F:\Drivin\Drivin\Views\_ViewImports.cshtml"
using Drivin.Language;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Drivin\Drivin\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Drivin\Drivin\Views\_ViewImports.cshtml"
using Drivin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Drivin\Drivin\Views\_ViewImports.cshtml"
using Drivin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Drivin\Drivin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1361f9f3c67f58c85bb10c9d735f8105364d7622", @"/Views/Courses/WebsiteIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f9e336df595ed35f71955806dbbe035568c9698", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Courses_WebsiteIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Drivin.BL.ViewModels.CoursesVM>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Drivin\Drivin\Views\Courses\WebsiteIndex.cshtml"
  
    ViewData["Title"] = "WebsiteIndex";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n <!-- Page Header Start -->\r\n    <div class=\"container-fluid page-header py-6 my-6 mt-0 wow fadeIn\" data-wow-delay=\"0.1s\">\r\n        <div class=\"container text-center\">\r\n        <h1 class=\"display-4 text-white animated slideInDown mb-4\">");
#nullable restore
#line 11 "F:\Drivin\Drivin\Views\Courses\WebsiteIndex.cshtml"
                                                              Write(SharedLocalizer["Courses"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <nav aria-label=\"breadcrumb animated slideInDown\">\r\n                <ol class=\"breadcrumb justify-content-center mb-0\">\r\n                <li class=\"breadcrumb-item\"><a class=\"text-white\" href=\"#\">");
#nullable restore
#line 14 "F:\Drivin\Drivin\Views\Courses\WebsiteIndex.cshtml"
                                                                      Write(SharedLocalizer["Home"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                <li class=\"breadcrumb-item\"><a class=\"text-white\" href=\"#\">");
#nullable restore
#line 15 "F:\Drivin\Drivin\Views\Courses\WebsiteIndex.cshtml"
                                                                      Write(SharedLocalizer["Pages"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                <li class=\"breadcrumb-item text-primary active\" aria-current=\"page\">");
#nullable restore
#line 16 "F:\Drivin\Drivin\Views\Courses\WebsiteIndex.cshtml"
                                                                               Write(SharedLocalizer["Courses"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                </ol>
            </nav>
        </div>
    </div>
    <!-- Page Header End -->


    <!-- Courses Start -->
    <div class=""container-xxl py-6"">
        <div class=""container"">
            <div class=""text-center mx-auto mb-5 wow fadeInUp"" data-wow-delay=""0.1s"" style=""max-width: 500px;"">
            <h6 class=""text-primary text-uppercase mb-2"">");
#nullable restore
#line 28 "F:\Drivin\Drivin\Views\Courses\WebsiteIndex.cshtml"
                                                    Write(SharedLocalizer["Tranding Courses"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            <h1 class=\"display-6 mb-4\">");
#nullable restore
#line 29 "F:\Drivin\Drivin\Views\Courses\WebsiteIndex.cshtml"
                                  Write(SharedLocalizer["Our Courses Upskill You With Driving Training"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            </div>\r\n            <div class=\"row g-4 justify-content-center\">\r\n");
#nullable restore
#line 32 "F:\Drivin\Drivin\Views\Courses\WebsiteIndex.cshtml"
          foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-lg-4 col-md-6 wow fadeInUp"" data-wow-delay=""0.2s"">
                    <div class=""courses-item d-flex flex-column bg-light overflow-hidden h-100"">
                        <div class=""text-center p-4 pt-0"">
                            <div class=""d-inline-block bg-primary text-white fs-5 py-1 px-4 mb-4"">$");
#nullable restore
#line 37 "F:\Drivin\Drivin\Views\Courses\WebsiteIndex.cshtml"
                                                                                              Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <h5 class=\"mb-3\">");
#nullable restore
#line 38 "F:\Drivin\Drivin\Views\Courses\WebsiteIndex.cshtml"
                                        Write(item.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p>");
#nullable restore
#line 39 "F:\Drivin\Drivin\Views\Courses\WebsiteIndex.cshtml"
                          Write(item.Caption);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <ol class=\"breadcrumb justify-content-center mb-0\">\r\n                                <li class=\"breadcrumb-item small\"><i class=\"fa fa-signal text-primary me-2\"></i>");
#nullable restore
#line 41 "F:\Drivin\Drivin\Views\Courses\WebsiteIndex.cshtml"
                                                                                                           Write(SharedLocalizer["Beginner"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                <li class=\"breadcrumb-item small\"><i class=\"fa fa-calendar-alt text-primary me-2\"></i>3 ");
#nullable restore
#line 42 "F:\Drivin\Drivin\Views\Courses\WebsiteIndex.cshtml"
                                                                                                                   Write(SharedLocalizer["Week"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            </ol>\r\n                        </div>\r\n                        <div class=\"position-relative mt-auto\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1361f9f3c67f58c85bb10c9d735f8105364d76229813", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2589, "~/Imgs/", 2589, 7, true);
#nullable restore
#line 46 "F:\Drivin\Drivin\Views\Courses\WebsiteIndex.cshtml"
AddHtmlAttributeValue("", 2596, item.PhotoName, 2596, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <div class=\"courses-overlay\">\r\n                                <a class=\"btn btn-outline-primary border-2\"");
            BeginWriteAttribute("href", " href=\"", 2756, "\"", 2763, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 48 "F:\Drivin\Drivin\Views\Courses\WebsiteIndex.cshtml"
                                                                               Write(SharedLocalizer["Read More"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 53 "F:\Drivin\Drivin\Views\Courses\WebsiteIndex.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("           \r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- Courses End -->\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringLocalizer<SharedResource> SharedLocalizer { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Drivin.BL.ViewModels.CoursesVM>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
