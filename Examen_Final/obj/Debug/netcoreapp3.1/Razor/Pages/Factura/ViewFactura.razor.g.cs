<<<<<<< HEAD
#pragma checksum "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Factura\ViewFactura.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03135c473cec8582e261c887c85f91e5192be5d3"
=======
#pragma checksum "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Factura\ViewFactura.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e6520d7451738750b5cd472d5b0d46c0dcf5ac0"
>>>>>>> 220257892b6bf2ea4286b96d57ebe21534c17789
// <auto-generated/>
#pragma warning disable 1591
namespace Examen_Final.Pages.Factura
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\_Imports.razor"
using Examen_Final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\_Imports.razor"
using Examen_Final.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Factura\ViewFactura.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Factura\ViewFactura.razor"
using Examen_Final.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Factura/{Id:int}")]
    public partial class ViewFactura : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
<<<<<<< HEAD
                __builder2.OpenElement(2, "div");
                __builder2.AddAttribute(3, "class", "container");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "id", "header");
                __builder2.AddAttribute(6, "class", "row");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col-sm-10");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "cv-title");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "row");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "col-sm-7");
                __builder2.AddMarkupContent(15, "<b>Nombre del Cliente</b>\r\n                                ");
                __builder2.OpenElement(16, "h1");
                __builder2.AddAttribute(17, "class", "mt-3");
                __builder2.AddContent(18, 
#nullable restore
#line 35 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Factura\ViewFactura.razor"
=======
                __builder2.AddMarkupContent(2, "\r\n        \r\n        ");
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "d-flex flex-row-reverse");
                __builder2.AddMarkupContent(5, "\r\n            ");
                __builder2.OpenElement(6, "button");
                __builder2.AddAttribute(7, "type", "button");
                __builder2.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Factura\ViewFactura.razor"
                                            Imprimir

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "class", "btn btn-success  btn-lg");
                __builder2.AddAttribute(10, "data-toggle", "modal");
                __builder2.AddAttribute(11, "data-target", "#exampleModalLong");
                __builder2.AddMarkupContent(12, "\r\n                <span class=\"oi oi-print\" aria-hidden=\"true\"></span> Imprimir factura\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "container");
                __builder2.AddAttribute(17, "id", "Imprimir_factura");
                __builder2.AddMarkupContent(18, "\r\n            ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "id", "header");
                __builder2.AddAttribute(21, "class", "row");
                __builder2.AddMarkupContent(22, "\r\n\r\n                ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "col-sm-10");
                __builder2.AddMarkupContent(25, "\r\n                    ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "cv-title");
                __builder2.AddMarkupContent(28, "\r\n                        ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "row");
                __builder2.AddMarkupContent(31, "\r\n                            ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "col-sm-7");
                __builder2.AddMarkupContent(34, "\r\n                                ");
                __builder2.AddMarkupContent(35, "<b>Nombre del Cliente</b>\r\n                                ");
                __builder2.OpenElement(36, "h1");
                __builder2.AddAttribute(37, "class", "mt-3");
                __builder2.AddContent(38, 
#nullable restore
#line 41 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Factura\ViewFactura.razor"
>>>>>>> 220257892b6bf2ea4286b96d57ebe21534c17789
                                                  factura.Cliente.Nombres

#line default
#line hidden
#nullable disable
                );
<<<<<<< HEAD
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n\r\n            ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "row bg-light");
                __builder2.OpenElement(22, "table");
                __builder2.AddAttribute(23, "class", "table table-bordered");
                __builder2.AddMarkupContent(24, "<thead class=\"thead-dark\"><tr><th>Nombre</th>\r\n                            <th>Descripción</th>\r\n                            <th>Precio</th>\r\n                            <th>Cantidad</th></tr></thead>\r\n                    ");
                __builder2.OpenElement(25, "tbody");
#nullable restore
#line 53 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Factura\ViewFactura.razor"
=======
                __builder2.AddContent(39, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n\r\n            ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "row bg-light");
                __builder2.AddMarkupContent(48, "\r\n                ");
                __builder2.OpenElement(49, "table");
                __builder2.AddAttribute(50, "class", "table table-bordered");
                __builder2.AddMarkupContent(51, "\r\n                    ");
                __builder2.AddMarkupContent(52, @"<thead class=""thead-dark"">
                        <tr>
                            <th>Nombre</th>
                            <th>Descripción</th>
                            <th>Precio</th>
                            <th>Cantidad</th>
                        </tr>
                    </thead>
                    ");
                __builder2.OpenElement(53, "tbody");
                __builder2.AddMarkupContent(54, "\r\n");
#nullable restore
#line 59 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Factura\ViewFactura.razor"
>>>>>>> 220257892b6bf2ea4286b96d57ebe21534c17789
                         if (factura.facturas_detalle.Any())
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 55 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Factura\ViewFactura.razor"
=======
#line 61 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Factura\ViewFactura.razor"
>>>>>>> 220257892b6bf2ea4286b96d57ebe21534c17789
                             foreach (var producto in factura.facturas_detalle)
                            {

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
                __builder2.OpenElement(26, "tr");
                __builder2.OpenElement(27, "td");
                __builder2.AddContent(28, 
#nullable restore
#line 58 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Factura\ViewFactura.razor"
=======
                __builder2.AddContent(55, "                                ");
                __builder2.OpenElement(56, "tr");
                __builder2.AddMarkupContent(57, "\r\n                                    ");
                __builder2.OpenElement(58, "td");
                __builder2.AddContent(59, 
#nullable restore
#line 64 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Factura\ViewFactura.razor"
>>>>>>> 220257892b6bf2ea4286b96d57ebe21534c17789
                                         producto.producto.Nombre

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
<<<<<<< HEAD
                __builder2.AddMarkupContent(29, "\r\n                                    ");
                __builder2.OpenElement(30, "td");
                __builder2.AddContent(31, 
#nullable restore
#line 59 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Factura\ViewFactura.razor"
=======
                __builder2.AddMarkupContent(60, "\r\n                                    ");
                __builder2.OpenElement(61, "td");
                __builder2.AddContent(62, 
#nullable restore
#line 65 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Factura\ViewFactura.razor"
>>>>>>> 220257892b6bf2ea4286b96d57ebe21534c17789
                                         producto.producto.Descripcion

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
<<<<<<< HEAD
                __builder2.AddMarkupContent(32, "\r\n                                    ");
                __builder2.OpenElement(33, "td");
                __builder2.AddContent(34, 
#nullable restore
#line 60 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Factura\ViewFactura.razor"
=======
                __builder2.AddMarkupContent(63, "\r\n                                    ");
                __builder2.OpenElement(64, "td");
                __builder2.AddContent(65, 
#nullable restore
#line 66 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Factura\ViewFactura.razor"
>>>>>>> 220257892b6bf2ea4286b96d57ebe21534c17789
                                         producto.producto.Precio

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
<<<<<<< HEAD
                __builder2.AddMarkupContent(35, "\r\n                                    ");
                __builder2.OpenElement(36, "td");
                __builder2.AddContent(37, 
#nullable restore
#line 61 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Factura\ViewFactura.razor"
=======
                __builder2.AddMarkupContent(66, "\r\n                                    ");
                __builder2.OpenElement(67, "td");
                __builder2.AddContent(68, 
#nullable restore
#line 67 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Factura\ViewFactura.razor"
>>>>>>> 220257892b6bf2ea4286b96d57ebe21534c17789
                                         producto.Cantidad

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
<<<<<<< HEAD
                __builder2.CloseElement();
#nullable restore
#line 63 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Factura\ViewFactura.razor"
=======
                __builder2.AddMarkupContent(69, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n");
#nullable restore
#line 69 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Factura\ViewFactura.razor"
>>>>>>> 220257892b6bf2ea4286b96d57ebe21534c17789
                            }

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 63 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Factura\ViewFactura.razor"
=======
#line 69 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Factura\ViewFactura.razor"
>>>>>>> 220257892b6bf2ea4286b96d57ebe21534c17789
                             
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
                __builder2.AddMarkupContent(38, "<tr><td colspan=\"6\"><strong>No hay producto creado</strong></td></tr>");
#nullable restore
#line 68 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Factura\ViewFactura.razor"
=======
                __builder2.AddContent(71, "                            ");
                __builder2.AddMarkupContent(72, "<tr><td colspan=\"6\"><strong>No hay producto creado</strong></td></tr>\r\n");
#nullable restore
#line 74 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Factura\ViewFactura.razor"
>>>>>>> 220257892b6bf2ea4286b96d57ebe21534c17789
                        }

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n                ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "text-right");
                __builder2.OpenElement(42, "div");
                __builder2.OpenElement(43, "p");
                __builder2.AddAttribute(44, "class", "h3 text-secondary");
                __builder2.AddMarkupContent(45, "<b>  Subtotal: </b>");
                __builder2.OpenElement(46, "span");
                __builder2.AddContent(47, 
#nullable restore
#line 73 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Factura\ViewFactura.razor"
=======
                __builder2.AddContent(73, "                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n                ");
                __builder2.OpenElement(76, "div");
                __builder2.AddAttribute(77, "class", "text-right");
                __builder2.AddMarkupContent(78, "\r\n                    ");
                __builder2.OpenElement(79, "div");
                __builder2.AddMarkupContent(80, "\r\n                        ");
                __builder2.OpenElement(81, "p");
                __builder2.AddAttribute(82, "class", "h3 text-secondary");
                __builder2.AddMarkupContent(83, "<b>  Subtotal: </b>");
                __builder2.OpenElement(84, "span");
                __builder2.AddContent(85, " ");
                __builder2.AddContent(86, 
#nullable restore
#line 79 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Factura\ViewFactura.razor"
>>>>>>> 220257892b6bf2ea4286b96d57ebe21534c17789
                                                                                factura.facturas_detalle.Sum(p => p.producto.Precio * p.Cantidad)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
<<<<<<< HEAD
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                    <hr>\r\n                    ");
                __builder2.OpenElement(49, "div");
                __builder2.OpenElement(50, "p");
                __builder2.AddAttribute(51, "class", "h3 text-secondary");
                __builder2.AddMarkupContent(52, "<b> ITBIS: </b>");
                __builder2.OpenElement(53, "span");
                __builder2.AddContent(54, 
#nullable restore
#line 77 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Factura\ViewFactura.razor"
=======
                __builder2.AddMarkupContent(87, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n                    <hr>\r\n                    ");
                __builder2.OpenElement(89, "div");
                __builder2.AddMarkupContent(90, "\r\n                        ");
                __builder2.OpenElement(91, "p");
                __builder2.AddAttribute(92, "class", "h3 text-secondary");
                __builder2.AddContent(93, " ");
                __builder2.AddMarkupContent(94, "<b> ITBIS: </b>");
                __builder2.OpenElement(95, "span");
                __builder2.AddContent(96, " ");
                __builder2.AddContent(97, 
#nullable restore
#line 83 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Factura\ViewFactura.razor"
>>>>>>> 220257892b6bf2ea4286b96d57ebe21534c17789
                                                                             factura.facturas_detalle.Sum(p => p.producto.Precio * p.Cantidad * 0.18)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
<<<<<<< HEAD
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                    <hr>\r\n                    ");
                __builder2.OpenElement(56, "div");
                __builder2.OpenElement(57, "p");
                __builder2.AddAttribute(58, "class", "h3 text-secondary");
                __builder2.AddMarkupContent(59, "<b>  Total:</b> ");
                __builder2.OpenElement(60, "span");
                __builder2.AddContent(61, 
#nullable restore
#line 81 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Factura\ViewFactura.razor"
=======
                __builder2.AddMarkupContent(98, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\r\n                    <hr>\r\n                    ");
                __builder2.OpenElement(100, "div");
                __builder2.AddMarkupContent(101, "\r\n                        ");
                __builder2.OpenElement(102, "p");
                __builder2.AddAttribute(103, "class", "h3 text-secondary");
                __builder2.AddMarkupContent(104, "<b>  Total:</b> ");
                __builder2.OpenElement(105, "span");
                __builder2.AddContent(106, " ");
                __builder2.AddContent(107, 
#nullable restore
#line 87 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Factura\ViewFactura.razor"
>>>>>>> 220257892b6bf2ea4286b96d57ebe21534c17789
                                                                             factura.facturas_detalle.Sum(p => p.producto.Precio * p.Cantidad + factura.facturas_detalle.Sum(p => p.producto.Precio * p.Cantidad * 0.18))

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
<<<<<<< HEAD
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(62, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(63, "<center><h1>Necesitas estar logeado</h1>\r\n            <br><br>\r\n            <p>\r\n                Necesita entrar con tu  usuario para poder visualizar los clientes\r\n            </p></center>");
=======
                __builder2.AddMarkupContent(108, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\r\n\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(111, "\r\n\r\n\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\r\n    ");
            }
            ));
            __builder.AddAttribute(113, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(114, "\r\n        ");
                __builder2.AddMarkupContent(115, "<center>\r\n            <h1>Necesitas estar logeado</h1>\r\n            <br><br>\r\n            <p>\r\n                Necesita entrar con tu  usuario para poder visualizar los clientes\r\n            </p>\r\n        </center>\r\n\r\n    ");
>>>>>>> 220257892b6bf2ea4286b96d57ebe21534c17789
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
<<<<<<< HEAD
#line 123 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Factura\ViewFactura.razor"
=======
#line 130 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Factura\ViewFactura.razor"
>>>>>>> 220257892b6bf2ea4286b96d57ebe21534c17789
      
    Factura factura = new Factura();
    [Parameter]
    public int Id { get; set; }


    private async Task RefreshFactura()
    {
        factura = await service.GetFacturaSingleAsync(Id);
    }
    List<Factura> facturas = new List<Factura>();
    List<Cliente> clientes = new List<Cliente>();
    List<Producto> productos = new List<Producto>();
    

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 136 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Factura\ViewFactura.razor"
=======
#line 143 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Factura\ViewFactura.razor"
>>>>>>> 220257892b6bf2ea4286b96d57ebe21534c17789
                                


    private void UpdateHeading(MouseEventArgs e)
    {

    }
    protected override async Task OnInitializedAsync()
    {
        await RefreshFactura();
        await Refresh();
    }

    private async Task Refresh()
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 152 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Factura\ViewFactura.razor"
=======
#line 159 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Factura\ViewFactura.razor"
>>>>>>> 220257892b6bf2ea4286b96d57ebe21534c17789
                                                                    
        facturas = await service.GetFacturaAsync();
        

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 154 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Factura\ViewFactura.razor"
=======
#line 161 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Factura\ViewFactura.razor"
>>>>>>> 220257892b6bf2ea4286b96d57ebe21534c17789
                                                                           
    }

    //Módulo de impresion
    public async Task Imprimir()
    {

        await JSRuntime.InvokeVoidAsync("imprimir_factura");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor httpContextAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<Usuario> UserManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignInManager<Usuario> SignInManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServiceCliente service_cliente { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServiceFactura service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServiceProducto service_producto { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServiceUsuario service_usuario { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
