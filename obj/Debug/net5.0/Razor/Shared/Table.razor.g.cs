#pragma checksum "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8589ad63c9156b762653fee03affa844f052596b"
// <auto-generated/>
#pragma warning disable 1591
namespace KemiraRapportering.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\isak.skeie\source\repos\KemiraRapportering\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\isak.skeie\source\repos\KemiraRapportering\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\isak.skeie\source\repos\KemiraRapportering\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\isak.skeie\source\repos\KemiraRapportering\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\isak.skeie\source\repos\KemiraRapportering\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\isak.skeie\source\repos\KemiraRapportering\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\isak.skeie\source\repos\KemiraRapportering\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\isak.skeie\source\repos\KemiraRapportering\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\isak.skeie\source\repos\KemiraRapportering\_Imports.razor"
using KemiraRapportering.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\isak.skeie\source\repos\KemiraRapportering\_Imports.razor"
using KemiraRapportering;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\isak.skeie\source\repos\KemiraRapportering\_Imports.razor"
using KemiraRapportering.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\isak.skeie\source\repos\KemiraRapportering\_Imports.razor"
using DataAccesLib;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
using DataAccesLib.Models;

#line default
#line hidden
#nullable disable
    public partial class Table : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-striped");
            __builder.OpenElement(2, "thead");
            __builder.OpenElement(3, "tr");
#nullable restore
#line 6 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                 foreach(var Var in filter)
                    {
                       

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                        if(!Var.sort)
                       {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "th");
#nullable restore
#line 9 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
__builder.AddContent(5, Var.variable);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 9 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                                              }

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                                               
                        
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "tbody");
#nullable restore
#line 17 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
             foreach (var recipe in RecipeRead.Table)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "tr");
            __builder.SetKey(
#nullable restore
#line 19 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                          recipe

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 21 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                     if(!filter[0].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "td");
#nullable restore
#line 22 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
__builder.AddContent(10, recipe.BatchNr);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 22 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                                             }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                     if(!filter[1].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "td");
#nullable restore
#line 24 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
__builder.AddContent(12, recipe.Dato);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 24 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                                          }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                     if(!filter[2].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "td");
#nullable restore
#line 26 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
__builder.AddContent(14, recipe.SAP);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 26 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                                         }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                     if(!filter[3].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "td");
#nullable restore
#line 29 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
__builder.AddContent(16, recipe.ID);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                     if(!filter[4].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "td");
#nullable restore
#line 32 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
__builder.AddContent(18, recipe.Reaktor);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                                             }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                     if(!filter[5].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "td");
#nullable restore
#line 35 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
__builder.AddContent(20, recipe.SatsVolum);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 35 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                                               }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                     if(!filter[6].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "td");
#nullable restore
#line 38 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
__builder.AddContent(22, recipe.ForvFe);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                     if(!filter[7].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "td");
#nullable restore
#line 41 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
__builder.AddContent(24, recipe.OnsketFe);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 41 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                                              }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                     if(!filter[8].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "td");
#nullable restore
#line 44 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
__builder.AddContent(26, recipe.OnsketSyre);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 44 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                     if(!filter[9].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "td");
#nullable restore
#line 47 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
__builder.AddContent(28, recipe.OnsketFe2);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 47 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                                               }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                     if(!filter[10].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(29, "td");
#nullable restore
#line 50 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
__builder.AddContent(30, recipe.HCLType);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 50 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                                             }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                     if(!filter[11].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(31, "td");
#nullable restore
#line 53 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
__builder.AddContent(32, recipe.ForvDamp);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 53 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                                              }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                     if(!filter[12].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(33, "td");
#nullable restore
#line 56 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
__builder.AddContent(34, recipe.VannOverordnet);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 56 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                     if(!filter[13].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(35, "td");
#nullable restore
#line 59 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
__builder.AddContent(36, recipe.VarmtVann);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 59 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                                               }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                     if(!filter[14].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(37, "td");
#nullable restore
#line 62 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
__builder.AddContent(38, recipe.SpillVann);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 62 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                                               }

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                     if(!filter[15].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(39, "td");
#nullable restore
#line 65 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
__builder.AddContent(40, recipe.ScrubberVaeske);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 65 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                     if(!filter[16].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(41, "th");
#nullable restore
#line 68 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
__builder.AddContent(42, recipe.HCL);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 68 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                                         }

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                     if(!filter[17].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(43, "th");
#nullable restore
#line 71 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
__builder.AddContent(44, recipe.Jernsulfat);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 71 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                     if(!filter[18].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(45, "th");
#nullable restore
#line 74 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
__builder.AddContent(46, recipe.Temp);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 74 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                                          }

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                     if(!filter[19].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(47, "th");
#nullable restore
#line 77 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
__builder.AddContent(48, recipe.Modningstid);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 77 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                                                 }

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                     if(!filter[20].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(49, "th");
#nullable restore
#line 80 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
__builder.AddContent(50, recipe.DampVentil);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 80 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                     if(!filter[21].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(51, "th");
#nullable restore
#line 83 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
__builder.AddContent(52, recipe.Etterspyling);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 83 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                                                  }

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                     if(!filter[22].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(53, "th");
#nullable restore
#line 86 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
__builder.AddContent(54, recipe.O2Trykk);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 86 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                                             }

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                     if(!filter[23].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(55, "th");
#nullable restore
#line 89 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
__builder.AddContent(56, recipe.O2Reaksjonstid);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 89 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                     if(!filter[24].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(57, "th");
#nullable restore
#line 92 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
__builder.AddContent(58, recipe.DeltaTemp);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 92 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                                               }

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                     if(!filter[25].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(59, "th");
#nullable restore
#line 95 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
__builder.AddContent(60, recipe.AnalysertFe3);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 95 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                                                  }

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                     if(!filter[26].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(61, "th");
#nullable restore
#line 98 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
__builder.AddContent(62, recipe.AnalysertFeTot);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 98 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                     if(!filter[27].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(63, "th");
#nullable restore
#line 101 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
__builder.AddContent(64, recipe.VannSluttJustering);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 101 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                     if(!filter[28].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(65, "th");
#nullable restore
#line 104 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
__builder.AddContent(66, recipe.VirkeligMVann);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 104 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                                                   }

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                     if(!filter[29].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(67, "th");
#nullable restore
#line 107 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
__builder.AddContent(68, recipe.TotTilLager);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 107 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
                                                 }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(69, "<th><button type=\"button\" class=\"btn btn-link\"><span class=\"oi oi-pencil\" aria-hidden=\"true\"></span></button></th>");
            __builder.CloseElement();
#nullable restore
#line 120 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 124 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Shared\Table.razor"
       
    public  List<string> RecipeVariables = new List<string>()
        {
        "Batch",
        "Dato",
        "SAP",
        "ID",
        "Reaktor",
        "Satsvolum",
        "Forventet Fe",
        "Onsket Fe",
        "Onsket Syre",
        "Onsket Fe2",
        "HCL type",
        "Forv. Damp",
        "Vann Overordnet",
        "Varmt Vann",
        "Spill Vann",
        "Scrubber Væske",
        "HCL",
        "Jernsulfat",
        "Temp",
        "Modningstid",
        "Damp Ventil",
        "Etter spyling",
        "O2 Trykk",
        "O2 Reaksjonstid",
        "DeltaTemp",
        "Analysert Fe3",
        "Analysert FeTot",
        "VannSlutt justering",
        "Virkelig Mengde Vann",
        "Tot til lager"
    };

    private filtering[] filter = new filtering[30];
 
    
        protected override async Task OnInitializedAsync()
    {
        
        for(int i = 0; i < 30; i++)
        {
            filter[i] = new filtering();
            filter[i].variable = RecipeVariables[i];
        }

        //Make this part of initialization
        filter[5].sort = true;
        filter[19].sort = true;
        filter[20].sort = true;
        filter[21].sort = true;
        filter[22].sort = true;
        filter[24].sort = true;

        

    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
