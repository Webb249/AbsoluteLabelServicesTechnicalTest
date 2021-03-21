

using Microsoft.Extensions.Configuration;

namespace AbsoluteLabelServicesTechnicalTest.Services
{
    /// <summary>
    /// Class for accessing the appsettings.json configuration
    /// </summary>
    public static class AppSettings
    {
        private static string DisplaySettingsLocation = "DisplaySettings";
        private static string MaxYearShownLocation = "MaxYearShown";

        /// <summary>
        /// Get the MaxYearShown value
        /// </summary>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static int GetMaxYearShown(IConfiguration configuration)
        {
            string maxYear = "0";

            maxYear = configuration.GetSection(DisplaySettingsLocation).GetSection(MaxYearShownLocation).Value;

            return int.Parse(maxYear);
        }
    }
}
