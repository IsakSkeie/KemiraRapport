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
        
    }
}
