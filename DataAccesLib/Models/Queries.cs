using BlazorDateRangePicker;
using System.Diagnostics;


namespace DataAccesLib.Models
{
    public class Queries
    {
        public static int TableLen = 10;
        public static string sql = $"SELECT top ({ TableLen }) * FROM PIX318_ReseptData ORDER BY BatchNr DESC";



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

            string StartDate = StartYear + "-" + StartMonth + "-" + StartDay + " 00:00:00";

            string EndDate = EndYear + "-" + EndMonth + "-" + EndDay + " 23:59:59";


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

            string[] date = Batch.Dato.Split('/');
            string[] time = date[2].Split(' ');
            int etterspyling = 0;
            if (Batch.Etterspyling) { etterspyling = 1; }

            string SQLStartDate = time[0] + "-" + date[0] + "-" + date[1] + " " + time[1] + ".000";
            string SQLEndDate = time[0] + "-" + date[0] + "-" + date[1] + " " + time[1] + ".999";




            //format blazor mm/dd/yyyy hh:mm:ss.ms
            //format '2022-03-02 11:53:22.000'
            //string startTime = 
            sql = "UPDATE PIX318_ReseptData";
            sql = sql + $" SET batchNr = {Batch.BatchNr}, SAP = {Batch.SAP}, Reaktor = {Batch.Reaktor}, Satsvolum = {Batch.SatsVolum},";
            sql = sql + $" ForvFe = {Batch.ForvFe}, OnsketFe = {Batch.OnsketFe}, OnsketSyre = {Batch.OnsketSyre}, OnsketFe2 = {Batch.OnsketFe2}, ";
            sql = sql + $"HCLType = {Batch.HCLType}, ForvDamp = {Batch.ForvDamp}, VannOverordnet = {Batch.VannOverordnet}, VarmtVann = {Batch.VarmtVann}, ";
            sql = sql + $"SpillVann = {Batch.SpillVann}, ScrubberVaeske = {Batch.ScrubberVaeske}, HCL = {Batch.HCL}, JernSulfat = {Batch.Jernsulfat}, ";
            sql = sql + $"Temp = {Batch.Temp}, Modningstid = {Batch.Modningstid}, DampVentil = {Batch.DampVentil}, Etterspyling = {etterspyling}, ";
            sql = sql + $"O2Trykk = {Batch.O2Trykk}, O2Reaksjonstid = {Batch.O2Reaksjonstid}, DeltaTemp = {Batch.DeltaTemp}, AnalysertFe3 = {Batch.AnalysertFe3}, ";
            sql = sql + $"AnalysertFeTot = {Batch.AnalysertFeTot}, VannSluttjustering = {Batch.VannSluttJustering}, VirkeligMVann = {Batch.VirkeligMVann}, TotTilLager = {Batch.TotTilLager} ";
            sql = sql + $"where dato between '{SQLStartDate}' AND '{SQLEndDate}'; ";
            Debug.WriteLine(sql);

            return sql;
        }

    }
}
