#pragma checksum "C:\Users\S145\Documents\MeusProjetos\Farmacia\Views\Pedido\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b45f8f0f4d05a3b178789634da66fac0bd63e91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Lista), @"mvc.1.0.view", @"/Views/Pedido/Lista.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\S145\Documents\MeusProjetos\Farmacia\Views\_ViewImports.cshtml"
using Farmacia;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\S145\Documents\MeusProjetos\Farmacia\Views\_ViewImports.cshtml"
using Farmacia.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\S145\Documents\MeusProjetos\Farmacia\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\S145\Documents\MeusProjetos\Farmacia\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\S145\Documents\MeusProjetos\Farmacia\Views\_ViewImports.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b45f8f0f4d05a3b178789634da66fac0bd63e91", @"/Views/Pedido/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b15906193faebf6f564b3fdd64f00fd333e2b059", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Pedido>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\S145\Documents\MeusProjetos\Farmacia\Views\Pedido\Lista.cshtml"
      
        ViewData["Title"] = "Lista de Pedidos";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Lista de Pedidos</h2>    \r\n<table>\r\n    <thead>\r\n        <th>Id</th>\r\n        <th>Data</th>\r\n        <th>Clinica (id)</th>\r\n        <th></th>\r\n        \r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 15 "C:\Users\S145\Documents\MeusProjetos\Farmacia\Views\Pedido\Lista.cshtml"
         foreach (Pedido item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 18 "C:\Users\S145\Documents\MeusProjetos\Farmacia\Views\Pedido\Lista.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\S145\Documents\MeusProjetos\Farmacia\Views\Pedido\Lista.cshtml"
               Write(item.DataPedido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\S145\Documents\MeusProjetos\Farmacia\Views\Pedido\Lista.cshtml"
               Write(item.clinica.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 482, "\"", 516, 2);
            WriteAttributeValue("", 489, "/Pedido/Detalhe?id=", 489, 19, true);
#nullable restore
#line 21 "C:\Users\S145\Documents\MeusProjetos\Farmacia\Views\Pedido\Lista.cshtml"
WriteAttributeValue("", 508, item.Id, 508, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Detalhes</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 23 "C:\Users\S145\Documents\MeusProjetos\Farmacia\Views\Pedido\Lista.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Pedido>> Html { get; private set; }
    }
}
#pragma warning restore 1591
