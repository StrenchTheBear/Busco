#pragma checksum "C:\Users\USER\Documents\PROGRAMACION-1\busco\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4077dd42fa204f336a95802505eab4c928a0a90"
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
#line 1 "C:\Users\USER\Documents\PROGRAMACION-1\busco\Views\_ViewImports.cshtml"
using busco;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\Documents\PROGRAMACION-1\busco\Views\_ViewImports.cshtml"
using busco.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4077dd42fa204f336a95802505eab4c928a0a90", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85e015e12421e115c5a0cdb2a68571df259cd2d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Registro>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\USER\Documents\PROGRAMACION-1\busco\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Lista de solicitud de compra</h1>
<table class=""table"" style=""background-color: #FFFFFF!important;"">
    
    <tr>
        <th>Nombre</th>
        <th>Url</th>
        <th>Descripcion</th>
        <th>Precio</th>
        <th>Celular</th>
        <th>Lugar</th>
        <th>NombreUsuario</th>
    </tr>

");
#nullable restore
#line 21 "C:\Users\USER\Documents\PROGRAMACION-1\busco\Views\Home\Index.cshtml"
     if (Model.Count == 0) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td colspan=\"4\" class=\"text-center\">No se encontraron registros.</td>\n            </tr>\n");
#nullable restore
#line 25 "C:\Users\USER\Documents\PROGRAMACION-1\busco\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \n");
#nullable restore
#line 27 "C:\Users\USER\Documents\PROGRAMACION-1\busco\Views\Home\Index.cshtml"
     foreach (var registro in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 30 "C:\Users\USER\Documents\PROGRAMACION-1\busco\Views\Home\Index.cshtml"
           Write(registro.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 31 "C:\Users\USER\Documents\PROGRAMACION-1\busco\Views\Home\Index.cshtml"
           Write(registro.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 32 "C:\Users\USER\Documents\PROGRAMACION-1\busco\Views\Home\Index.cshtml"
           Write(registro.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 33 "C:\Users\USER\Documents\PROGRAMACION-1\busco\Views\Home\Index.cshtml"
           Write(registro.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 34 "C:\Users\USER\Documents\PROGRAMACION-1\busco\Views\Home\Index.cshtml"
           Write(registro.Celular);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 35 "C:\Users\USER\Documents\PROGRAMACION-1\busco\Views\Home\Index.cshtml"
           Write(registro.Lugar);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 36 "C:\Users\USER\Documents\PROGRAMACION-1\busco\Views\Home\Index.cshtml"
           Write(registro.NombreUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \n        </tr>\n");
#nullable restore
#line 38 "C:\Users\USER\Documents\PROGRAMACION-1\busco\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Registro>> Html { get; private set; }
    }
}
#pragma warning restore 1591
