using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace bank_bolig_opgave
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {


        private int myValue = 0;

        public int MyValue
        {
            get
            {
                return this.myValue;
            }
            set
            {
                this.myValue = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }

        
    
}
[ValueConversion(typeof(int), typeof(string))]
class SimpleConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        return value.ToString();
    }

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        int returnedValue;

        if (int.TryParse((string)value, out returnedValue))
        {
            return returnedValue;
        }

        throw new Exception("The text is not a number");
    }
}
