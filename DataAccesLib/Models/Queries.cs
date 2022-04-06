﻿using BlazorDateRangePicker;
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
            sql = sql + $" SET batchNr = {Batch.BatchNr}, ID = '{Batch.ID}', SAP = {Batch.SAP}, Reaktor = {Batch.Reaktor}, Satsvolum = {Batch.SatsVolum.ToString().Replace(',','.')}, ";
            sql = sql + $" ForvFe = {Batch.ForvFe.ToString().Replace(',', '.')}, OnsketFe = {Batch.OnsketFe.ToString().Replace(',', '.')}, OnsketSyre = {Batch.OnsketSyre.ToString().Replace(',', '.')}, OnsketFe2 = {Batch.OnsketFe2.ToString().Replace(',', '.')}, ";
            sql = sql + $"HCLType = {Batch.HCLType.ToString().Replace(',', '.')}, ForvDamp = {Batch.ForvDamp.ToString().Replace(',', '.')}, VannOverordnet = {Batch.VannOverordnet.ToString().Replace(',', '.')}, VarmtVann = {Batch.VarmtVann.ToString().Replace(',', '.')}, ";
            sql = sql + $"SpillVann = {Batch.SpillVann.ToString().Replace(',', '.')}, ScrubberVaeske = {Batch.ScrubberVaeske.ToString().Replace(',', '.')}, HCL = {Batch.HCL.ToString().Replace(',', '.')}, JernSulfat = {Batch.Jernsulfat.ToString().Replace(',', '.')}, ";
            sql = sql + $"Temp = {Batch.Temp.ToString().Replace(',', '.')}, Modningstid = {Batch.Modningstid.ToString().Replace(',', '.')}, DampVentil = {Batch.DampVentil.ToString().Replace(',', '.')}, ";
            sql = sql + $"O2Trykk = {Batch.O2Trykk.ToString().Replace(',', '.')}, O2Reaksjonstid = {Batch.O2Reaksjonstid.ToString().Replace(',', '.')}, DeltaTemp = {Batch.DeltaTemp.ToString().Replace(',', '.')}, AnalysertFe3 = {Batch.AnalysertFe3.ToString().Replace(',', '.')}, ";
            sql = sql + $"AnalysertFeTot = {Batch.AnalysertFeTot.ToString().Replace(',', '.')}, VannSluttjustering = {Batch.VannSluttJustering.ToString().Replace(',', '.')}, VirkeligMVann = {Batch.VirkeligMVann.ToString().Replace(',', '.')}, TotTilLager = {Batch.TotTilLager.ToString().Replace(',', '.')} ";
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
