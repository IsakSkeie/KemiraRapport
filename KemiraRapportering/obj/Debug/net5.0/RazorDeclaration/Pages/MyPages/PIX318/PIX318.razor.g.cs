// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace KemiraRapportering.Pages.MyPages.PIX318
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\_Imports.razor"
using KemiraRapportering.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\_Imports.razor"
using KemiraRapportering;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\_Imports.razor"
using KemiraRapportering.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\PIX318.razor"
using DataAccesLib;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\PIX318.razor"
using DataAccesLib.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\PIX318.razor"
using BlazorDateRangePicker;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/PIX-318")]
    public partial class PIX318 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\PIX318.razor"
       

    private int TableLen = Queries.TableLen;
    private int ParameterLen = 30;
    private List<RecipeModels> recipes;
    private RecipeModels RecipeEdit = new RecipeModels();
    public filtering[] filter = new filtering[30];



    Queries query = new Queries();




    protected override async Task OnInitializedAsync()
    {
        string sql = query.pix318();
        for(int i = 0; i < ParameterLen; i++)
        {
            filter[i] = new filtering();
            filter[i].variable = FilterModel.StringFilter[i];
        }

        //Make this part of initialization
        filter[5].sort = true;
        filter[9].sort = true;
        filter[18].sort = true;
        filter[19].sort = true;
        filter[20].sort = true;
        filter[21].sort = true;
        filter[22].sort = true;
        filter[24].sort = true;
        filter[25].sort = true;
        filter[26].sort = true;


        //FilterModel.filter[5] = true;
        //FilterModel.filter[19] = true;
        //FilterModel.filter[20] = true;
        //FilterModel.filter[21] = true;
        //FilterModel.filter[22] = true;
        //FilterModel.filter[24] = true;

        recipes = await _db.GetRecipes(sql);

        RecipeRead.Table = recipes;
        TableUpdate();

    }

    public async void TableUpdate()
    {

        recipes = await _db.GetRecipes(Queries.sql);
        RecipeRead.Table = recipes;
        //await InvokeAsync(StateHasChanged);
        try
        {
            StateHasChanged();
        }
        catch
        {
            
        }

    }

    private void UpdateFilter(filtering[] _filter)
    {
        filter = _filter;
    }


    private void UpdateDateRange(string sql)
    {
        TableUpdate();
    }

    private void UpdateResetTable(string sql)
    {
        TableUpdate();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRecipeData _db { get; set; }
    }
}
#pragma warning restore 1591
