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

namespace CableX_v0._0._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();                                
        }

        private void button_add_circuit_Click(object sender, RoutedEventArgs e)
        {
            Page_click_btn_1.Content  = new Page1();

        }

        private void button_help_Click(object sender, RoutedEventArgs e)
        {

        }
    }
    public class ApplicationService
    {
        public static string myTitle = "CableX v0.0.1"; //title and version Main window 
    }

   
}
