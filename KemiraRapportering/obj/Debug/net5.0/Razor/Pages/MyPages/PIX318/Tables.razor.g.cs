#pragma checksum "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\Tables.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30727e3d69427b7dc28fc341cab9991b926bf7d2"
// <auto-generated/>
#pragma warning disable 1591
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
#line 1 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\Tables.razor"
using DataAccesLib.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\Tables.razor"
using DataAccesLib;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\Tables.razor"
using BlazorDateRangePicker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\Tables.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
    public partial class Tables : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\Tables.razor"
 if (recipes is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p><em>Loading....</em></p>");
#nullable restore
#line 11 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\Tables.razor"
}
else
{


#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table table-striped");
            __builder.OpenElement(4, "thead");
            __builder.OpenElement(5, "tr");
#nullable restore
#line 20 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\Tables.razor"
                 foreach(var Var in filter)
                    {
                       

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\Tables.razor"
                        if(!Var.sort)
                       {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "th");
#nullable restore
#line 23 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\Tables.razor"
__builder.AddContent(7, Var.variable);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 23 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\Tables.razor"
                                              }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\Tables.razor"
                                               
                        
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "tbody");
#nullable restore
#line 33 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\Tables.razor"
                 foreach (var recipe in RecipeRead.TableList)
            {
                    
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\Tables.razor"
                     if(recipe[31] == "False")
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "tr");
            __builder.SetKey(
#nullable restore
#line 38 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\Tables.razor"
                                  recipe

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 39 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\Tables.razor"
                             for(int n = 0; n < 30; n++)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\Tables.razor"
                                 if(!filter[n].sort)
                                {
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "td");
#nullable restore
#line 43 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\Tables.razor"
__builder.AddContent(12, recipe[n]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 43 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\Tables.razor"
                                                        }
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\Tables.razor"
                                 
                            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "th");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "type", "button");
            __builder.AddAttribute(16, "class", "btn btn-link");
            __builder.OpenElement(17, "span");
            __builder.AddAttribute(18, "class", "oi oi-pencil");
            __builder.AddAttribute(19, "aria-hidden", "true");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\Tables.razor"
                                                                                () => EnableEditing(true, recipe)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 57 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\Tables.razor"

                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\Tables.razor"
                         foreach(var Variable in TableEdit.Edits)
                        {

                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\Tables.razor"
                             if(!Variable.filter)
                            {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "td");
            __builder.OpenElement(22, "input");
            __builder.AddAttribute(23, "type", "text");
            __builder.AddAttribute(24, "class", "form-control");
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 68 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\Tables.razor"
                                                                                      Variable.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Variable.Name = __value, Variable.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 71 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\Tables.razor"
                                
                                
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\Tables.razor"
                             
                      
                            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "td");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "type", "button");
            __builder.AddAttribute(30, "class", "btn btn-link");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\Tables.razor"
                                                                         () => EnableEditing(false, recipe)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(32, "<i class=\"oi oi-trash\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "type", "button");
            __builder.AddAttribute(36, "class", "btn btn-link");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 86 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\Tables.razor"
                                                                         () => {BatchEdit(); EnableEditing(false, recipe);}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(38, "<i class=\"oi oi-check\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 90 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\Tables.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\Tables.razor"
                     
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 95 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\Tables.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 98 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\Tables.razor"
       
    public List<string> RecipeEdit;
    private List<RecipeModels> recipes;
    Queries query = new Queries();
    private int TableLen = 30;
    public DataFormatter format = new DataFormatter();
    public List<List<string>> TableList = new List<List<string>>();

    //public List<string> List = new List<string>();
    //public string Edit { get; set; }
    private int N = 0;

    EditRow TableEdit = new EditRow { Edits = new List<EditInstance>() };







    [Parameter]
    public filtering[] filter {get;set;}


    protected override async Task OnInitializedAsync()
    {

        TableUpdate();

    }

    private void EnableEditing(bool flag, List<string> batch)
    {
        if(flag)
        {
            batch[31] = "True";
            RecipeEdit = batch;
            flag = !flag;

            List<EditInstance> _EditInstance = new List<EditInstance>();

            for(int n = 0; n < 30; n++)
            {
                EditInstance _Entry = new EditInstance(){Name = batch[n], filter = filter[n].sort};

                TableEdit.Edits.Add(_Entry);
            }




        }


        StateHasChanged();

    }



    private async void BatchEdit()
    {

        List<string> batch = new List<string>();

        foreach(var variable in TableEdit.Edits)
        {
            batch.Add(variable.Name);
        }


        string sql = query.RecipeUpdate(batch);
        Debug.WriteLine(sql);
        await _db.EditRecipe(sql);

        sql = query.pix318();
        TableUpdate();

        batch.Clear();
        TableEdit.Edits.Clear();
    }

    public async void TableUpdate()
    {


        recipes = await _db.GetRecipes(Queries.sql);
        RecipeRead.Table = recipes;

        TableList = format.Pix318Model(recipes);
        RecipeRead.TableList = TableList;




        try
        {
            StateHasChanged();
        }
        catch
        {
            
        }StateHasChanged();
    }



    public void FilterUpdate()
    {
        for(int n = 0; n < TableLen-1; n++)
        {
            FilterModel.filter[n] = filter[n].sort;
        }
    }

    public void EditUpdate(List<string> batch)
    {

    }

    //private void CheckInput(KeyboardEventArgs keyEvent)
    //{
    //    if(keyEvent.Key == "Enter")
    //    {
    //        Debug.WriteLine(N);
    //        RecipeEdit.Insert(N, Edit);
    //    }

    //}

   

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRecipeData _db { get; set; }
    }
}
#pragma warning restore 1591
