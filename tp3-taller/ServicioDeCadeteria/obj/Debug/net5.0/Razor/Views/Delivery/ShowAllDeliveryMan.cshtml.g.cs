#pragma checksum "C:\Users\Usuario\OneDrive\Escritorio\practicaC#\tp032021-DiazCode404\tp3-taller\ServicioDeCadeteria\Views\Delivery\ShowAllDeliveryMan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a15e22b588659f56d7c4b16753b87115b3ce7a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Delivery_ShowAllDeliveryMan), @"mvc.1.0.view", @"/Views/Delivery/ShowAllDeliveryMan.cshtml")]
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
#line 1 "C:\Users\Usuario\OneDrive\Escritorio\practicaC#\tp032021-DiazCode404\tp3-taller\ServicioDeCadeteria\Views\_ViewImports.cshtml"
using ServicioDeCadeteria;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\OneDrive\Escritorio\practicaC#\tp032021-DiazCode404\tp3-taller\ServicioDeCadeteria\Views\_ViewImports.cshtml"
using ServicioDeCadeteria.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a15e22b588659f56d7c4b16753b87115b3ce7a4", @"/Views/Delivery/ShowAllDeliveryMan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb54b11abf036bfac13411f8e4a1323634f3b803", @"/Views/_ViewImports.cshtml")]
    public class Views_Delivery_ShowAllDeliveryMan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ServicioDeCadeteria.Entities.DeliveryClass>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<table>\r\n    <tr>\r\n        <th>id</th>\r\n        <th>Name</th>\r\n        <th>Adress</th>\r\n        <th>Telephone number</th>\r\n    </tr>\r\n    <tr>\r\n");
#nullable restore
#line 17 "C:\Users\Usuario\OneDrive\Escritorio\practicaC#\tp032021-DiazCode404\tp3-taller\ServicioDeCadeteria\Views\Delivery\ShowAllDeliveryMan.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 19 "C:\Users\Usuario\OneDrive\Escritorio\practicaC#\tp032021-DiazCode404\tp3-taller\ServicioDeCadeteria\Views\Delivery\ShowAllDeliveryMan.cshtml"
           Write(item.DeliveryMan_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\Usuario\OneDrive\Escritorio\practicaC#\tp032021-DiazCode404\tp3-taller\ServicioDeCadeteria\Views\Delivery\ShowAllDeliveryMan.cshtml"
           Write(item.DeliveryMan_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\Usuario\OneDrive\Escritorio\practicaC#\tp032021-DiazCode404\tp3-taller\ServicioDeCadeteria\Views\Delivery\ShowAllDeliveryMan.cshtml"
           Write(item.DeliveryMan_adress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\Usuario\OneDrive\Escritorio\practicaC#\tp032021-DiazCode404\tp3-taller\ServicioDeCadeteria\Views\Delivery\ShowAllDeliveryMan.cshtml"
           Write(item.DeliveryMan_telephone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 23 "C:\Users\Usuario\OneDrive\Escritorio\practicaC#\tp032021-DiazCode404\tp3-taller\ServicioDeCadeteria\Views\Delivery\ShowAllDeliveryMan.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ServicioDeCadeteria.Entities.DeliveryClass>> Html { get; private set; }
    }
}
#pragma warning restore 1591
