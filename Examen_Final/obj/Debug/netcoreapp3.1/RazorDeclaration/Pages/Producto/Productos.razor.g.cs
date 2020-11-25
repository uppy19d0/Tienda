// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Examen_Final.Pages.Producto
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\luis_\source\repos\Examen_Final\Examen_Final\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\luis_\source\repos\Examen_Final\Examen_Final\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\luis_\source\repos\Examen_Final\Examen_Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\luis_\source\repos\Examen_Final\Examen_Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\luis_\source\repos\Examen_Final\Examen_Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\luis_\source\repos\Examen_Final\Examen_Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\luis_\source\repos\Examen_Final\Examen_Final\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\luis_\source\repos\Examen_Final\Examen_Final\_Imports.razor"
using Examen_Final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\luis_\source\repos\Examen_Final\Examen_Final\_Imports.razor"
using Examen_Final.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\luis_\source\repos\Examen_Final\Examen_Final\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\luis_\source\repos\Examen_Final\Examen_Final\Pages\Producto\Productos.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\luis_\source\repos\Examen_Final\Examen_Final\Pages\Producto\Productos.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\luis_\source\repos\Examen_Final\Examen_Final\Pages\Producto\Productos.razor"
using Examen_Final.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Producto")]
    public partial class Productos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 187 "c:\Users\luis_\source\repos\Examen_Final\Examen_Final\Pages\Producto\Productos.razor"
       
    public string name_search;
    Usuario usuario1;
    List<Producto> productos = new List<Producto>();
    IFileListEntry image;
     async Task HandleSelectImagen(IFileListEntry[] images ){
        image = images.FirstOrDefault();

    }
    protected override async Task OnInitializedAsync()
    {
        name_search = httpContextAccessor.HttpContext.User.Identity.Name;
        await Refresh();
    }
      private void Navegar(Producto producto)
    {
        NavigationManager.NavigateTo("/Producto/" + producto.ProductoID);
    }

    private async Task Refresh()
    {
        productos = await service.GetProductoAsync();
        usuario1 = await service_usuario.getInformation(name_search);
    }


    public Producto NewProducto { get; set; } = new Producto();
    private async Task AddNewProducto()
    {
        await service.AddProductoAsync(NewProducto,image);
        NewProducto = new Producto();
        await Refresh();
    }
    Producto ProductoUpdate = new Producto();
    private void SetProductoForUpdate(Producto producto)
    {
        ProductoUpdate = producto;
    }
    private async Task UpdateProductoData()
    {
        await service.UpdateProductoAsync(ProductoUpdate);
        await Refresh();
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor httpContextAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<Usuario> UserManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignInManager<Usuario> SignInManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServiceUsuario service_usuario { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServiceProducto service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
