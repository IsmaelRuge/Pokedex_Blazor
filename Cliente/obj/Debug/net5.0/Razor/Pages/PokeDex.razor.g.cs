#pragma checksum "D:\Proyectos\Pokedex_Blazor\Cliente\Pages\PokeDex.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2c467330b26086b5a01c9d0e71659221932eac7"
// <auto-generated/>
#pragma warning disable 1591
namespace Cliente.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Proyectos\Pokedex_Blazor\Cliente\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Proyectos\Pokedex_Blazor\Cliente\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Proyectos\Pokedex_Blazor\Cliente\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Proyectos\Pokedex_Blazor\Cliente\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Proyectos\Pokedex_Blazor\Cliente\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Proyectos\Pokedex_Blazor\Cliente\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Proyectos\Pokedex_Blazor\Cliente\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Proyectos\Pokedex_Blazor\Cliente\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Proyectos\Pokedex_Blazor\Cliente\_Imports.razor"
using Cliente;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Proyectos\Pokedex_Blazor\Cliente\_Imports.razor"
using Cliente.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Proyectos\Pokedex_Blazor\Cliente\_Imports.razor"
using Pokedex_Blazor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Proyectos\Pokedex_Blazor\Cliente\_Imports.razor"
using Pokedex_Blazor.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class PokeDex : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>PokeDex</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col");
            __builder.OpenComponent<Cliente.Pages.Pagination>(6);
            __builder.AddAttribute(7, "MetaData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Pokedex_Blazor.Models.PaginationMetaData>(
#nullable restore
#line 10 "D:\Proyectos\Pokedex_Blazor\Cliente\Pages\PokeDex.razor"
                                  paginationMetaData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "Spread", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 10 "D:\Proyectos\Pokedex_Blazor\Cliente\Pages\PokeDex.razor"
                                                              5

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 10 "D:\Proyectos\Pokedex_Blazor\Cliente\Pages\PokeDex.razor"
                                                                               SelectedPages

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n    ");
            __builder.OpenComponent<Cliente.Pages.PokemonGrid>(11);
            __builder.AddAttribute(12, "Pokemons", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Pokedex_Blazor.Models.Pokemon>>(
#nullable restore
#line 14 "D:\Proyectos\Pokedex_Blazor\Cliente\Pages\PokeDex.razor"
                           Pokemons

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "NumberOfRows", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 14 "D:\Proyectos\Pokedex_Blazor\Cliente\Pages\PokeDex.razor"
                                                   5

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "D:\Proyectos\Pokedex_Blazor\Cliente\Pages\PokeDex.razor"
       
    public IEnumerable<Pokemon> Pokemons { get; set; }

    PaginationMetaData paginationMetaData = new PaginationMetaData();

    PaginationParameters paginationParameters = new PaginationParameters();

    protected override async Task OnInitializedAsync()
    {
        var result = await PokeApiClient.GetAllPokemons(paginationParameters);

        var pokemons = new List<Pokemon>();

        foreach (var poke in result.Pokemons)
        {
            pokemons.Add(await PokeApiClient.GetPokemon(poke.Name));
        }

        Pokemons = pokemons;

        paginationMetaData.TotalCount = result.Count;
        paginationMetaData.TotalPages = paginationMetaData.TotalCount / paginationParameters.PageSize;
    }

    private async Task SelectedPages(int page)
    {
        paginationParameters.PageNumber = page;

        await GetPokemons();
    }

    private async Task GetPokemons()
    {
        var result = await PokeApiClient.GetAllPokemons(paginationParameters);

        var pokemons = new List<Pokemon>();

        foreach (var poke in result.Pokemons)
        {
            pokemons.Add(await PokeApiClient.GetPokemon(poke.Name));
        }

        Pokemons = pokemons;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPokeApiClient PokeApiClient { get; set; }
    }
}
#pragma warning restore 1591
