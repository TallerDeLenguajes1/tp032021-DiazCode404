#pragma checksum "C:\Users\Usuario\OneDrive\Escritorio\practicaC#\tp032021-DiazCode404\tp3-taller\ServicioDeCadeteria\Views\Order\OrderCreator.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b6b01d885dd394f7d5ba130103ddf5e4ff2495a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_OrderCreator), @"mvc.1.0.view", @"/Views/Order/OrderCreator.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b6b01d885dd394f7d5ba130103ddf5e4ff2495a", @"/Views/Order/OrderCreator.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb54b11abf036bfac13411f8e4a1323634f3b803", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_OrderCreator : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ServicioDeCadeteria.Entities.DeliveryClass>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h2>You can place your order here!</h2>
<!--
    con toda esta informacion se creara un objeto de tipo OrderClass que se agregara a una lista de pedidos
    y vamos a extraer parte de estos datos para crear objetos clientes y agregarlos a una lista de clientes
-->
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b6b01d885dd394f7d5ba130103ddf5e4ff2495a4754", async() => {
                WriteLiteral(@"
    <div>
        <!--esta informacion se usara para registrar este cliente en una lista de clientes-->
        <label for=""client_name"">Name:<input type=""text"" id=""client_name"" name=""client_name"" required /></label>
        <label for=""client_adress"">Adress:<input type=""text"" id=""client_adress"" name=""client_adress"" required /></label>
        <label for=""client_telephone"">Telephone Number:<input type=""text"" id=""client_telephone"" name=""client_telephone"" required /></label>
    </div>
    <div>
        <label for=""client_order"">Please, place your order:</label><br />
        <textarea id=""client_order"" name=""client_order"" placeholder=""i want a sandwich with frites..."" required></textarea>
    </div>
    
        <div>
        <label for=""id_delivery"">Please,choose a deliery man:</label>
        <select id=""id_delivery"" name=""id_delivery"">
");
#nullable restore
#line 28 "C:\Users\Usuario\OneDrive\Escritorio\practicaC#\tp032021-DiazCode404\tp3-taller\ServicioDeCadeteria\Views\Order\OrderCreator.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b6b01d885dd394f7d5ba130103ddf5e4ff2495a6234", async() => {
#nullable restore
#line 30 "C:\Users\Usuario\OneDrive\Escritorio\practicaC#\tp032021-DiazCode404\tp3-taller\ServicioDeCadeteria\Views\Order\OrderCreator.cshtml"
                                                Write(item.DeliveryMan_name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\Usuario\OneDrive\Escritorio\practicaC#\tp032021-DiazCode404\tp3-taller\ServicioDeCadeteria\Views\Order\OrderCreator.cshtml"
                   WriteLiteral(item.DeliveryMan_id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 30 "C:\Users\Usuario\OneDrive\Escritorio\practicaC#\tp032021-DiazCode404\tp3-taller\ServicioDeCadeteria\Views\Order\OrderCreator.cshtml"
                                                                                    //de aqui envio el id del delivery para asignarle un pedido
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>\r\n    </div>\r\n    \r\n\r\n    <div>\r\n        <input type=\"submit\" value=\"Realizar Pedido\" />\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
