using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HelloWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      
        void SkrivTekst(object sender, RoutedEventArgs e)
        {
            RadioButton li = (sender as RadioButton);
            string greeting = "";
            switch (li.Content.ToString())
            {
                case "Dansk":
                    greeting = "Halløj";
                    break;
                case "English":
                    greeting = "Oi mate!";
                    break;
                case "Svenska":
                    greeting = "føøøøøj.";
                    break;
                default:
                    greeting = "noget gik galt";
                    break;
            }
            hilsen.Text = greeting + " WPF";
        }

        
    }
}
