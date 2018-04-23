using System;
using System.Globalization;
using System.Windows.Data;

namespace Lab.KnowledgeShare.Wpf101.UI.Converter
{
    public class PriceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) => "£" + value;

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
    }
}
