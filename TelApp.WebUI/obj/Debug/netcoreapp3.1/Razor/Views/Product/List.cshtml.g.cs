#pragma checksum "C:\Users\adnan\Desktop\Adnan\dotnetCore\TelApp.WebUI\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f06b79daa9ff5751eb7423787d380ee37f0f2ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
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
#line 1 "C:\Users\adnan\Desktop\Adnan\dotnetCore\TelApp.WebUI\Views\_ViewImports.cshtml"
using TelApp.WebUI.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\adnan\Desktop\Adnan\dotnetCore\TelApp.WebUI\Views\_ViewImports.cshtml"
using TelApp.WebUI.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f06b79daa9ff5751eb7423787d380ee37f0f2ab", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b1b2d2c16e6a3202ed3f3ecf4d4c04df09bed5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductViewModels>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\adnan\Desktop\Adnan\dotnetCore\TelApp.WebUI\Views\Product\List.cshtml"
  
    var popularClass= Model.products.Count>2 ? "popular" : "";
    var products=Model.products;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Categories", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 8 "C:\Users\adnan\Desktop\Adnan\dotnetCore\TelApp.WebUI\Views\Product\List.cshtml"
Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("<ul>\r\n");
#nullable restore
#line 11 "C:\Users\adnan\Desktop\Adnan\dotnetCore\TelApp.WebUI\Views\Product\List.cshtml"
     if (products.Count==0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\adnan\Desktop\Adnan\dotnetCore\TelApp.WebUI\Views\Product\List.cshtml"
   Write(await Html.PartialAsync("_noproduct"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\adnan\Desktop\Adnan\dotnetCore\TelApp.WebUI\Views\Product\List.cshtml"
                                              ;
    }
    else{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n");
#nullable restore
#line 17 "C:\Users\adnan\Desktop\Adnan\dotnetCore\TelApp.WebUI\Views\Product\List.cshtml"
             foreach (var item in products)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-3\">\r\n                    ");
#nullable restore
#line 20 "C:\Users\adnan\Desktop\Adnan\dotnetCore\TelApp.WebUI\Views\Product\List.cshtml"
               Write(await Html.PartialAsync("_product",item));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 22 "C:\Users\adnan\Desktop\Adnan\dotnetCore\TelApp.WebUI\Views\Product\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 24 "C:\Users\adnan\Desktop\Adnan\dotnetCore\TelApp.WebUI\Views\Product\List.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductViewModels> Html { get; private set; }
    }
}
#pragma warning restore 1591
