#pragma checksum "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Cliente\Clientes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53ff7e0569a878b37bfa6aa4ff2435a81f11adfb"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Examen_Final.Pages.Cliente
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\_Imports.razor"
using Examen_Final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\_Imports.razor"
using Examen_Final.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Cliente\Clientes.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Cliente\Clientes.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Cliente\Clientes.razor"
using Examen_Final.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Cliente")]
    public partial class Clientes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 182 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Cliente\Clientes.razor"
       
    public string name_search;
    Usuario usuario1;
    List<Cliente> clientes = new List<Cliente>();
    //IFileListEntry image;
    //async Task HandleSelectImagen(IFileListEntry[] images )=> image =  images[0];

    protected override async Task OnInitializedAsync()
    {
        name_search = httpContextAccessor.HttpContext.User.Identity.Name;
        await Refresh();
    }
    private void Navegar(Cliente cliente)
    {
        NavigationManager.NavigateTo("/Cliente/" + cliente.ClienteID);
    }

    private async Task Refresh()
    {
        clientes = await service.GetClientesAsync();
        usuario1 = await service_usuario.getInformation(name_search);
    }

    public Cliente NewCliente { get; set; } = new Cliente();

    private async Task AddNewCliente()
    {
        await service.AddClienteAsync(NewCliente);
        NewCliente = new Cliente();
        await Refresh();
    }

    Cliente UpdateCliente = new Cliente();
    private void SetClienteForUpdate(Cliente cliente)
    {
        UpdateCliente = cliente;
    }

    private async Task EditarCliente()
    {
        await service.UpdateClienteAsync(UpdateCliente);
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServiceCliente service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
