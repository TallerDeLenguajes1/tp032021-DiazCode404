#pragma checksum "C:\Users\Usuario\OneDrive\Escritorio\practicaC#\tp032021-DiazCode404\tp3-taller\ServicioDeCadeteria\Views\Order\OrderViews.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f891dd0dace3f38cb5b62855a09d714cfbbf2d6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_OrderViews), @"mvc.1.0.view", @"/Views/Order/OrderViews.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f891dd0dace3f38cb5b62855a09d714cfbbf2d6f", @"/Views/Order/OrderViews.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb54b11abf036bfac13411f8e4a1323634f3b803", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_OrderViews : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ServicioDeCadeteria.Entities.OrderClass>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!--como desde OrderControler se encio una lista de pedidos debo recibir dicha lista-->\r\n");
            WriteLiteral(@"
<table border=""1"">
    <tr>
        <th>Order number</th>
        <th>Client`s Name</th>
        <th>Client´s Adress</th>
        <th>DeliveryMan`s Id</th>
        <th>DeliveryMan`s Name</th>
        <th>Status</th>
        <th></th>
    </tr>
");
#nullable restore
#line 20 "C:\Users\Usuario\OneDrive\Escritorio\practicaC#\tp032021-DiazCode404\tp3-taller\ServicioDeCadeteria\Views\Order\OrderViews.cshtml"
      
        
        foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\Usuario\OneDrive\Escritorio\practicaC#\tp032021-DiazCode404\tp3-taller\ServicioDeCadeteria\Views\Order\OrderViews.cshtml"
           Write(item.Order_number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\Usuario\OneDrive\Escritorio\practicaC#\tp032021-DiazCode404\tp3-taller\ServicioDeCadeteria\Views\Order\OrderViews.cshtml"
           Write(item.Client.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\Usuario\OneDrive\Escritorio\practicaC#\tp032021-DiazCode404\tp3-taller\ServicioDeCadeteria\Views\Order\OrderViews.cshtml"
           Write(item.Client.Adress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\Usuario\OneDrive\Escritorio\practicaC#\tp032021-DiazCode404\tp3-taller\ServicioDeCadeteria\Views\Order\OrderViews.cshtml"
           Write(item.DeliveryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\Usuario\OneDrive\Escritorio\practicaC#\tp032021-DiazCode404\tp3-taller\ServicioDeCadeteria\Views\Order\OrderViews.cshtml"
           Write(item.DeliveryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\Usuario\OneDrive\Escritorio\practicaC#\tp032021-DiazCode404\tp3-taller\ServicioDeCadeteria\Views\Order\OrderViews.cshtml"
           Write(item.Order_status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>    \r\n            <td>\r\n                <input value=\"Change Status\" type=\"submit\" />\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 35 "C:\Users\Usuario\OneDrive\Escritorio\practicaC#\tp032021-DiazCode404\tp3-taller\ServicioDeCadeteria\Views\Order\OrderViews.cshtml"
            
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ServicioDeCadeteria.Entities.OrderClass>> Html { get; private set; }
    }
}
#pragma warning restore 1591
