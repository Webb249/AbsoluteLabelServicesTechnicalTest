using System;
using System.Globalization;

namespace AbsoluteLabelServicesTechnicalTest.Services
{
    public static class Utilties
    {
        /// <summary>
        /// Convert DateTime to a local format and remove the time portion
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns>Local date string</returns>
        public static string ConvertDateToLocalFormat(DateTime dateTime)
        {
            string rDate = "";
            string localTimeFormat = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;

            DateTime date = dateTime.Date;
            rDate = date.ToString(localTimeFormat);

            return rDate;
        }
    }
}
