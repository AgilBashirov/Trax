#pragma checksum "C:\Users\Agil\source\repos\Trax\Trax\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3d74f865d4884d6e7b4b3545edd72140c22266a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "C:\Users\Agil\source\repos\Trax\Trax\Views\_ViewImports.cshtml"
using Trax;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Agil\source\repos\Trax\Trax\Views\_ViewImports.cshtml"
using Trax.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Agil\source\repos\Trax\Trax\Views\_ViewImports.cshtml"
using Trax.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3d74f865d4884d6e7b4b3545edd72140c22266a", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a4fd58cb63a520ea84e070f49c38857e01eac12", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VmBlog>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_BreadCrumPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Latest News"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button gradient-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Agil\source\repos\Trax\Trax\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    VmBreadCrum vmBreadCrum = new VmBreadCrum() { Desc = "Blogs", Page = "Blog" };

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--Page Header-->
<section id=""main-banner-page"" class=""position-relative page-header blog-header parallax section-nav-smooth"">
    <div class=""overlay overlay-dark opacity-7 z-index-1""></div>
    <div class=""container"">
        <div class=""row"">

            <div class=""col-lg-8 offset-lg-2"">
                <div class=""page-titles whitecolor text-center padding_top padding_bottom"">
");
#nullable restore
#line 15 "C:\Users\Agil\source\repos\Trax\Trax\Views\Blog\Index.cshtml"
                     foreach (var item in Model.Universals.Where(u => u.Section == "BlogInHeader"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h2 class=\"font-xlight\">");
#nullable restore
#line 17 "C:\Users\Agil\source\repos\Trax\Trax\Views\Blog\Index.cshtml"
                                           Write(item.UpTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <h2 class=\"font-bold\">");
#nullable restore
#line 18 "C:\Users\Agil\source\repos\Trax\Trax\Views\Blog\Index.cshtml"
                                         Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <h2 class=\"font-xlight\">");
#nullable restore
#line 19 "C:\Users\Agil\source\repos\Trax\Trax\Views\Blog\Index.cshtml"
                                           Write(item.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <h3 class=\"font-light pt-2\">");
#nullable restore
#line 20 "C:\Users\Agil\source\repos\Trax\Trax\Views\Blog\Index.cshtml"
                                               Write(item.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 21 "C:\Users\Agil\source\repos\Trax\Trax\Views\Blog\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a3d74f865d4884d6e7b4b3545edd72140c22266a8201", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 25 "C:\Users\Agil\source\repos\Trax\Trax\Views\Blog\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = vmBreadCrum;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div>\r\n</section>\r\n<!--Page Header ends -->\r\n\r\n<!-- Our Blogs -->\r\n<section id=\"our-blog\" class=\"bglight padding\">\r\n    <div class=\"container\">\r\n        <div id=\"blog-measonry\" class=\"cbp\">\r\n");
#nullable restore
#line 35 "C:\Users\Agil\source\repos\Trax\Trax\Views\Blog\Index.cshtml"
             foreach (var blog in Model.Blogs)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"cbp-item\">\r\n                    <div class=\"news_item shadow text-center text-md-left\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3d74f865d4884d6e7b4b3545edd72140c22266a10366", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a3d74f865d4884d6e7b4b3545edd72140c22266a10650", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1607, "~/Uploads/Images/", 1607, 17, true);
#nullable restore
#line 40 "C:\Users\Agil\source\repos\Trax\Trax\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 1624, blog.Image, 1624, 11, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "C:\Users\Agil\source\repos\Trax\Trax\Views\Blog\Index.cshtml"
                                                                                      WriteLiteral(blog.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                        <div class=\"news_desc\">\r\n                            <h3 class=\"text-capitalize font-normal darkcolor\"><a href=\"blog-detail.html\">");
#nullable restore
#line 43 "C:\Users\Agil\source\repos\Trax\Trax\Views\Blog\Index.cshtml"
                                                                                                    Write(blog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                            <ul class=\"meta-tags top20 bottom20\">\r\n                                <li><a href=\"#.\"><i class=\"fas fa-calendar-alt\"></i>");
#nullable restore
#line 45 "C:\Users\Agil\source\repos\Trax\Trax\Views\Blog\Index.cshtml"
                                                                               Write(blog.AddedDate.ToString("MMMM dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                <li><a href=\"#.\"> <i class=\"far fa-user\"></i> ");
#nullable restore
#line 46 "C:\Users\Agil\source\repos\Trax\Trax\Views\Blog\Index.cshtml"
                                                                         Write(blog.User.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></li>\r\n                                <li><a href=\"#.\"><i class=\"far fa-comment-dots\"></i>");
#nullable restore
#line 47 "C:\Users\Agil\source\repos\Trax\Trax\Views\Blog\Index.cshtml"
                                                                               Write(blog.Comments.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></li>\r\n                            </ul>\r\n                            <p class=\"bottom35\">");
#nullable restore
#line 49 "C:\Users\Agil\source\repos\Trax\Trax\Views\Blog\Index.cshtml"
                                            Write(blog.Content.Length>100? blog.Content.Substring(0,150):blog.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3d74f865d4884d6e7b4b3545edd72140c22266a16694", async() => {
                WriteLiteral("Read more");
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
#nullable restore
#line 50 "C:\Users\Agil\source\repos\Trax\Trax\Views\Blog\Index.cshtml"
                                                                            WriteLiteral(blog.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 54 "C:\Users\Agil\source\repos\Trax\Trax\Views\Blog\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <div class=""row"">
            <div class=""col-sm-12"">
                <!--Pagination-->
                <ul class=""pagination justify-content-center top40"">
                    <li class=""page-item""><a class=""page-link disabled"" href=""#.""><i class=""fa fa-angle-left""></i></a></li>
                    <li class=""page-item active""><a class=""page-link"" href=""#."">1</a></li>
                    <li class=""page-item""><a class=""page-link"" href=""#."">2</a></li>
                    <li class=""page-item""><a class=""page-link"" href=""#."">3</a></li>
                    <li class=""page-item""><a class=""page-link"" href=""#.""><i class=""fa fa-angle-right""></i></a></li>
                </ul>
            </div>
        </div>
    </div>
</section>
<!--Our Blogs Ends-->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VmBlog> Html { get; private set; }
    }
}
#pragma warning restore 1591
