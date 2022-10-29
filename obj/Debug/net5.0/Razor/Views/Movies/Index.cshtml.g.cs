#pragma checksum "C:\Users\User\source\repos\EducationTestProjects\WebCommercial\Views\Movies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4a723dd6c9c3b3ce0e678bb1a9db8754e8f9f24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Index), @"mvc.1.0.view", @"/Views/Movies/Index.cshtml")]
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
#line 1 "C:\Users\User\source\repos\EducationTestProjects\WebCommercial\Views\_ViewImports.cshtml"
using WebCommercial;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\EducationTestProjects\WebCommercial\Views\_ViewImports.cshtml"
using WebCommercial.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4a723dd6c9c3b3ce0e678bb1a9db8754e8f9f24", @"/Views/Movies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1249b676a95b8950717830ba6d34c64896aee95", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Movies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Movie>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\source\repos\EducationTestProjects\WebCommercial\Views\Movies\Index.cshtml"
  
    ViewData["Title"] = "List of Movies";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n");
#nullable restore
#line 8 "C:\Users\User\source\repos\EducationTestProjects\WebCommercial\Views\Movies\Index.cshtml"
     foreach (var item in Model)
    {

        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-4 col-xs-6 border-primary mb-3\">\r\n            <div class=\"card mb-3\" style=\"max-width: 540px\">\r\n");
            WriteLiteral("                <div class=\"row g-0\">\r\n\r\n\r\n");
            WriteLiteral("                    <div class=\"col-md-12\">\r\n");
            WriteLiteral("                        <div class=\"card-header text-white bg-info\">\r\n                            <p class=\"card-text\">\r\n                                <h5 class=\"card-title\">\r\n                                    ");
#nullable restore
#line 24 "C:\Users\User\source\repos\EducationTestProjects\WebCommercial\Views\Movies\Index.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    <a class=""text-white float-right"">
                                        <i class=""bi bi-pencil-square""></i>
                                    </a>
                                </h5>
                            </p>
                        </div>
                    </div>


                    <div class=""col-md-6"">
                        <img");
            BeginWriteAttribute("src", " src=", 1154, "", 1173, 1);
#nullable restore
#line 35 "C:\Users\User\source\repos\EducationTestProjects\WebCommercial\Views\Movies\Index.cshtml"
WriteAttributeValue("", 1159, item.ImageURL, 1159, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100%\"");
            BeginWriteAttribute("alt", " alt=\"", 1186, "\"", 1192, 0);
            EndWriteAttribute();
            WriteLiteral("/>\r\n                    </div>\r\n\r\n\r\n                    <div class=\"col-md-6\">\r\n                        <div class=\"card-body\">\r\n                            <p class=\"card-text\">");
#nullable restore
#line 41 "C:\Users\User\source\repos\EducationTestProjects\WebCommercial\Views\Movies\Index.cshtml"
                                            Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\"><b>Cinema: </b>");
#nullable restore
#line 42 "C:\Users\User\source\repos\EducationTestProjects\WebCommercial\Views\Movies\Index.cshtml"
                                                           Write(item.Cinema.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\"><b>Category: </b>");
#nullable restore
#line 43 "C:\Users\User\source\repos\EducationTestProjects\WebCommercial\Views\Movies\Index.cshtml"
                                                             Write(item.MovieCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\"><b>Start Date: </b>");
#nullable restore
#line 44 "C:\Users\User\source\repos\EducationTestProjects\WebCommercial\Views\Movies\Index.cshtml"
                                                               Write(item.StartDate.ToString("dd/MM/yy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\"><b>End Date: </b>");
#nullable restore
#line 45 "C:\Users\User\source\repos\EducationTestProjects\WebCommercial\Views\Movies\Index.cshtml"
                                                             Write(item.EndDate.ToString("dd/MM/yy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\">\r\n                                <b>Status: </b>\r\n");
#nullable restore
#line 48 "C:\Users\User\source\repos\EducationTestProjects\WebCommercial\Views\Movies\Index.cshtml"
                                 if (DateTime.UtcNow >= item.StartDate && DateTime.UtcNow <= item.EndDate)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge bg-success text-white\">AVAILABLE</span>\r\n");
#nullable restore
#line 51 "C:\Users\User\source\repos\EducationTestProjects\WebCommercial\Views\Movies\Index.cshtml"
                                }
                                else if (DateTime.UtcNow > item.EndDate)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge bg-danger text-white\">EXPIRED</span>\r\n");
#nullable restore
#line 55 "C:\Users\User\source\repos\EducationTestProjects\WebCommercial\Views\Movies\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge bg-primary text-white\">UPCOMING</span>\r\n");
#nullable restore
#line 59 "C:\Users\User\source\repos\EducationTestProjects\WebCommercial\Views\Movies\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </p>
                        </div>
                    </div>


                    <div class=""col-md-12"">
                        <div class=""card-footer"">
                            <p class=""card-text"">
                                <a class=""btn btn-outline-primary float-right""><i class=""bi bi-eye-fill""></i> Show Details</a>
                                <a class=""btn btn-success text-white""><i class=""bi bi-cart-plus""></i> Add to cart (");
#nullable restore
#line 69 "C:\Users\User\source\repos\EducationTestProjects\WebCommercial\Views\Movies\Index.cshtml"
                                                                                                              Write(item.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral(")</a>\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 77 "C:\Users\User\source\repos\EducationTestProjects\WebCommercial\Views\Movies\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Movie>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
