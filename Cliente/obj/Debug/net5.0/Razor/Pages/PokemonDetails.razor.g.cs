#pragma checksum "D:\Proyectos\Pokedex_Blazor\Cliente\Pages\PokemonDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "240d5b40580360b42d9c6ec3dd5c7d0d0796ad56"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/pokeDetails/{name}")]
    public partial class PokemonDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "D:\Proyectos\Pokedex_Blazor\Cliente\Pages\PokemonDetails.razor"
 if (Pokemon == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p><em>Loading...</em></p>");
#nullable restore
#line 7 "D:\Proyectos\Pokedex_Blazor\Cliente\Pages\PokemonDetails.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row text-center");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-sm-6");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "mt-2");
            __builder.OpenElement(7, "h1");
            __builder.AddContent(8, 
#nullable restore
#line 13 "D:\Proyectos\Pokedex_Blazor\Cliente\Pages\PokemonDetails.razor"
                     Pokemon.Name.Substring(0,1).ToUpper()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(9, 
#nullable restore
#line 13 "D:\Proyectos\Pokedex_Blazor\Cliente\Pages\PokemonDetails.razor"
                                                           Pokemon.Name.Substring(1, Pokemon.Name.Length -1)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 14 "D:\Proyectos\Pokedex_Blazor\Cliente\Pages\PokemonDetails.razor"
                 foreach (var poke in Pokemon.Types)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "span");
            __builder.AddAttribute(11, "class", "badge" + " border" + " rounded-pill" + " bg-" + (
#nullable restore
#line 16 "D:\Proyectos\Pokedex_Blazor\Cliente\Pages\PokemonDetails.razor"
                                                               poke.PokemonType.Name

#line default
#line hidden
#nullable disable
            ) + " text-center");
            __builder.AddAttribute(12, "style", "font-size: medium;");
            __builder.AddContent(13, 
#nullable restore
#line 17 "D:\Proyectos\Pokedex_Blazor\Cliente\Pages\PokemonDetails.razor"
                          poke.PokemonType.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 19 "D:\Proyectos\Pokedex_Blazor\Cliente\Pages\PokemonDetails.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n            ");
            __builder.OpenElement(15, "ul");
            __builder.AddAttribute(16, "class", "list-group-item mt-4 text-center");
            __builder.AddAttribute(17, "style", "width: 20rem;");
            __builder.OpenElement(18, "li");
            __builder.AddAttribute(19, "class", "list-group-item bg-transparent");
            __builder.AddContent(20, "Id #");
            __builder.OpenElement(21, "b");
            __builder.AddAttribute(22, "class", "float-end");
            __builder.AddContent(23, 
#nullable restore
#line 23 "D:\Proyectos\Pokedex_Blazor\Cliente\Pages\PokemonDetails.razor"
                                                                                      Pokemon.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "li");
            __builder.AddAttribute(26, "class", "list-group-item bg-transparent");
            __builder.AddContent(27, "Expirence");
            __builder.OpenElement(28, "b");
            __builder.AddAttribute(29, "class", "float-end");
            __builder.AddContent(30, 
#nullable restore
#line 24 "D:\Proyectos\Pokedex_Blazor\Cliente\Pages\PokemonDetails.razor"
                                                                                           Pokemon.Experience

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "li");
            __builder.AddAttribute(33, "class", "list-group-item bg-transparent");
            __builder.AddContent(34, "Weight");
            __builder.OpenElement(35, "b");
            __builder.AddAttribute(36, "class", "float-end");
            __builder.AddContent(37, 
#nullable restore
#line 25 "D:\Proyectos\Pokedex_Blazor\Cliente\Pages\PokemonDetails.razor"
                                                                                        Pokemon.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.OpenElement(39, "li");
            __builder.AddAttribute(40, "class", "list-group-item bg-transparent");
            __builder.AddContent(41, "Height");
            __builder.OpenElement(42, "b");
            __builder.AddAttribute(43, "class", "float-end");
            __builder.AddContent(44, 
#nullable restore
#line 26 "D:\Proyectos\Pokedex_Blazor\Cliente\Pages\PokemonDetails.razor"
                                                                                        Pokemon.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n\r\n        ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "col-sm-6");
            __builder.OpenElement(48, "img");
            __builder.AddAttribute(49, "src", "https://img.pokemon.net/artwork/large/" + (
#nullable restore
#line 31 "D:\Proyectos\Pokedex_Blazor\Cliente\Pages\PokemonDetails.razor"
                                                              Pokemon.Name

#line default
#line hidden
#nullable disable
            ) + ".jpg");
            __builder.AddAttribute(50, "alt", 
#nullable restore
#line 31 "D:\Proyectos\Pokedex_Blazor\Cliente\Pages\PokemonDetails.razor"
                                                                                       Pokemon.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(51, "class", "img-fluid d-block mx-auto");
            __builder.AddAttribute(52, "style", "width: 300px;");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "D:\Proyectos\Pokedex_Blazor\Cliente\Pages\PokemonDetails.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "D:\Proyectos\Pokedex_Blazor\Cliente\Pages\PokemonDetails.razor"
       
    [Parameter]
    public string name { get; set; }

    public Pokemon Pokemon { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Pokemon = await PokeApiClient.GetPokemon(name);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPokeApiClient PokeApiClient { get; set; }
    }
}
#pragma warning restore 1591
