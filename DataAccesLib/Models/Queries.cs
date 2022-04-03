using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using BlazorDateRangePicker;


namespace DataAccesLib.Models
{
    public class Queries
    {
        public static int TableLen = 10;
        public static string sql =  $"SELECT top ({ TableLen }) * FROM PIX318_ReseptData ORDER BY BatchNr DESC";
       
        
       
        public string pix318()
        {
            sql = $"SELECT top ({ TableLen }) * FROM PIX318_ReseptData ORDER BY BatchNr DESC";
            return sql;
        }

        public string DateQuery(DateRange range)

        {
            range.Start = range.Start.AddDays(-1);

            string StartYear = range.Start.Date.Year.ToString();
            string StartMonth = range.Start.Date.Month.ToString();
            string StartDay = range.Start.Date.Day.ToString();
            string EndYear = range.End.Date.Year.ToString();
            string EndMonth = range.End.Date.Month.ToString();
            string EndDay = range.End.Date.Day.ToString();
            
            string StartDate = StartYear + "-" + StartMonth + "-" + StartDay +" 00:00:00";
          
            string EndDate = EndYear + "-" + EndMonth + "-" + EndDay +" 23:59:59";
            Debug.WriteLine(StartDate);

            sql = $"SELECT * FROM PIX318_ReseptData where dato between '{ StartDate }' and '{ EndDate }' ORDER BY BatchNr DESC;";

            return sql;
        }

        public string TableUpdate(int Len)
        {

            string sql = $"SELECT top ({ Len }) * FROM PIX318_ReseptData ORDER BY BatchNr DESC";
            return sql;
        }

        public string RecipeUpdate(RecipeModels Batch)
        {
            //format '2022-03-02 11:53:22.000'
            //string startTime = 
            string sql = "UPDATE PIX318_ReseptData";
            sql = sql + $" SET batchNr = {Batch.BatchNr}, SAP = {Batch.SAP}, Reaktor = {Batch.Reaktor}, Satsvolum = {Batch.SatsVolum},";
            sql = sql + $" ForvFe = {Batch.ForvFe}, OnsketFe = {Batch.OnsketFe}, OnsketSyre = {Batch.OnsketSyre}, OnsketFe2 = {Batch.OnsketFe2}, ";
            sql = sql + $"HCLType = {Batch.HCLType}, ForvDamp = {Batch.ForvDamp}, VannOverordnet = {Batch.VannOverordnet}, VarmtVann = {Batch.VarmtVann}, ";
            sql = sql + $"SpillVann = {Batch.SpillVann}, ScrubberVaeske = {Batch.ScrubberVaeske}, HCL = {Batch.HCL}, JernSulfat = {Batch.Jernsulfat}, ";
            sql = sql + $"Temp = {Batch.Temp}, Modningstid = {Batch.Modningstid}, DampVentil = {Batch.DampVentil}, Etterspyling = {Batch.Etterspyling}, ";
            sql = sql + $"O2Trykk = {Batch.O2Trykk}, O2Reaksjonstid = {Batch.O2Reaksjonstid}, DeltaTemp = {Batch.DeltaTemp}, AnalysertFe3 = {Batch.AnalysertFe3}, ";
            sql = sql + $"AnalysertFeTot = {Batch.AnalysertFeTot}, VannSluttjustering = {Batch.VannSluttJustering}, VirkeligMVann = {Batch.VirkeligMVann}, TotTilLager = {Batch.TotTilLager} ";
            //sql = sql + $"where dato = '{}'; ";

            return sql;
        }
        
    }
}
