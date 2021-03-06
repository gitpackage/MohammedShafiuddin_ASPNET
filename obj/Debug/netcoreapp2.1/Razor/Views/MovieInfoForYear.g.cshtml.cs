#pragma checksum "D:\UIC 2017\cs341_proj7_Downloaded\aspnet\web\Views\MovieInfoForYear.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "768709316e012da8d8bbbbfa4a21ba61021336d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(program.Pages.Views_MovieInfoForYear), @"mvc.1.0.razor-page", @"/Views/MovieInfoForYear.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Views/MovieInfoForYear.cshtml", typeof(program.Pages.Views_MovieInfoForYear), null)]
namespace program.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\UIC 2017\cs341_proj7_Downloaded\aspnet\web\Views\_ViewImports.cshtml"
using program;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"768709316e012da8d8bbbbfa4a21ba61021336d3", @"/Views/MovieInfoForYear.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65a87352ab55936b7625448d2e9155e1658af919", @"/Views/_ViewImports.cshtml")]
    public class Views_MovieInfoForYear : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\UIC 2017\cs341_proj7_Downloaded\aspnet\web\Views\MovieInfoForYear.cshtml"
  
  ViewData["Title"] = "Movie Information for Year";

#line default
#line hidden
            BeginContext(92, 59, true);
            WriteLiteral("\n<h2>Movie Information</h2>  \n\n<br />\nYour search string: \"");
            EndContext();
            BeginContext(152, 11, false);
#line 10 "D:\UIC 2017\cs341_proj7_Downloaded\aspnet\web\Views\MovieInfoForYear.cshtml"
                Write(Model.Input);

#line default
#line hidden
            EndContext();
            BeginContext(163, 28, true);
            WriteLiteral("\"\n<br />\n# of movies found: ");
            EndContext();
            BeginContext(192, 15, false);
#line 12 "D:\UIC 2017\cs341_proj7_Downloaded\aspnet\web\Views\MovieInfoForYear.cshtml"
              Write(Model.NumMovies);

#line default
#line hidden
            EndContext();
            BeginContext(207, 15, true);
            WriteLiteral("\n<br />\n<br />\n");
            EndContext();
#line 15 "D:\UIC 2017\cs341_proj7_Downloaded\aspnet\web\Views\MovieInfoForYear.cshtml"
  
   if (@Model.EX != null)
	 {

#line default
#line hidden
            BeginContext(255, 16, true);
            WriteLiteral("\t\t <h3>**ERROR: ");
            EndContext();
            BeginContext(272, 16, false);
#line 18 "D:\UIC 2017\cs341_proj7_Downloaded\aspnet\web\Views\MovieInfoForYear.cshtml"
                 Write(Model.EX.Message);

#line default
#line hidden
            EndContext();
            BeginContext(288, 46, true);
            WriteLiteral("</h3>\n\t\t <br />\n\t\t <hr />\n\t\t <br />\n\t\t <br />\n");
            EndContext();
#line 23 "D:\UIC 2017\cs341_proj7_Downloaded\aspnet\web\Views\MovieInfoForYear.cshtml"
	 }

#line default
#line hidden
            BeginContext(340, 404, true);
            WriteLiteral(@"
<table class=""table"">  
    <thead>  
        <tr>   
            <th>  
                ID
            </th>  
						<th>  
                Name
            </th>  
		        <th>  
                Year 
            </th>  
            <th>  
                NumReviews
            </th>  
            <th>  
                AvgRating 
            </th>  

        </tr>  
    </thead>  
    <tbody>  
");
            EndContext();
#line 48 "D:\UIC 2017\cs341_proj7_Downloaded\aspnet\web\Views\MovieInfoForYear.cshtml"
         foreach (var item in Model.MovieList)  
        {  

#line default
#line hidden
            BeginContext(805, 52, true);
            WriteLiteral("            <tr>  \n                <td>  \n\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(858, 12, false);
#line 52 "D:\UIC 2017\cs341_proj7_Downloaded\aspnet\web\Views\MovieInfoForYear.cshtml"
                                   Write(item.MovieID);

#line default
#line hidden
            EndContext();
            BeginContext(870, 68, true);
            WriteLiteral("\n                </td>  \n                <td>  \n                    ");
            EndContext();
            BeginContext(939, 14, false);
#line 55 "D:\UIC 2017\cs341_proj7_Downloaded\aspnet\web\Views\MovieInfoForYear.cshtml"
               Write(item.MovieName);

#line default
#line hidden
            EndContext();
            BeginContext(953, 59, true);
            WriteLiteral("\n                </td> \n\t\t\t\t\t\t\t\t<td>  \n                    ");
            EndContext();
            BeginContext(1013, 14, false);
#line 58 "D:\UIC 2017\cs341_proj7_Downloaded\aspnet\web\Views\MovieInfoForYear.cshtml"
               Write(item.MovieYear);

#line default
#line hidden
            EndContext();
            BeginContext(1027, 59, true);
            WriteLiteral("\n                </td> \n\t\t\t\t\t\t\t\t<td>  \n                    ");
            EndContext();
            BeginContext(1087, 15, false);
#line 61 "D:\UIC 2017\cs341_proj7_Downloaded\aspnet\web\Views\MovieInfoForYear.cshtml"
               Write(item.NumReviews);

#line default
#line hidden
            EndContext();
            BeginContext(1102, 68, true);
            WriteLiteral("\n                </td>  \n                <td>  \n                    ");
            EndContext();
            BeginContext(1171, 14, false);
#line 64 "D:\UIC 2017\cs341_proj7_Downloaded\aspnet\web\Views\MovieInfoForYear.cshtml"
               Write(item.AvgRating);

#line default
#line hidden
            EndContext();
            BeginContext(1185, 45, true);
            WriteLiteral("\n                </td>  \n            </tr>  \n");
            EndContext();
#line 67 "D:\UIC 2017\cs341_proj7_Downloaded\aspnet\web\Views\MovieInfoForYear.cshtml"
        }  

#line default
#line hidden
            BeginContext(1242, 26, true);
            WriteLiteral("    </tbody>  \n</table> \n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieInfoForYearModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MovieInfoForYearModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MovieInfoForYearModel>)PageContext?.ViewData;
        public MovieInfoForYearModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
