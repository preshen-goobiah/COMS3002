#pragma checksum "/Users/Preshen/Desktop/COMS3002/PGASystem/PGASystem/Views/Auth/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbaacd06eac897ed96fb795905e277b8f4ca69a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_Index), @"mvc.1.0.view", @"/Views/Auth/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Auth/Index.cshtml", typeof(AspNetCore.Views_Auth_Index))]
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
#line 1 "/Users/Preshen/Desktop/COMS3002/PGASystem/PGASystem/Views/_ViewImports.cshtml"
using PGASystem;

#line default
#line hidden
#line 2 "/Users/Preshen/Desktop/COMS3002/PGASystem/PGASystem/Views/_ViewImports.cshtml"
using PGASystem.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbaacd06eac897ed96fb795905e277b8f4ca69a6", @"/Views/Auth/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c88f98961700d698e8377b759d0c87927fdfec4b", @"/Views/_ViewImports.cshtml")]
    public class Views_Auth_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Auth", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 82, true);
            WriteLiteral("<div class=\"main well\">\r\n    <div class=\"left\" >\r\n        <h1>Login</h1>\r\n        ");
            EndContext();
            BeginContext(82, 430, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "588cf2697d624197b8bb37bf940557d3", async() => {
                BeginContext(143, 362, true);
                WriteLiteral(@"
           
            <input id=""email"" name=""email"" type=""text"" placeholder=""Email"" style=""background-color: #ffffff""  value=""Ekow.Otoo.Wits@gmail.com""/>
            <input id=""password"" name=""password"" type=""password"" placeholder=""Password"" style=""background-color: #ffffff"" value=""otoo123"" />
            <input type=""submit"" value=""Login"" />
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(512, 2530, true);
            WriteLiteral(@"

    </div>

</div>

<style>
    body {
        width: 100%;
        background-color: #ffffff;
        /*background:-webkit-linear-gradient(#82B4D5,#fff);*/
        font-family: 'Trebuchet MS';
        /*color:#fff;*/
        height: 100vh;
    }

    .main {
       
        /*border:1px solid #fff;*/
        margin: 0 auto;
    }

        .main div {
            display: inline-block;
            border: none;
        }

        .main .left {
         
          
        }

    .left h1 {
        text-align: center;
        /*padding-left:120px;*/
        padding-bottom: 20px;
        margin-bottom: 0;
    }

    .left p {
        margin-top: 0;
        text-align: center;
        color: grey;
    }

    .left form {
        text-align: center;
    }

        .left form input {
            text-align: center;
            width: 70%;
            height: 35px;
            margin-bottom: 10px;
            border: none;
            border: 1px solid #F8F8F");
            WriteLiteral(@"8;
            background-color: #F8F8F8;
            border-radius: 25px;
        }

            .left form input:focus {
                outline: none;
            }

    ::-webkit-input-placeholder {
        color: grey;
        letter-spacing: 1px;
    }

    .left form input[type=""submit""] {
        background-color: #337ab7;
        color: #fff;
        font-weight: bold;
    }

    .left p.forgot {
        color: grey;
        font-size: 12px;
        padding-top: 140px;
    }

    .left p.or {
        color: grey;
        font-size: 15px;
        border: 1px solid #f8f8f8;
        width: 40px;
        font-weight: 200;
        height: 30px;
        padding-top: 10px;
        background-color: #fff;
        border-radius: 50%;
        position: absolute;
        top: 42%;
        left: 94%;
        z-index: 10;
        /*text-align:center;*/
    }
    /*.left .form{
  border:1px solid;
}*/
    .main .right {
        /*height:100%;*/
        width: 50%;
  ");
            WriteLiteral(@"      float: left;
        height: 100%;
        margin-left: -5px;
        padding-right: 5px;
        background-image: url('https://s4.postimg.org/k8u6q3g8d/baloon.jpg');
        background-color: #fff;
        background-size: cover;
        text-align: center;
    }

    .right h1 {
        padding-top: 100px;
        margin-bottom: 10px;
    }

    .right {
        color: #fff;
    }

        .right p {
            margin: 0;
        }

</style>

");
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
