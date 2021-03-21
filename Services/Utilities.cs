using AbsoluteLabelServicesTechnicalTest.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace AbsoluteLabelServicesTechnicalTest.Services
{
    public static class Utilities
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

        public static List<EntityTypeStorage> RemoveOutDatedValues(List<EntityTypeStorage> entityList, IConfiguration configuration)
        {
            List<EntityTypeStorage> rList = new List<EntityTypeStorage>();

            foreach(EntityTypeStorage entity in entityList)
            {
                if (DateTime.Parse(entity.releaseDate) > DateTime.Now.AddYears(-AppSettings.GetMaxYearShown(configuration)))
                {
                    rList.Add(entity);
                }
            }

            return rList;
        }
    }
}
