using System;
using System.Globalization;
using Xamarin.Forms;

namespace GA.CaseStudy.Converter
{
    public class StringToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
               
                double valueAsBakiye = (double)value;
                if (valueAsBakiye < 0)
                {
                    return Color.DarkRed;
                }
                else if (valueAsBakiye == 0)
                {
                    return Color.Black;
                }
                else
                {
                    return Color.DarkGreen;
                }
            }
            catch (Exception)
            {
                return Color.Black;
            }
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
