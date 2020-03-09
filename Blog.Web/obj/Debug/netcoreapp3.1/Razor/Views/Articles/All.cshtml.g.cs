#pragma checksum "D:\MyCode\TestableCode\Blog.Web\Views\Articles\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19733bc7a790ad4232b4b860701829b769f4b116"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Articles_All), @"mvc.1.0.view", @"/Views/Articles/All.cshtml")]
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
#line 1 "D:\MyCode\TestableCode\Blog.Web\Views\_ViewImports.cshtml"
using Blog.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MyCode\TestableCode\Blog.Web\Views\_ViewImports.cshtml"
using Blog.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\MyCode\TestableCode\Blog.Web\Views\_ViewImports.cshtml"
using Blog.Controllers.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\MyCode\TestableCode\Blog.Web\Views\_ViewImports.cshtml"
using Blog.Controllers.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\MyCode\TestableCode\Blog.Web\Views\_ViewImports.cshtml"
using Blog.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\MyCode\TestableCode\Blog.Web\Views\_ViewImports.cshtml"
using Blog.Services.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\MyCode\TestableCode\Blog.Web\Views\_ViewImports.cshtml"
using Blog.Web.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19733bc7a790ad4232b4b860701829b769f4b116", @"/Views/Articles/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f0bd4438eae936cf6b45508e7a2a384383a3aea", @"/Views/_ViewImports.cshtml")]
    public class Views_Articles_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ArticleListingViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ArticleListingPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\MyCode\TestableCode\Blog.Web\Views\Articles\All.cshtml"
  
    ViewData.SetTitle("All Articles");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\MyCode\TestableCode\Blog.Web\Views\Articles\All.cshtml"
 if (Model.Articles.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">");
#nullable restore
#line 10 "D:\MyCode\TestableCode\Blog.Web\Views\Articles\All.cshtml"
                         Write(ViewData.GetTitle());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "19733bc7a790ad4232b4b860701829b769f4b1164909", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 11 "D:\MyCode\TestableCode\Blog.Web\Views\Articles\All.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.Articles;

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
            WriteLiteral("\r\n\r\n        <div class=\"container margin-top-20\">\r\n            <div class=\"row\">\r\n                <div class=\"col-2\">\r\n");
#nullable restore
#line 16 "D:\MyCode\TestableCode\Blog.Web\Views\Articles\All.cshtml"
                     if (Model.Page > 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a class=\"disabled\"");
            BeginWriteAttribute("href", " href=\"", 502, "\"", 545, 2);
            WriteAttributeValue("", 509, "/Articles/All?page=", 509, 19, true);
#nullable restore
#line 18 "D:\MyCode\TestableCode\Blog.Web\Views\Articles\All.cshtml"
WriteAttributeValue("", 528, Model.Page - 1, 528, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">&lt;&lt; Prev</a>\r\n");
#nullable restore
#line 19 "D:\MyCode\TestableCode\Blog.Web\Views\Articles\All.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"col-md-8\"></div>\r\n                <div class=\"col-2\">\r\n");
#nullable restore
#line 23 "D:\MyCode\TestableCode\Blog.Web\Views\Articles\All.cshtml"
                     if (Model.Total - ServicesConstants.ArticlesPerPage * Model.Page > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a class=\"pull-right\"");
            BeginWriteAttribute("href", " href=\"", 856, "\"", 899, 2);
            WriteAttributeValue("", 863, "/Articles/All?page=", 863, 19, true);
#nullable restore
#line 25 "D:\MyCode\TestableCode\Blog.Web\Views\Articles\All.cshtml"
WriteAttributeValue("", 882, Model.Page + 1, 882, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Next &gt;&gt;</a>\r\n");
#nullable restore
#line 26 "D:\MyCode\TestableCode\Blog.Web\Views\Articles\All.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 31 "D:\MyCode\TestableCode\Blog.Web\Views\Articles\All.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2 class=\"text-center margin-top-20\">No articles available here!</h2>\r\n");
#nullable restore
#line 35 "D:\MyCode\TestableCode\Blog.Web\Views\Articles\All.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ArticleListingViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
