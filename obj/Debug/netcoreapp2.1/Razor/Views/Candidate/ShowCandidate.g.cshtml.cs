#pragma checksum "E:\project\CustomerFocusWeb\CustomerFocusWeb\Views\Candidate\ShowCandidate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9d98227bd35cfe278d3e3ec153bce8f5419ad10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Candidate_ShowCandidate), @"mvc.1.0.view", @"/Views/Candidate/ShowCandidate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Candidate/ShowCandidate.cshtml", typeof(AspNetCore.Views_Candidate_ShowCandidate))]
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
#line 1 "E:\project\CustomerFocusWeb\CustomerFocusWeb\Views\_ViewImports.cshtml"
using CustomerFocusWeb;

#line default
#line hidden
#line 2 "E:\project\CustomerFocusWeb\CustomerFocusWeb\Views\_ViewImports.cshtml"
using CustomerFocusWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9d98227bd35cfe278d3e3ec153bce8f5419ad10", @"/Views/Candidate/ShowCandidate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3f9b62b6615e0cf08f1d2dba09115663366ba29", @"/Views/_ViewImports.cshtml")]
    public class Views_Candidate_ShowCandidate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ShowCandidateController.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\project\CustomerFocusWeb\CustomerFocusWeb\Views\Candidate\ShowCandidate.cshtml"
  
    ViewData["Title"] = "ShowCandidate";

#line default
#line hidden
            BeginContext(51, 1105, true);
            WriteLiteral(@"

<div ng-controller=""ShowCandidateController"">
    <div class=""container"">
        <h3>ข้อมูล candidate</h3>
        <br>
        <div ng-init=""init()"" class=""table-responsive"">
            <table class=""table"">
                <tr>
                    <th>Email</th>
                    <th>Fullname</th>
                    <th>Experience</th>
                    <th>Age</th>
                    <th>Computer language</th>
                    <th>Position</th>
                    <th>Location</th>
                    <th>Salary</th>
                </tr>
                <tr ng-repeat=""em in employees"">
                    <td>{{em.email}}</td>
                    <td>{{em.fullname}}</td>
                    <td>{{em.experience}}</td>
                    <td>{{em.age}}</td>
                    <td style=""text-align:center"">{{em.computer_lang}}</td>
                    <td>{{em.position}}</td>
                    <td>{{em.location}}</td>
                    <td>{{em.salary}}</td>
    ");
            WriteLiteral("            </tr>\r\n            </table>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1174, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1180, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc08967e5da841fd9ceb5baeff4541cb", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1235, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(1240, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591