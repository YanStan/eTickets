#pragma checksum "C:\Users\User\source\repos\EducationTestProjects\WebCommercial\Views\Actors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "247eb9c39d49853f5e86a20383c9bd9752fae540"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Actors_Index), @"mvc.1.0.view", @"/Views/Actors/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"247eb9c39d49853f5e86a20383c9bd9752fae540", @"/Views/Actors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1249b676a95b8950717830ba6d34c64896aee95", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Actors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Actor>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\User\source\repos\EducationTestProjects\WebCommercial\Views\Actors\Index.cshtml"
  
	ViewData["Title"] = "List of Actors";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<div class=\"row\">\r\n\t<div class=\"col-md-8 offset-md-2\">\r\n\t\t<table class = \"table\">\r\n\t\t\t<thead>\r\n\t\t\t\t<tr>\t\t\t\r\n\t\t\t\t\t<th>");
#nullable restore
#line 15 "C:\Users\User\source\repos\EducationTestProjects\WebCommercial\Views\Actors\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.ProfilePictureURL));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t\t<th>");
#nullable restore
#line 16 "C:\Users\User\source\repos\EducationTestProjects\WebCommercial\Views\Actors\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\t\t\r\n\t\t\t\t\t<th>");
#nullable restore
#line 17 "C:\Users\User\source\repos\EducationTestProjects\WebCommercial\Views\Actors\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.Biography));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t\t<th>Actions</th>\r\n\t\t\t\t</tr>\r\n\t\t\t</thead>\r\n\t\t\t<tbody>\r\n");
#nullable restore
#line 22 "C:\Users\User\source\repos\EducationTestProjects\WebCommercial\Views\Actors\Index.cshtml"
                 foreach (var item in Model)
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td class =\"align-middle\">\r\n\t\t\t\t\t\t\t<img class=\"rounded-circle\"");
            BeginWriteAttribute("src", " src=", 587, "", 615, 1);
#nullable restore
#line 26 "C:\Users\User\source\repos\EducationTestProjects\WebCommercial\Views\Actors\Index.cshtml"
WriteAttributeValue("", 592, item.ProfilePictureURL, 592, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=", 615, "", 634, 1);
#nullable restore
#line 26 "C:\Users\User\source\repos\EducationTestProjects\WebCommercial\Views\Actors\Index.cshtml"
WriteAttributeValue("", 620, item.FullName, 620, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width: 150px\"/> \r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td class =\"align-middle\">\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 29 "C:\Users\User\source\repos\EducationTestProjects\WebCommercial\Views\Actors\Index.cshtml"
                       Write(Html.DisplayFor(model => item.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td class =\"align-middle\">\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 32 "C:\Users\User\source\repos\EducationTestProjects\WebCommercial\Views\Actors\Index.cshtml"
                       Write(Html.DisplayFor(model => item.Biography));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
						</td>
						<td class =""align-middle"">
							<a class=""btn btn-outline-primary""><i class=""bi bi-pencil-square""></i>Edit</a> | 
							<a class=""btn btn-outline-info""><i class=""bi bi-eye""></i>Details</a> | 
							<a class=""btn btn-danger text-white""><i class=""bi bi-trash""></i>Delete</a>
						</td>
					</tr>
");
#nullable restore
#line 40 "C:\Users\User\source\repos\EducationTestProjects\WebCommercial\Views\Actors\Index.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</tbody>\r\n\r\n\t\t</table>\r\n\r\n\t</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Actor>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591