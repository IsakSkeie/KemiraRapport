using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLib.Models
{
    public class RecipeModels
    {
        public int BatchNr { get; set; }

        public string Dato { get; set; }
        public int SAP { get; set; }
        public string ID { get; set; }
        public int Reaktor { get; set; }
        public double SatsVolum { get; set; }
        public double ForvFe { get; set; }
        public double OnsketFe { get; set; }
        public double OnsketSyre { get; set; }
        public double OnsketFe2 { get; set; }
        public double HCLType { get; set; }
        public double ForvDamp { get; set; }
        public double VannOverordnet { get; set; }
        public double VarmtVann { get; set; }
        public double SpillVann { get; set; }
        public double ScrubberVaeske { get; set; }
        public double HCL { get; set; }
        public double Jernsulfat { get; set; }
        public double Temp { get; set; }
        public double Modningstid { get; set; }
        public double DampVentil { get; set; }
        public bool Etterspyling { get; set; }
        public double O2Trykk { get; set; }
        public double O2Reaksjonstid { get; set; }
        public double DeltaTemp { get; set; }
        public double AnalysertFe3 { get; set; }
        public double AnalysertFeTot { get; set; }
        public double VannSluttJustering { get; set; }
        public double VirkeligMVann { get; set; }
        public double TotTilLager { get; set; }

        public bool filter { get; set; }
        public bool edit { get; set; }


    }   




    public static class FilterModel
    {
        public static bool[] filter = new bool[30];
       

    }
    public class filtering
    {
        public bool sort { get; set; }
        public string variable { get; set; }
    }

}
