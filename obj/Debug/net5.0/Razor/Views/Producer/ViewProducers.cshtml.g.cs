#pragma checksum "D:\Yazılım\FilmReview\FilmReview\Views\Producer\ViewProducers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be004f7e1d28ab9ed7feba41928c4cee7234d131"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producer_ViewProducers), @"mvc.1.0.view", @"/Views/Producer/ViewProducers.cshtml")]
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
#line 1 "D:\Yazılım\FilmReview\FilmReview\Views\_ViewImports.cshtml"
using FilmReview;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Yazılım\FilmReview\FilmReview\Views\_ViewImports.cshtml"
using FilmReview.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be004f7e1d28ab9ed7feba41928c4cee7234d131", @"/Views/Producer/ViewProducers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"daf7c05c53ac7c3b2e6baf70fa9a692d20963a19", @"/Views/_ViewImports.cshtml")]
    public class Views_Producer_ViewProducers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProducerTable>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<title>View Producers </title>\r\n\r\n<h2>Producers</h2>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be004f7e1d28ab9ed7feba41928c4cee7234d1313564", async() => {
                WriteLiteral(@"
    <div>
        <p>Filter by name</p>
        <input type=""text"" name=""Name"" id=""Name"">
        <button type=""submit"" value=""Search"" class=""btn btn-outline-dark"">Search</button>
    </div>

    <table class=""table"">
        <thead class=""thead-dark"">
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">Name</th>
                <th scope=""col"">Adress</th>
                <th scope=""col"">Details</th>
            </tr>
        </thead>
");
#nullable restore
#line 21 "D:\Yazılım\FilmReview\FilmReview\Views\Producer\ViewProducers.cshtml"
         foreach (var producer in ViewBag.ProducerList)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <th scope=\"col\">");
#nullable restore
#line 24 "D:\Yazılım\FilmReview\FilmReview\Views\Producer\ViewProducers.cshtml"
                           Write(producer.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 25 "D:\Yazılım\FilmReview\FilmReview\Views\Producer\ViewProducers.cshtml"
               Write(producer.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "D:\Yazılım\FilmReview\FilmReview\Views\Producer\ViewProducers.cshtml"
               Write(producer.Adress);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "D:\Yazılım\FilmReview\FilmReview\Views\Producer\ViewProducers.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id = producer.Id }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 29 "D:\Yazılım\FilmReview\FilmReview\Views\Producer\ViewProducers.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProducerTable> Html { get; private set; }
    }
}
#pragma warning restore 1591