#pragma checksum "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9f2887d3bcb9a32a26f68438e68385a36364694"
// <auto-generated/>
#pragma warning disable 1591
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
#line 3 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318.razor"
using DataAccesLib;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318.razor"
using DataAccesLib.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318.razor"
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
            __builder.AddMarkupContent(0, "<h1>Resept: PIX-318</h1>\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, "<h5 class=\"mx-5\">&nbsp;&nbsp;&nbsp; Dato &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Antall Rader</h5>");
#nullable restore
#line 15 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318.razor"
 if (recipes is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading....</em></p>");
#nullable restore
#line 18 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318.razor"
}
else
{


    

   


#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "btn-group");
            __builder.OpenComponent<BlazorDateRangePicker.DateRangePicker>(5);
            __builder.AddAttribute(6, "placeholder", "Velg Dato");
            __builder.AddAttribute(7, "OnRangeSelect", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorDateRangePicker.DateRange>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorDateRangePicker.DateRange>(this, 
#nullable restore
#line 28 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                                                                                                    OnRangeSelect

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "StartDate", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTimeOffset?>(
#nullable restore
#line 28 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                                                  StartDate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "StartDateChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.DateTimeOffset?>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTimeOffset?>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => StartDate = __value, StartDate))));
            __builder.AddAttribute(10, "EndDate", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTimeOffset?>(
#nullable restore
#line 28 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                                                                            EndDate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "EndDateChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.DateTimeOffset?>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTimeOffset?>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EndDate = __value, EndDate))));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "type", "number");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                      Queries.TableLen

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(15, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Queries.TableLen = __value, Queries.TableLen, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.OpenComponent<KemiraRapportering.Pages.MyPages.Tables>(16);
            __builder.CloseComponent();
#nullable restore
#line 41 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318.razor"
       


    private string value { get; set; }

    private string batch { get; set; }

    private int TableLen = Queries.TableLen;

    private List<RecipeModels> recipes;
    private RecipeModels RecipeEdit = new RecipeModels();





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
        


        recipes = await _db.GetRecipes(sql);


    }

    public async void TableUpdate()
    {

        recipes = await _db.GetRecipes(Queries.sql);
        RecipeRead.Table = recipes;
        //await InvokeAsync(StateHasChanged);
        StateHasChanged();
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

    private void EnableEditing(bool flag, RecipeModels batch)
    {
        batch.edit = flag;
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRecipeData _db { get; set; }
    }
}
#pragma warning restore 1591
