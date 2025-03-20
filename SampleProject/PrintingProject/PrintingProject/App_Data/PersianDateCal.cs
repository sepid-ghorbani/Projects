using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Globalization;

/// <summary>
/// Summary description for AtinetPersianDate
/// </summary>
public class PersianDateCal
{
  public string ConvertToPersianDate(DateTime date,string Display)
    {
        PersianCalendar pc = new PersianCalendar();
        string PersianMonthName = "";
        string PersianDayName = "";
        string PersianDate = "";

        switch (pc.GetMonth(date).ToString())
        {
            case "1":
                PersianMonthName = "فروردین";
                break;
            case "2":
                PersianMonthName = "اردیبهشت";
                break;
            case "3":
                PersianMonthName = "خرداد";
                break;
            case "4":
                PersianMonthName = "تیر";
                break;
            case "5":
                PersianMonthName = "مرداد";
                break;
            case "6":
                PersianMonthName = "شهریور";
                break;
            case "7":
                PersianMonthName = "مهر";
                break;
            case "8":
                PersianMonthName = "آبان";
                break;
            case "9":
                PersianMonthName = "آذر";
                break;
            case "10":
                PersianMonthName = "دی";
                break;
            case "11":
                PersianMonthName = "بهمن";
                break;
            case "12":
                PersianMonthName = "اسفند";
                break;
        }
        switch (pc.GetDayOfWeek(date))
        {
            case DayOfWeek.Saturday:
                PersianDayName = "شنبه";
                break;
            case DayOfWeek.Sunday:
                PersianDayName = "یکشنبه";
                break;
            case DayOfWeek.Monday:
                PersianDayName = "دوشنبه";
                break;
            case DayOfWeek.Tuesday:
                PersianDayName = "سه شنبه";
                break;
            case DayOfWeek.Wednesday:
                PersianDayName = "چهارشنبه";
                break;
            case DayOfWeek.Thursday:
                PersianDayName = "پنجشنبه";
                break;
            case DayOfWeek.Friday:
                PersianDayName = "جمعه";
                break;
        }
              
        Display = Display.Replace("d", pc.GetDayOfMonth(date).ToString());
        Display = Display.Replace("D", PersianDayName.ToString());
        Display = Display.Replace("m", pc.GetMonth(date).ToString());
        Display = Display.Replace("M", PersianMonthName.ToString());
        Display = Display.Replace("y", pc.GetYear(date).ToString().Substring(2, 2));
        Display = Display.Replace("Y", pc.GetYear(date).ToString());
        Display = Display.Replace("h", date.Hour.ToString());
        Display = Display.Replace("n", date.Minute.ToString());

        return Display;

    }
}
