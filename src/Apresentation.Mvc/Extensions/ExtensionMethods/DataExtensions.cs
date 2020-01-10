using System;

namespace Apresentation.Mvc.Extensions.ExtensionMethods
{
    public static class DataExtensions
    {
        public static string DataPt(this DateTime dateTime)
        {
            return dateTime.ToString("dd/MM/yyyy");
        }

        public static string DataHoraPtBr(this DateTime date)
        {
            return date.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
