#pragma checksum "D:\UIC 2017\cs341_proj7_Downloaded\aspnet\web\Views\MoviesTop10.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95f1c9810124aa781df0cba7b03a002b84cd3af4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(program.Pages.Views_MoviesTop10), @"mvc.1.0.razor-page", @"/Views/MoviesTop10.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Views/MoviesTop10.cshtml", typeof(program.Pages.Views_MoviesTop10), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95f1c9810124aa781df0cba7b03a002b84cd3af4", @"/Views/MoviesTop10.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65a87352ab55936b7625448d2e9155e1658af919", @"/Views/_ViewImports.cshtml")]
    public class Views_MoviesTop10 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\UIC 2017\cs341_proj7_Downloaded\aspnet\web\Views\MoviesTop10.cshtml"
  
  ViewData["Title"] = "Top-10 Movies";

#line default
#line hidden
            BeginContext(74, 27, true);
            WriteLiteral("\n<h2>Top-10 Movies</h2>  \n\n");
            EndContext();
#line 9 "D:\UIC 2017\cs341_proj7_Downloaded\aspnet\web\Views\MoviesTop10.cshtml"
  
   if (@Model.EX != null)
	 {

#line default
#line hidden
            BeginContext(134, 37, true);
            WriteLiteral("\t   <br />\n\t\t <br />\n\t\t <h3>**ERROR: ");
            EndContext();
            BeginContext(172, 16, false);
#line 14 "D:\UIC 2017\cs341_proj7_Downloaded\aspnet\web\Views\MoviesTop10.cshtml"
                 Write(Model.EX.Message);

#line default
#line hidden
            EndContext();
            BeginContext(188, 46, true);
            WriteLiteral("</h3>\n\t\t <br />\n\t\t <hr />\n\t\t <br />\n\t\t <br />\n");
            EndContext();
#line 19 "D:\UIC 2017\cs341_proj7_Downloaded\aspnet\web\Views\MoviesTop10.cshtml"
	 }

#line default
#line hidden
            BeginContext(240, 419, true);
            WriteLiteral(@"
<table class=""table"">  
    <thead>  
        <tr>  
            <th>  
                Rank
            </th>  
            <th>  
                MovieID
            </th>  
            <th>  
                NumReviews 
            </th>  
            <th>  
                AvgRating
            </th>  
            <th>  
                MovieName
            </th>  
        </tr>  
    </thead>  
    <tbody>  
");
            EndContext();
#line 43 "D:\UIC 2017\cs341_proj7_Downloaded\aspnet\web\Views\MoviesTop10.cshtml"
                  
				   int rank = 1;
				 

#line default
#line hidden
            BeginContext(694, 5, true);
            WriteLiteral("\t\t\t\t\n");
            EndContext();
#line 47 "D:\UIC 2017\cs341_proj7_Downloaded\aspnet\web\Views\MoviesTop10.cshtml"
         foreach (var item in Model.MovieList)  
        {  

#line default
#line hidden
            BeginContext(760, 52, true);
            WriteLiteral("            <tr>  \n                <td>  \n\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(813, 4, false);
#line 51 "D:\UIC 2017\cs341_proj7_Downloaded\aspnet\web\Views\MoviesTop10.cshtml"
                                   Write(rank);

#line default
#line hidden
            EndContext();
            BeginContext(817, 68, true);
            WriteLiteral("\n                </td>  \n                <td>  \n                    ");
            EndContext();
            BeginContext(886, 12, false);
#line 54 "D:\UIC 2017\cs341_proj7_Downloaded\aspnet\web\Views\MoviesTop10.cshtml"
               Write(item.MovieID);

#line default
#line hidden
            EndContext();
            BeginContext(898, 68, true);
            WriteLiteral("\n                </td>  \n                <td>  \n                    ");
            EndContext();
            BeginContext(967, 15, false);
#line 57 "D:\UIC 2017\cs341_proj7_Downloaded\aspnet\web\Views\MoviesTop10.cshtml"
               Write(item.NumReviews);

#line default
#line hidden
            EndContext();
            BeginContext(982, 68, true);
            WriteLiteral("\n                </td>  \n                <td>  \n                    ");
            EndContext();
            BeginContext(1051, 14, false);
#line 60 "D:\UIC 2017\cs341_proj7_Downloaded\aspnet\web\Views\MoviesTop10.cshtml"
               Write(item.AvgRating);

#line default
#line hidden
            EndContext();
            BeginContext(1065, 68, true);
            WriteLiteral("\n                </td>  \n                <td>  \n                    ");
            EndContext();
            BeginContext(1134, 14, false);
#line 63 "D:\UIC 2017\cs341_proj7_Downloaded\aspnet\web\Views\MoviesTop10.cshtml"
               Write(item.MovieName);

#line default
#line hidden
            EndContext();
            BeginContext(1148, 45, true);
            WriteLiteral("\n                </td>  \n            </tr>  \n");
            EndContext();
#line 66 "D:\UIC 2017\cs341_proj7_Downloaded\aspnet\web\Views\MoviesTop10.cshtml"
						
						rank++;
        }  

#line default
#line hidden
            BeginContext(1226, 24, true);
            WriteLiteral("    </tbody>  \n</table> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MoviesTop10Model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MoviesTop10Model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MoviesTop10Model>)PageContext?.ViewData;
        public MoviesTop10Model Model => ViewData.Model;
    }
}
#pragma warning restore 1591
