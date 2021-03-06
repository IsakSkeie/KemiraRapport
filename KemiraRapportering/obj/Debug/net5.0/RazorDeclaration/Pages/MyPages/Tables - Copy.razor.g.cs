// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace KemiraRapportering.Pages.MyPages
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
#line 1 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\Tables - Copy.razor"
using DataAccesLib.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\Tables - Copy.razor"
using DataAccesLib;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\Tables - Copy.razor"
using BlazorDateRangePicker;

#line default
#line hidden
#nullable disable
    public partial class Tables___Copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 414 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\Tables - Copy.razor"
       
    public filtering[] filter = new filtering[30];
    private RecipeModels RecipeEdit = new RecipeModels();
    private List<RecipeModels> recipes;
    Queries query = new Queries();

    DateTimeOffset? StartDate { get; set; } = DateTime.Today.AddDays(-7);
    DateTimeOffset? EndDate { get; set; } = DateTime.Today.AddDays(0).AddTicks(-1);

    private int TableLen = 30;


    protected override async Task OnInitializedAsync()
    {


        for(int i = 0; i < TableLen; i++)
        {
            filter[i] = new filtering();
            filter[i].variable = FilterModel.StringFilter[i];
        }

        //Make this part of initialization
        filter[5].sort = true;
        filter[19].sort = true;
        filter[20].sort = true;
        filter[21].sort = true;
        filter[22].sort = true;
        filter[24].sort = true;
        FilterModel.filter[5] = true;
        FilterModel.filter[19] = true;
        FilterModel.filter[20] = true;
        FilterModel.filter[21] = true;
        FilterModel.filter[22] = true;
        FilterModel.filter[24] = true;




    }

    private void EnableEditing(bool flag, RecipeModels batch)
    {
        batch.edit = flag;
        if (flag)
        {
            RecipeEdit = batch;
        }

        StateHasChanged();

    }


    public void WriteCSV(filtering[] filter)
    {
        DataWrite ToCSV = new DataWrite(filter);
        TableUpdate();
        ToCSV.dataWriteToCSV();

    }

    private async void BatchEdit(RecipeModels batch)
    {
        string sql = query.RecipeUpdate(batch);
        await _db.EditRecipe(sql);

        sql = query.pix318();
        TableUpdate();
    }

    public async void TableUpdate()
    {

        recipes = await _db.GetRecipes(Queries.sql);
        RecipeRead.Table = recipes;
        //await InvokeAsync(StateHasChanged);
        StateHasChanged();
    }

    public void OnRangeSelect(DateRange range)
    {

        string sql = query.DateQuery(range);
        TableUpdate();
    }

    public void FilterUpdate()
    {
        for(int n = 0; n < TableLen-1; n++)
        {
            FilterModel.filter[n] = filter[n].sort;
        }
    }


    public async Task resetTable()
    {
        string sql = $"SELECT top ({ Queries.TableLen }) * FROM PIX318_ReseptData ORDER BY BatchNr DESC";
        recipes = await _db.GetRecipes(sql);
        RecipeRead.Table = recipes;
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRecipeData _db { get; set; }
    }
}
#pragma warning restore 1591
