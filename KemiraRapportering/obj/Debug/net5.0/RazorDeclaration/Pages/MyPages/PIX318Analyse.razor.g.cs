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
#line 4 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318Analyse.razor"
using DataAccesLib;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318Analyse.razor"
using DataAccesLib.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318Analyse.razor"
using BlazorDateRangePicker;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/PIX318Analyse")]
    public partial class PIX318Analyse : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318Analyse.razor"
       


    private string value { get; set; }

    private string batch { get; set; }

    private int TableLen = Queries.TableLen;

    private List<RecipeModels> recipes;
    private RecipeModels RecipeEdit = new RecipeModels();

     public filtering[] filter = new filtering[10];




    DateTimeOffset? StartDate { get; set; } = DateTime.Today.AddDays(-7);
    DateTimeOffset? EndDate { get; set; } = DateTime.Today.AddDays(0).AddTicks(-1);


    Queries query = new Queries();


    public void OnRangeSelect(DateRange range)
    {

        string sql = query.DateQuery(range);
        TableUpdate();
    }




    protected override async Task OnInitializedAsync()
    {
        string sql = query.pix318();
        
        
        recipes = await _db.GetRecipes(sql);
        

        
        RecipeRead.Table = recipes;
        TableUpdate();
        
        //Shorten this down
        filter[0] = new filtering();
        filter[0].variable = FilterModel.StringFilter[0];

        filter[1] = new filtering();
        filter[1].variable = FilterModel.StringFilter[1];

        filter[2] = new filtering();
        filter[2].variable = FilterModel.StringFilter[3];

        filter[3] = new filtering();
        filter[3].variable = FilterModel.StringFilter[30];

        filter[4] = new filtering();
        filter[4].variable = FilterModel.StringFilter[31];

        filter[5] = new filtering();
        filter[5].variable = FilterModel.StringFilter[32];

        filter[6] = new filtering();
        filter[6].variable = FilterModel.StringFilter[33];

        filter[7] = new filtering();
        filter[7].variable = FilterModel.StringFilter[34];

        filter[8] = new filtering();
        filter[8].variable = FilterModel.StringFilter[35];

        filter[9] = new filtering();
        filter[9].variable = FilterModel.StringFilter[36];


        recipes = await _db.GetRecipes(sql);


    }

    public async void TableUpdate()
    {

        recipes = await _db.GetRecipes(Queries.sql);
        RecipeRead.Table = recipes;
        
        //StateHasChanged();
    }

    public async Task resetTable()
    {
        string sql = $"SELECT top ({ Queries.TableLen }) * FROM PIX318_ReseptData ORDER BY BatchNr DESC";
        recipes = await _db.GetRecipes(sql);
        RecipeRead.Table = recipes;
    }

    public void ResetDropDown()
    {
        StateHasChanged();
    }





    public void WriteCSV(filtering[] filter)
    {
        DataWrite ToCSV = new DataWrite(filter);

        ToCSV.dataWriteToCSV();

    }

   



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRecipeData _db { get; set; }
    }
}
#pragma warning restore 1591
