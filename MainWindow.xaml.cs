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
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void button_add_circuit_Click(object sender, RoutedEventArgs e)
        {
            Page_click_btn_1.Content = new Page1();
        }
        private void button_add_power_Click(object sender, RoutedEventArgs e)
        {
            DodawanieObwodow thirdWindow = new DodawanieObwodow();
            thirdWindow.Show();
        }     

        private void button_help_Click(object sender, RoutedEventArgs e)
        {
            HelpWindow secondWindow = new HelpWindow();
            secondWindow.Show();
        }

        private void Buton_Tabela_Click(object sender, RoutedEventArgs e)
        {
            Tabela fourthWindow = new Tabela();
            fourthWindow.Show();
        }
    }
    public class ApplicationService
    {
        public static string myTitle = "CableX v0.0.1"; //title and version Main window 
    }


}
