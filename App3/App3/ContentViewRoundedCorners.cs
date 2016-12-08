using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public class ContentViewRoundedCorners : StackLayout
    {
        public static readonly BindableProperty CornerRaidusProperty =
            BindableProperty.Create<ContentViewRoundedCorners, float>(x => x.CornerRadius,0);

        public float CornerRadius
        {
            get { return (float)GetValue(CornerRaidusProperty); }
            set { SetValue(CornerRaidusProperty, value); }
        }
    }
}
