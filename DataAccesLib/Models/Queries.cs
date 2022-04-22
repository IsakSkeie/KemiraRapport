using BlazorDateRangePicker;
using System.Collections.Generic;
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

        public string RecipeUpdate(List<string> Batch)
        {

            string[] date = Batch[1].Split('/');
            string[] time = date[2].Split(' ');
            int etterspyling = 0;
            if (Batch[21] == "True") { etterspyling = 1; }

            string SQLStartDate = time[0] + "-" + date[0] + "-" + date[1] + " " + time[1] + ".000";
            string SQLEndDate = time[0] + "-" + date[0] + "-" + date[1] + " " + time[1] + ".999";




            //format blazor mm/dd/yyyy hh:mm:ss.ms
            //format '2022-03-02 11:53:22.000'
            //string startTime = 

            //Need to fix Etterspyling
            //sql = "UPDATE PIX318_ReseptData";
            //sql = sql + $" SET batchNr = {Batch.BatchNr}, ID = '{Batch.ID}', SAP = {Batch.SAP}, Reaktor = {Batch.Reaktor}, Satsvolum = {Batch.SatsVolum},";
            //sql = sql + $" ForvFe = {Batch.ForvFe}, OnsketFe = {Batch.OnsketFe}, OnsketSyre = {Batch.OnsketSyre}, OnsketFe2 = {Batch.OnsketFe2}, ";
            //sql = sql + $"HCLType = {Batch.HCLType}, ForvDamp = {Batch.ForvDamp}, VannOverordnet = {Batch.VannOverordnet}, VarmtVann = {Batch.VarmtVann}, ";
            //sql = sql + $"SpillVann = {Batch.SpillVann}, ScrubberVaeske = {Batch.ScrubberVaeske}, HCL = {Batch.HCL}, JernSulfat = {Batch.Jernsulfat}, ";
            //sql = sql + $"Temp = {Batch.Temp}, Modningstid = {Batch.Modningstid}, DampVentil = {Batch.DampVentil}, Etterspyling = {etterspyling}, ";
            //sql = sql + $"O2Trykk = {Batch.O2Trykk}, O2Reaksjonstid = {Batch.O2Reaksjonstid}, DeltaTemp = {Batch.DeltaTemp}, AnalysertFe3 = {Batch.AnalysertFe3}, ";
            //sql = sql + $"AnalysertFeTot = {Batch.AnalysertFeTot}, VannSluttjustering = {Batch.VannSluttJustering}, VirkeligMVann = {Batch.VirkeligMVann}, TotTilLager = {Batch.TotTilLager} ";
            //sql = sql + $"where dato between '{SQLStartDate}' AND '{SQLEndDate}'; ";


            sql = "UPDATE PIX318_ReseptData";
            sql = sql + $" SET batchNr = {Batch[0]}, ID = '{Batch[3]}', SAP = {Batch[2]}, Reaktor = {Batch[4]}, Satsvolum = {Batch[5].Replace(',','.')}, ";
            sql = sql + $" ForvFe = {Batch[6].Replace(',', '.')}, OnsketFe = {Batch[7].Replace(',', '.')}, OnsketSyre = {Batch[8].Replace(',', '.')}, OnsketFe2 = {Batch[9].ToString().Replace(',', '.')}, ";
            sql = sql + $"HCLType = {Batch[10].Replace(',', '.')}, ForvDamp = {Batch[11].Replace(',', '.')}, VannOverordnet = {Batch[12].Replace(',', '.')}, VarmtVann = {Batch[13].Replace(',', '.')}, ";
            sql = sql + $"SpillVann = {Batch[14].Replace(',', '.')}, ScrubberVaeske = {Batch[15].Replace(',', '.')}, HCL = {Batch[16].Replace(',', '.')}, JernSulfat = {Batch[17].Replace(',', '.')}, ";
            sql = sql + $"Temp = {Batch[18].Replace(',', '.')}, Modningstid = {Batch[19].Replace(',', '.')}, DampVentil = {Batch[20].Replace(',', '.')}, ";
            sql = sql + $"O2Trykk = {Batch[22].Replace(',', '.')}, O2Reaksjonstid = {Batch[23].Replace(',', '.')}, DeltaTemp = {Batch[24].Replace(',', '.')}, AnalysertFe3 = {Batch[25].Replace(',', '.')}, ";
            sql = sql + $"AnalysertFeTot = {Batch[26].Replace(',', '.')}, VannSluttjustering = {Batch[27].Replace(',', '.')}, VirkeligMVann = {Batch[28].Replace(',', '.')}, TotTilLager = {Batch[29].Replace(',', '.')} ";
            sql = sql + $"where dato between '{SQLStartDate}' AND '{SQLEndDate}'; ";



            return sql;
        }

        public string AnalysisRecipeUpdate(RecipeModels Batch)
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
            sql = sql + $" SET batchNr = {Batch.BatchNr}, ID = '{Batch.ID}', TotalFe = {Batch.TotalFe}, Egenvekt = {Batch.Egenvekt},";
            sql = sql + $" Verdi2Fe = {Batch.Verdi2Fe}, ManuellVerdi2Fe = {Batch.ManuellVerdi2Fe}, ";
            sql = sql + $" Verdi3EtterManuell2Fe = {Batch.Verdi3EtterManuell2Fe}, Verdi3Fe = {Batch.Verdi3Fe}, FriSyre = {Batch.FriSyre} ";
            sql = sql + $"where dato between '{SQLStartDate}' AND '{SQLEndDate}'; ";

            Debug.WriteLine(sql);
            return sql;
        }
        public string TableReset()
        {
            sql = $"SELECT top ({ Queries.TableLen }) * FROM PIX318_ReseptData ORDER BY BatchNr DESC";
            return sql;
        }
    }
}
