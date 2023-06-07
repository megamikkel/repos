using System.Windows;

namespace WPFTutorial_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool running = false;
        public MainWindow()
        {
            InitializeComponent();
                    
        }

        private void Btn_toggle_Click(object sender, RoutedEventArgs e)
        {
            if (running)
            {
                //stop
                TbStatus.Text = "Stop";
                btn_toggle.Content = "Run"; 
            }
            else
            {
                // run
                TbStatus.Text = "Running";
                btn_toggle.Content = "Stop";
            }

            running = !running;

        }   
    }
}
