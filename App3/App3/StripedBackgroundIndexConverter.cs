using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public class StripedBackgroundIndexConverter : IValueConverter
    {
        
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || parameter == null) return Color.White;
            var index = ((ListView)parameter).ItemsSource.Cast<object>().ToList().IndexOf(value);

            var counterlistview = ((ListView)parameter).ItemsSource.Cast<object>().ToList().Count-1;


            //if (index == counterlistview)
            //{
            //   return ContentViewRoundedCorners.CornerRaidusProperty.DefaultValue;
            //}
            // return index  == counterlistview ? new Thickness(ContentViewRoundedCorners.CornerRaidusProperty()):ContentViewRoundedCorners.C;
            // return index;
            if (index == counterlistview )
            {
                return 15;
            }
            
            return 0;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
