using DataAccesLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLib
{
    public class DataFormatter
    {
        public List<List<string>> Pix318Model(List<RecipeModels> recipes)
        {
            List<List<string>> FormattedList = new List<List<string>>();
            List<string> TempList = new List<string>();
          
            foreach (RecipeModels recipe in recipes)
            {
                TempList.Add(recipe.BatchNr.ToString());
                TempList.Add(recipe.Dato);
                TempList.Add(recipe.SAP.ToString());
                TempList.Add(recipe.ID);
                TempList.Add(recipe.Reaktor.ToString());
                TempList.Add(recipe.SatsVolum.ToString());
                TempList.Add(recipe.ForvFe.ToString());
                TempList.Add(recipe.OnsketFe.ToString());
                TempList.Add(recipe.OnsketSyre.ToString());
                TempList.Add(recipe.OnsketFe2.ToString());
                TempList.Add(recipe.HCLType.ToString());
                TempList.Add(recipe.ForvDamp.ToString());
                TempList.Add(recipe.VannOverordnet.ToString());
                TempList.Add(recipe.VarmtVann.ToString());
                TempList.Add(recipe.SpillVann.ToString());
                TempList.Add(recipe.ScrubberVaeske.ToString());
                TempList.Add(recipe.HCL.ToString());
                TempList.Add(recipe.Jernsulfat.ToString());
                TempList.Add(recipe.Temp.ToString());
                TempList.Add(recipe.Modningstid.ToString());
                TempList.Add(recipe.DampVentil.ToString());
                TempList.Add(recipe.Etterspyling.ToString());
                TempList.Add(recipe.O2Trykk.ToString());
                TempList.Add(recipe.O2Reaksjonstid.ToString());
                TempList.Add(recipe.DeltaTemp.ToString());
                TempList.Add(recipe.AnalysertFe3.ToString());
                TempList.Add(recipe.AnalysertFeTot.ToString());
                TempList.Add(recipe.VannSluttJustering.ToString());
                TempList.Add(recipe.VirkeligMVann.ToString());
                TempList.Add(recipe.TotTilLager.ToString());
                
                TempList.Add(recipe.filter.ToString());
                TempList.Add(recipe.edit.ToString());

                FormattedList.Add(TempList);

            }
            return FormattedList;
        }
    }
}
