#pragma checksum "C:\Users\debra_2qm34gh\source\repos\BikesNBeersProjectVersion3\BikesNBeers\BikesNBeersMVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b01dd2a7b5697ca40b51d177e793dc336bb7ea32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\debra_2qm34gh\source\repos\BikesNBeersProjectVersion3\BikesNBeers\BikesNBeersMVC\Views\_ViewImports.cshtml"
using BikesNBeersMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\debra_2qm34gh\source\repos\BikesNBeersProjectVersion3\BikesNBeers\BikesNBeersMVC\Views\_ViewImports.cshtml"
using BikesNBeersMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b01dd2a7b5697ca40b51d177e793dc336bb7ea32", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37a0395b447a1a9a7ba65ef1e1744b635a6ea47f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\debra_2qm34gh\source\repos\BikesNBeersProjectVersion3\BikesNBeers\BikesNBeersMVC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <h1>\r\n        Hotels List\r\n    </h1>\r\n   <br />\r\n");
#nullable restore
#line 12 "C:\Users\debra_2qm34gh\source\repos\BikesNBeersProjectVersion3\BikesNBeers\BikesNBeersMVC\Views\Home\Index.cshtml"
     foreach(var response in Model.HotelResponses.results)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\debra_2qm34gh\source\repos\BikesNBeersProjectVersion3\BikesNBeers\BikesNBeersMVC\Views\Home\Index.cshtml"
   Write(response.name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\debra_2qm34gh\source\repos\BikesNBeersProjectVersion3\BikesNBeers\BikesNBeersMVC\Views\Home\Index.cshtml"
                      ;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 16 "C:\Users\debra_2qm34gh\source\repos\BikesNBeersProjectVersion3\BikesNBeers\BikesNBeersMVC\Views\Home\Index.cshtml"
   Write(response.rating);

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\debra_2qm34gh\source\repos\BikesNBeersProjectVersion3\BikesNBeers\BikesNBeersMVC\Views\Home\Index.cshtml"
                        ;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 18 "C:\Users\debra_2qm34gh\source\repos\BikesNBeersProjectVersion3\BikesNBeers\BikesNBeersMVC\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>\r\n    Breweries List\r\n</h1>\r\n    <br />\r\n");
#nullable restore
#line 23 "C:\Users\debra_2qm34gh\source\repos\BikesNBeersProjectVersion3\BikesNBeers\BikesNBeersMVC\Views\Home\Index.cshtml"
     foreach(var response in Model.Breweries.Results)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\debra_2qm34gh\source\repos\BikesNBeersProjectVersion3\BikesNBeers\BikesNBeersMVC\Views\Home\Index.cshtml"
   Write(response.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\debra_2qm34gh\source\repos\BikesNBeersProjectVersion3\BikesNBeers\BikesNBeersMVC\Views\Home\Index.cshtml"
                      ;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 28 "C:\Users\debra_2qm34gh\source\repos\BikesNBeersProjectVersion3\BikesNBeers\BikesNBeersMVC\Views\Home\Index.cshtml"
   Write(response.Rating);

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\debra_2qm34gh\source\repos\BikesNBeersProjectVersion3\BikesNBeers\BikesNBeersMVC\Views\Home\Index.cshtml"
                        ;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 30 "C:\Users\debra_2qm34gh\source\repos\BikesNBeersProjectVersion3\BikesNBeers\BikesNBeersMVC\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
