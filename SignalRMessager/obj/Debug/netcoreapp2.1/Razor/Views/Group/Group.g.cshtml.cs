#pragma checksum "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\Group\Group.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d061b0469b9d2baf34afe9bf9f667607a8ffb451"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Group_Group), @"mvc.1.0.view", @"/Views/Group/Group.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Group/Group.cshtml", typeof(AspNetCore.Views_Group_Group))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d061b0469b9d2baf34afe9bf9f667607a8ffb451", @"/Views/Group/Group.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b8c5d45f8d6d2a56ad9d8659220d689c01adff2", @"/Views/_ViewImports.cshtml")]
    public class Views_Group_Group : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SignalRMessager.Models.GroupView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/groupA.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "GroupUsers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("userId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("userName"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/signalr/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/connectE.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/groupA.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\Group\Group.cshtml"
  
    ViewData["Title"] = "Group";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(131, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(133, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7dc34dc35b2a4d0e8c31f85e84c659d1", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(182, 10, true);
            WriteLiteral("\r\n\r\n<h2>\r\n");
            EndContext();
#line 11 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\Group\Group.cshtml"
     if (Model.DM)
    {
        

#line default
#line hidden
            BeginContext(228, 45, false);
#line 13 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\Group\Group.cshtml"
   Write(Html.DisplayFor(Model => Model.OtherUserName));

#line default
#line hidden
            EndContext();
#line 13 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\Group\Group.cshtml"
                                                      ;
    }
    else if(!Model.DM)
    {
        

#line default
#line hidden
            BeginContext(323, 41, false);
#line 17 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\Group\Group.cshtml"
   Write(Html.DisplayFor(Model => Model.GroupName));

#line default
#line hidden
            EndContext();
#line 17 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\Group\Group.cshtml"
                                                  ;
    }

#line default
#line hidden
            BeginContext(374, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
            BeginContext(383, 3330, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ab5921c467e43979880273f2d9ba5c4", async() => {
                BeginContext(389, 371, true);
                WriteLiteral(@"
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <hr />
            </div>
        </div>
        <div class=""container"">
            <div class=""col-6"" align=""center"">&nbsp;</div>
            <div class=""col-6"">
                <ul class=""col-xs-6 col-lg-4 col-xs-push-1 text-left"" id=""extMessagesList"">
");
                EndContext();
#line 32 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\Group\Group.cshtml"
                     foreach (var item in Model.Messages)
                    {
                        if (item.UserId != Model.CurrentUser.Id)
                        {

#line default
#line hidden
                BeginContext(935, 32, true);
                WriteLiteral("                            <li>");
                EndContext();
                BeginContext(968, 39, false);
#line 36 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\Group\Group.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Body));

#line default
#line hidden
                EndContext();
                BeginContext(1007, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 37 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\Group\Group.cshtml"
                        }
                        else
                        {

#line default
#line hidden
                BeginContext(1098, 45, true);
                WriteLiteral("                            <li><br /></li>\r\n");
                EndContext();
#line 41 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\Group\Group.cshtml"
                        }
                    }

#line default
#line hidden
                BeginContext(1193, 117, true);
                WriteLiteral("                </ul>\r\n                <ul class=\"col-xs-6 col-lg-4 col-xs-push-1 text-right\" id=\"intMessagesList\">\r\n");
                EndContext();
#line 45 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\Group\Group.cshtml"
                     foreach (var item in Model.Messages)
                    {
                        if (item.UserId == Model.CurrentUser.Id)
                        {

#line default
#line hidden
                BeginContext(1485, 32, true);
                WriteLiteral("                            <li>");
                EndContext();
                BeginContext(1518, 39, false);
#line 49 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\Group\Group.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Body));

#line default
#line hidden
                EndContext();
                BeginContext(1557, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 50 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\Group\Group.cshtml"
                        }
                        else
                        {

#line default
#line hidden
                BeginContext(1648, 45, true);
                WriteLiteral("                            <li><br /></li>\r\n");
                EndContext();
#line 54 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\Group\Group.cshtml"
                        }
                    }

#line default
#line hidden
                BeginContext(1743, 348, true);
                WriteLiteral(@"                </ul>
                <hr class=""col-xs-12""/>
            </div>
            <div class=""row"">&nbsp;</div>
            <div class=""sidenav col-sm-6"">
                <div></div>
                <ul>
                    <li></li>
                    <li></li>
                    <li></li>
                    <li>&emsp;<u>");
                EndContext();
                BeginContext(2091, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc3714d0bb0e45128ba33b2ce6949333", async() => {
                    BeginContext(2145, 7, true);
                    WriteLiteral("Details");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 66 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\Group\Group.cshtml"
                                                           WriteLiteral(Model.GroupId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2156, 44, true);
                WriteLiteral("</u></li>\r\n                    <li>&emsp;<u>");
                EndContext();
                BeginContext(2200, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0613245327e04e75afd614d4421f3f83", async() => {
                    BeginContext(2251, 4, true);
                    WriteLiteral("Edit");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 67 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\Group\Group.cshtml"
                                                        WriteLiteral(Model.GroupId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2259, 11, true);
                WriteLiteral("</u></li>\r\n");
                EndContext();
#line 68 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\Group\Group.cshtml"
                     if (!Model.DM)
                    {

#line default
#line hidden
                BeginContext(2330, 37, true);
                WriteLiteral("                        <li>&emsp;<u>");
                EndContext();
                BeginContext(2367, 123, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04b5e7eeb4334a1695176d8c906b0614", async() => {
                    BeginContext(2472, 14, true);
                    WriteLiteral("Manage Members");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 70 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\Group\Group.cshtml"
                                                                                         WriteLiteral(Model.GroupId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 70 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\Group\Group.cshtml"
                                                                                                                       WriteLiteral(Model.DM);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["dm"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-dm", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["dm"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2490, 11, true);
                WriteLiteral("</u></li>\r\n");
                EndContext();
#line 71 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\Group\Group.cshtml"
                    }

#line default
#line hidden
                BeginContext(2524, 20, true);
                WriteLiteral("                    ");
                EndContext();
#line 72 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\Group\Group.cshtml"
                     foreach (var user in Model.Users)
                    {
                        if (user.Active == true)
                        {

#line default
#line hidden
                BeginContext(2678, 3, true);
                WriteLiteral("<li");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 2681, "\"", 2694, 1);
#line 75 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\Group\Group.cshtml"
WriteAttributeValue("", 2686, user.Id, 2686, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2695, 39, true);
                WriteLiteral("><span class=\"dot\" id=\"online\"></span> ");
                EndContext();
                BeginContext(2735, 43, false);
#line 75 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\Group\Group.cshtml"
                                                                            Write(Html.DisplayFor(modeluser => user.UserName));

#line default
#line hidden
                EndContext();
                BeginContext(2778, 5, true);
                WriteLiteral("</li>");
                EndContext();
#line 75 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\Group\Group.cshtml"
                                                                                                                                  }
                        else if(user.Active == false)
                        {

#line default
#line hidden
                BeginContext(2866, 3, true);
                WriteLiteral("<li");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 2869, "\"", 2882, 1);
#line 77 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\Group\Group.cshtml"
WriteAttributeValue("", 2874, user.Id, 2874, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2883, 40, true);
                WriteLiteral("><span class=\"dot\" id=\"offline\"></span> ");
                EndContext();
                BeginContext(2924, 43, false);
#line 77 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\Group\Group.cshtml"
                                                                             Write(Html.DisplayFor(modeluser => user.UserName));

#line default
#line hidden
                EndContext();
                BeginContext(2967, 5, true);
                WriteLiteral("</li>");
                EndContext();
#line 77 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\Group\Group.cshtml"
                                                                                                                                   }

                    }

#line default
#line hidden
                BeginContext(3000, 173, true);
                WriteLiteral("                </ul>\r\n            </div>\r\n            <div class=\"navbar navbar-default navbar-fixed-bottom\">\r\n                <div class=\"container\">\r\n                    ");
                EndContext();
                BeginContext(3173, 459, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e1e1da8516b40dbb7c37bd635c27415", async() => {
                    BeginContext(3198, 26, true);
                    WriteLiteral("\r\n                        ");
                    EndContext();
                    BeginContext(3224, 67, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "79301344a48946c7913fb9ed7cc10f9c", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 85 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\Group\Group.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.CurrentUser.Id);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_6.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(3291, 26, true);
                    WriteLiteral("\r\n                        ");
                    EndContext();
                    BeginContext(3317, 75, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "45dd9b2300694ab3ad63a95cd9085819", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 86 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\Group\Group.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.CurrentUser.UserName);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_6.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(3392, 233, true);
                    WriteLiteral("\r\n                        <br />\r\n                        <input type=\"text\" id=\"messageInput\" required=\"required\"/>\r\n                        <input type=\"submit\" onclick=\"sendMessage();\" value=\"Send Message\" />\r\n                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3632, 74, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3713, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3715, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0561e89cc3424ccc9c47e03d925458be", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3763, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3765, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d487ef7a8db341ef99dd3ae12c48ac5a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3805, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3807, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae699a5586614e788066216aceffbfae", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3845, 28, true);
            WriteLiteral("\r\n<script>\r\n    const gId = ");
            EndContext();
            BeginContext(3874, 13, false);
#line 100 "C:\Users\callumm2\Desktop\gitstuff\SignalRMessager\Views\Group\Group.cshtml"
           Write(Model.GroupId);

#line default
#line hidden
            EndContext();
            BeginContext(3887, 192, true);
            WriteLiteral(";\r\n    window.onload = function () {\r\n        scroll(0);\r\n        setTimeout(function () { userOnline() }, 200)\r\n    };\r\n    window.onbeforeunload = function () { userOffline() };\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SignalRMessager.Models.GroupView> Html { get; private set; }
    }
}
#pragma warning restore 1591
