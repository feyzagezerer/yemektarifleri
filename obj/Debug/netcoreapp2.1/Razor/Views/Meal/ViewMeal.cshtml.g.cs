#pragma checksum "C:\Users\feyza\Desktop\SAU\Source\Repos\YemekTarifleriWeb\YemekTarifleriWeb\Views\Meal\ViewMeal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fb502002f48060634cd12b74047d54f85fe476e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Meal_ViewMeal), @"mvc.1.0.view", @"/Views/Meal/ViewMeal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Meal/ViewMeal.cshtml", typeof(AspNetCore.Views_Meal_ViewMeal))]
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
#line 1 "C:\Users\feyza\Desktop\SAU\Source\Repos\YemekTarifleriWeb\YemekTarifleriWeb\Views\_ViewImports.cshtml"
using YemekTarifleriWeb;

#line default
#line hidden
#line 2 "C:\Users\feyza\Desktop\SAU\Source\Repos\YemekTarifleriWeb\YemekTarifleriWeb\Views\_ViewImports.cshtml"
using YemekTarifleriWeb.Models;

#line default
#line hidden
#line 1 "C:\Users\feyza\Desktop\SAU\Source\Repos\YemekTarifleriWeb\YemekTarifleriWeb\Views\Meal\ViewMeal.cshtml"
using System.Globalization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fb502002f48060634cd12b74047d54f85fe476e", @"/Views/Meal/ViewMeal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5cf155adcaa7f814a5cb7e56cd2e9e556585aac", @"/Views/_ViewImports.cshtml")]
    public class Views_Meal_ViewMeal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Meal>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 1088, true);
            WriteLiteral(@"<nav class=""navbar navbar-fixed-top navbar-inverse"" role=""navigation"">
    <div class=""container"">
        <div class=""navbar-header"">
            <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target="".navbar-ex1-collapse"">
                <span class=""sr-only"">Toggle navigation</span>
                <span class=""icon-bar""></span>
                <span class=""icon-bar""></span>
                <span class=""icon-bar""></span>
            </button>
            <a class=""navbar-brand"" href=""/Home/Index"">Yemek Tarifleri</a>
        </div>
        <!-- Collect the nav links, forms, and other content for toggling -->
        <div class=""collapse navbar-collapse navbar-ex1-collapse"">
            <ul class=""nav navbar-nav navbar-right"">
                <li class=""active""><a href=""index.html"">Ana Sayfa</a></li>
                <li class=""dropdown"">
                    <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" data-hover=""dropdown"">Yemekler<i class=""fa fa-angle-");
            WriteLiteral("down\"></i></a>\r\n                    <ul class=\"dropdown-menu\">\r\n");
            EndContext();
#line 21 "C:\Users\feyza\Desktop\SAU\Source\Repos\YemekTarifleriWeb\YemekTarifleriWeb\Views\Meal\ViewMeal.cshtml"
                         foreach (var tc in (List<TopCategory>)ViewBag.TopCategories)
                        {

#line default
#line hidden
            BeginContext(1251, 34, true);
            WriteLiteral("                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1285, "\"", 1321, 2);
            WriteAttributeValue("", 1292, "/Category/ViewCategory/", 1292, 23, true);
#line 23 "C:\Users\feyza\Desktop\SAU\Source\Repos\YemekTarifleriWeb\YemekTarifleriWeb\Views\Meal\ViewMeal.cshtml"
WriteAttributeValue("", 1315, tc.Id, 1315, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1322, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1324, 5, false);
#line 23 "C:\Users\feyza\Desktop\SAU\Source\Repos\YemekTarifleriWeb\YemekTarifleriWeb\Views\Meal\ViewMeal.cshtml"
                                                                   Write(tc.Ad);

#line default
#line hidden
            EndContext();
            BeginContext(1329, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 24 "C:\Users\feyza\Desktop\SAU\Source\Repos\YemekTarifleriWeb\YemekTarifleriWeb\Views\Meal\ViewMeal.cshtml"
                        }

#line default
#line hidden
            BeginContext(1367, 482, true);
            WriteLiteral(@"                    </ul>
                </li>
                <li><a href=""index.html"">Hakk??m??zda</a></li>
                <li><a href=""contact.html"">??leti??im</a></li>
            </ul>
        </div><!-- /.navbar-collapse -->
    </div><!-- /.container -->
</nav>
<div class=""section"" id=""recent-projects"" style=""position: relative;"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <h2 class=""section-title"">");
            EndContext();
            BeginContext(1850, 12, false);
#line 37 "C:\Users\feyza\Desktop\SAU\Source\Repos\YemekTarifleriWeb\YemekTarifleriWeb\Views\Meal\ViewMeal.cshtml"
                                     Write(ViewBag.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1862, 27, true);
            WriteLiteral("</h2>\r\n            </div>\r\n");
            EndContext();
#line 39 "C:\Users\feyza\Desktop\SAU\Source\Repos\YemekTarifleriWeb\YemekTarifleriWeb\Views\Meal\ViewMeal.cshtml"
             foreach (var item in Model)
            {
                string imgSrc = item.Ad.ToLower(new CultureInfo("tr-TR", false)) + ".jpg";

#line default
#line hidden
            BeginContext(2038, 83, true);
            WriteLiteral("                <div class=\"col-lg-4 col-md-4 col-sm-6\">\r\n                    <a <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2121, "\"", 2163, 2);
            WriteAttributeValue("", 2128, "/MealDetail/ViewMealDetail/", 2128, 27, true);
#line 43 "C:\Users\feyza\Desktop\SAU\Source\Repos\YemekTarifleriWeb\YemekTarifleriWeb\Views\Meal\ViewMeal.cshtml"
WriteAttributeValue("", 2155, item.Id, 2155, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2164, 115, true);
            WriteLiteral(" class=\"link-portfolio\">\r\n                        <div class=\"overlay-portfolio\">\r\n                            <h3>");
            EndContext();
            BeginContext(2280, 7, false);
#line 45 "C:\Users\feyza\Desktop\SAU\Source\Repos\YemekTarifleriWeb\YemekTarifleriWeb\Views\Meal\ViewMeal.cshtml"
                           Write(item.Ad);

#line default
#line hidden
            EndContext();
            BeginContext(2287, 109, true);
            WriteLiteral("</h3>\r\n                        </div>\r\n                        <img class=\"img-responsive img-home-portfolio\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2396, "\"", 2417, 2);
            WriteAttributeValue("", 2402, "/images/", 2402, 8, true);
#line 47 "C:\Users\feyza\Desktop\SAU\Source\Repos\YemekTarifleriWeb\YemekTarifleriWeb\Views\Meal\ViewMeal.cshtml"
WriteAttributeValue("", 2410, imgSrc, 2410, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2418, "\"", 2432, 1);
#line 47 "C:\Users\feyza\Desktop\SAU\Source\Repos\YemekTarifleriWeb\YemekTarifleriWeb\Views\Meal\ViewMeal.cshtml"
WriteAttributeValue("", 2424, item.Ad, 2424, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2433, 53, true);
            WriteLiteral(">\r\n                    </a>\r\n                </div>\r\n");
            EndContext();
#line 50 "C:\Users\feyza\Desktop\SAU\Source\Repos\YemekTarifleriWeb\YemekTarifleriWeb\Views\Meal\ViewMeal.cshtml"
            }

#line default
#line hidden
            BeginContext(2501, 88, true);
            WriteLiteral("        </div><!-- /.row -->\r\n    </div><!-- /.container -->\r\n</div><!-- /.section -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Meal>> Html { get; private set; }
    }
}
#pragma warning restore 1591
