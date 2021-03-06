#pragma checksum "D:\Yazılım\FilmReview\FilmReview\Views\Movie\ViewMovies.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afa156cbaaa70187cda87f09d8209641aaf8d757"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_ViewMovies), @"mvc.1.0.view", @"/Views/Movie/ViewMovies.cshtml")]
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
#nullable restore
#line 2 "D:\Yazılım\FilmReview\FilmReview\Views\Movie\ViewMovies.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afa156cbaaa70187cda87f09d8209641aaf8d757", @"/Views/Movie/ViewMovies.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"daf7c05c53ac7c3b2e6baf70fa9a692d20963a19", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_ViewMovies : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieTable>
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
            WriteLiteral("<title>View Movies </title>\r\n\r\n<h2>Movies</h2>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afa156cbaaa70187cda87f09d8209641aaf8d7573702", async() => {
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
                <th scope=""col"">Genre</th>
                <th scope=""col"">Language</th>
                <th scope=""col"">Comment</th>
");
#nullable restore
#line 22 "D:\Yazılım\FilmReview\FilmReview\Views\Movie\ViewMovies.cshtml"
                 if (HttpContextAccessor.HttpContext.Session.GetInt32("isAdmin") == 1)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <th scope=\"col\">Active</th>\r\n                    <th scope=\"col\">Change Status</th>\r\n");
#nullable restore
#line 26 "D:\Yazılım\FilmReview\FilmReview\Views\Movie\ViewMovies.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tr>\r\n            </thead>\r\n");
#nullable restore
#line 29 "D:\Yazılım\FilmReview\FilmReview\Views\Movie\ViewMovies.cshtml"
             foreach (var movie in ViewBag.movieList)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <tr>\r\n        <th scope=\"col\">");
#nullable restore
#line 32 "D:\Yazılım\FilmReview\FilmReview\Views\Movie\ViewMovies.cshtml"
                   Write(movie.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n        <td>");
#nullable restore
#line 33 "D:\Yazılım\FilmReview\FilmReview\Views\Movie\ViewMovies.cshtml"
       Write(movie.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 34 "D:\Yazılım\FilmReview\FilmReview\Views\Movie\ViewMovies.cshtml"
       Write(movie.Genre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 35 "D:\Yazılım\FilmReview\FilmReview\Views\Movie\ViewMovies.cshtml"
       Write(movie.Language);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 36 "D:\Yazılım\FilmReview\FilmReview\Views\Movie\ViewMovies.cshtml"
       Write(Html.ActionLink("Comment", "Comment", new { id = movie.Id }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 37 "D:\Yazılım\FilmReview\FilmReview\Views\Movie\ViewMovies.cshtml"
         if (HttpContextAccessor.HttpContext.Session.GetInt32("isAdmin") == 1)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <td>");
#nullable restore
#line 39 "D:\Yazılım\FilmReview\FilmReview\Views\Movie\ViewMovies.cshtml"
           Write(movie.IsActive);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 40 "D:\Yazılım\FilmReview\FilmReview\Views\Movie\ViewMovies.cshtml"
           Write(Html.ActionLink("ChangeStatus", "ChangeStatus", new { id = movie.Id }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 41 "D:\Yazılım\FilmReview\FilmReview\Views\Movie\ViewMovies.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </tr>\r\n");
#nullable restore
#line 44 "D:\Yazılım\FilmReview\FilmReview\Views\Movie\ViewMovies.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </table>\r\n    ");
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
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieTable> Html { get; private set; }
    }
}
#pragma warning restore 1591
