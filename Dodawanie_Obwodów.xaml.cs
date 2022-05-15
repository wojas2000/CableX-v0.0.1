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
using System.Windows.Shapes;

namespace CableX_v0._0._1
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class DodawanieObwodow : Window
    {
        public DodawanieObwodow()
        {
            InitializeComponent();
        }

        private void Add_Line_Button_Click(object sender, RoutedEventArgs e)
        {
            //Label line_label = new Label();
            //line_label.Content = "Dodana linia";
            //line_label.Width = 300;
            LabelStackPanel.Children.Add(new TextBox { }); //Dodawanie wiersza przez kliknięcie przycisku
            //Button button = new Button();
            LabelStackPanel2.Children.Add(new Button { Content = "+", Width = 30 }); //Dodwanie przycisku na końcu wiersza
        }
    }
}
