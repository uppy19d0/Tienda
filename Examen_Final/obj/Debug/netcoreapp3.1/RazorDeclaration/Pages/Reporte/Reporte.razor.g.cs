// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Examen_Final.Pages.Reporte
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
#line 11 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\_Imports.razor"
using Microsoft.AspNetCore.Identity;

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
#line 3 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
using Examen_Final.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Reporte")]
    public partial class Reporte : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 257 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
      

    DateTime date = DateTime.Now;
    string selectorReporte;


    //Reportes
    List<Producto> productos = new List<Producto>();
    List<Cliente> clientes = new List<Cliente>();
    List<Factura> facturas = new List<Factura>();


    protected override async Task OnInitializedAsync()
    {
        await Refresh();
    }

    private async Task Refresh()
    {
        productos = await serviceProducto.GetProductoAsync();
        clientes = await serviceCliente.GetClientesAsync();
        facturas = await ServiceFactura.GetFacturaAsync();
    }


    //Módulo de impresion
    public async Task Imprimir()
    {

        await JSRuntime.InvokeVoidAsync("imprimir_reporte");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServiceCliente serviceCliente { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServiceFactura ServiceFactura { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServiceProducto serviceProducto { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigate { get; set; }
    }
}
#pragma warning restore 1591
