using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Globalization;


namespace NewSwitch
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnItalicCheckBoxChanged(object sender, ToggledEventArgs args)
        {
            bool isChecked = args.Value;

            if (isChecked)
            {
                label.FontAttributes |= FontAttributes.Italic;
            }
            else
            {
                label.FontAttributes &= ~FontAttributes.Italic;
            }
        }

        private void OnBoldCheckBoxChanged(object sender, ToggledEventArgs args)
        {
            bool isChecked = args.Value;

            if (isChecked)
            {
                label.FontAttributes |= FontAttributes.Bold;
            }
            else
            {
                label.FontAttributes &= ~FontAttributes.Bold;
            }
        }
    }

    public class BoolToObjectConverter<T> : IValueConverter
    {
        public T TrueObject { set; get; }

        public T FalseObject { set; get; }

        public object Convert(object value, Type targetType,
                              object parameter, CultureInfo culture)
        {
            return (bool)value ? this.TrueObject : this.FalseObject;
        }

        public object ConvertBack(object value, Type targetType,
                                  object parameter, CultureInfo culture)
        {
            return ((T)value).Equals(this.TrueObject);
        }
    }
}
