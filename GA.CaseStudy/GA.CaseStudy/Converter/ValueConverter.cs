using System;
using System.Globalization;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace GA.CaseStudy.Converter
{
    public class ValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                double valueAsBakiye = (double)value;
                if (valueAsBakiye >= 0)
                {
                    if (valueAsBakiye == 0)
                    {
                        return decimal.Parse(value.ToString()).ToString("#,###.###");
                    }
                    else
                    {
                        return "+" + decimal.Parse(value.ToString()).ToString("#,###.###");
                    }
                }
                else
                {
                    return decimal.Parse(value.ToString()).ToString("#,###.###");
                }
            }
            catch (Exception ex )
            {

                throw;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string valueFromString = Regex.Replace(value.ToString(), @"\D", "");

            if (valueFromString.Length <= 0)
                return 0m;

            long valueLong;
            if (!long.TryParse(valueFromString, out valueLong))
                return 0m;

            if (valueLong <= 0)
                return 0m;

            return valueLong / 100m;
        }
    }
}
