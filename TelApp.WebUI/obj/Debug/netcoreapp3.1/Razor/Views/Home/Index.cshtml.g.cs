#pragma checksum "C:\Users\adnan\Desktop\Adnan\dotnetCore\TelApp.WebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e45bfa644b135055092e06102566e7267ae72cc9"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e45bfa644b135055092e06102566e7267ae72cc9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b1b2d2c16e6a3202ed3f3ecf4d4c04df09bed5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductViewModels>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\adnan\Desktop\Adnan\dotnetCore\TelApp.WebUI\Views\Home\Index.cshtml"
  
    var products=Model.products;  

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("MessageBox", async() => {
                WriteLiteral("\r\n    <div class=\"alert alert-success text-center m-0\">\r\n        You have new message!\r\n    </div>\r\n");
            }
            );
            WriteLiteral("<ul>\r\n");
#nullable restore
#line 12 "C:\Users\adnan\Desktop\Adnan\dotnetCore\TelApp.WebUI\Views\Home\Index.cshtml"
     if (products.Count==0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\adnan\Desktop\Adnan\dotnetCore\TelApp.WebUI\Views\Home\Index.cshtml"
   Write(await Html.PartialAsync("_noproduct"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\adnan\Desktop\Adnan\dotnetCore\TelApp.WebUI\Views\Home\Index.cshtml"
                                              ;
    }
    else{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n");
#nullable restore
#line 18 "C:\Users\adnan\Desktop\Adnan\dotnetCore\TelApp.WebUI\Views\Home\Index.cshtml"
             foreach (var item in products)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-3\">\r\n                    ");
#nullable restore
#line 21 "C:\Users\adnan\Desktop\Adnan\dotnetCore\TelApp.WebUI\Views\Home\Index.cshtml"
               Write(await Html.PartialAsync("_product",item));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 23 "C:\Users\adnan\Desktop\Adnan\dotnetCore\TelApp.WebUI\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 25 "C:\Users\adnan\Desktop\Adnan\dotnetCore\TelApp.WebUI\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"" integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"" integrity=""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM"" crossorigin=""anonymous""></script>
");
            }
            );
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
