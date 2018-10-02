#pragma checksum "/Users/marc/Desktop/COMS3002/PGASystem/PGASystem/Views/Application/ReviewedApplications.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5c3e39a0bfac181b9030388e9ec351604e59540"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Application_ReviewedApplications), @"mvc.1.0.view", @"/Views/Application/ReviewedApplications.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Application/ReviewedApplications.cshtml", typeof(AspNetCore.Views_Application_ReviewedApplications))]
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
#line 1 "/Users/marc/Desktop/COMS3002/PGASystem/PGASystem/Views/_ViewImports.cshtml"
using PGASystem;

#line default
#line hidden
#line 2 "/Users/marc/Desktop/COMS3002/PGASystem/PGASystem/Views/_ViewImports.cshtml"
using PGASystem.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5c3e39a0bfac181b9030388e9ec351604e59540", @"/Views/Application/ReviewedApplications.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c88f98961700d698e8377b759d0c87927fdfec4b", @"/Views/_ViewImports.cshtml")]
    public class Views_Application_ReviewedApplications : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplicationsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Application", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewFiles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 746, true);
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <h3 class=""page-header"">Applications To Review </h3>
            <div id="""">
                <table class=""table table-striped table-hover"" id="""">
                    <thead>
                        <tr>
                            <th>Application ID</th>
                            <th>Applicant </th>
                            <th>Programme</th>
                            <th>Status</th>
                            <th>Supervisor Decision</th>
                            <th>PGC Decision</th>
                            <th>Details</th>

                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 22 "/Users/marc/Desktop/COMS3002/PGASystem/PGASystem/Views/Application/ReviewedApplications.cshtml"
                         foreach (var application in Model.Applications)
                        {

#line default
#line hidden
            BeginContext(877, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(940, 14, false);
#line 25 "/Users/marc/Desktop/COMS3002/PGASystem/PGASystem/Views/Application/ReviewedApplications.cshtml"
                           Write(application.Id);

#line default
#line hidden
            EndContext();
            BeginContext(954, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(994, 21, false);
#line 26 "/Users/marc/Desktop/COMS3002/PGASystem/PGASystem/Views/Application/ReviewedApplications.cshtml"
                           Write(application.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1015, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1017, 20, false);
#line 26 "/Users/marc/Desktop/COMS3002/PGASystem/PGASystem/Views/Application/ReviewedApplications.cshtml"
                                                  Write(application.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1037, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1077, 35, false);
#line 27 "/Users/marc/Desktop/COMS3002/PGASystem/PGASystem/Views/Application/ReviewedApplications.cshtml"
                           Write(application.Programme.ProgrammeName);

#line default
#line hidden
            EndContext();
            BeginContext(1112, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1152, 29, false);
#line 28 "/Users/marc/Desktop/COMS3002/PGASystem/PGASystem/Views/Application/ReviewedApplications.cshtml"
                           Write(application.ApplicationStatus);

#line default
#line hidden
            EndContext();
            BeginContext(1181, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1221, 30, false);
#line 29 "/Users/marc/Desktop/COMS3002/PGASystem/PGASystem/Views/Application/ReviewedApplications.cshtml"
                           Write(application.SupervisorApproval);

#line default
#line hidden
            EndContext();
            BeginContext(1251, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1291, 23, false);
#line 30 "/Users/marc/Desktop/COMS3002/PGASystem/PGASystem/Views/Application/ReviewedApplications.cshtml"
                           Write(application.PGCApproval);

#line default
#line hidden
            EndContext();
            BeginContext(1314, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1353, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0381ec3993a4f2680ca977753929507", async() => {
                BeginContext(1450, 4, true);
                WriteLiteral("View");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-applicationId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 31 "/Users/marc/Desktop/COMS3002/PGASystem/PGASystem/Views/Application/ReviewedApplications.cshtml"
                                                                                                    WriteLiteral(application.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["applicationId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-applicationId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["applicationId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1458, 38, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n");
            EndContext();
#line 33 "/Users/marc/Desktop/COMS3002/PGASystem/PGASystem/Views/Application/ReviewedApplications.cshtml"

                        }

#line default
#line hidden
            BeginContext(1525, 114, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplicationsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
