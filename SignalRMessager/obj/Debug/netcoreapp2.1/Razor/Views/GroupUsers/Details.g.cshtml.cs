#pragma checksum "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\GroupUsers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "543a0cfd6f61de576cacc7496b85d1628e999015"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GroupUsers_Details), @"mvc.1.0.view", @"/Views/GroupUsers/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/GroupUsers/Details.cshtml", typeof(AspNetCore.Views_GroupUsers_Details))]
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
#line 1 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\_ViewImports.cshtml"
using SignalRMessager;

#line default
#line hidden
#line 2 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\_ViewImports.cshtml"
using SignalRMessager.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"543a0cfd6f61de576cacc7496b85d1628e999015", @"/Views/GroupUsers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b8c5d45f8d6d2a56ad9d8659220d689c01adff2", @"/Views/_ViewImports.cshtml")]
    public class Views_GroupUsers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SignalRMessager.Models.GroupUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\GroupUsers\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(133, 123, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>GroupUser</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(257, 41, false);
#line 15 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\GroupUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Group));

#line default
#line hidden
            EndContext();
            BeginContext(298, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(342, 45, false);
#line 18 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\GroupUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Group.GroupId));

#line default
#line hidden
            EndContext();
            BeginContext(387, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(431, 40, false);
#line 21 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\GroupUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.User));

#line default
#line hidden
            EndContext();
            BeginContext(471, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(515, 39, false);
#line 24 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\GroupUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.User.Id));

#line default
#line hidden
            EndContext();
            BeginContext(554, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(598, 42, false);
#line 27 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\GroupUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Active));

#line default
#line hidden
            EndContext();
            BeginContext(640, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(684, 38, false);
#line 30 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\GroupUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Active));

#line default
#line hidden
            EndContext();
            BeginContext(722, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(766, 38, false);
#line 33 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\GroupUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DM));

#line default
#line hidden
            EndContext();
            BeginContext(804, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(848, 34, false);
#line 36 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\GroupUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.DM));

#line default
#line hidden
            EndContext();
            BeginContext(882, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(930, 68, false);
#line 41 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\GroupUsers\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(998, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1006, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c22ecc08af67457794b4d4c4e1424d32", async() => {
                BeginContext(1028, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1044, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SignalRMessager.Models.GroupUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
