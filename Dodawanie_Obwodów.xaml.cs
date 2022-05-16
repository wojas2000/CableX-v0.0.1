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
        public Label myLabel;
        RowDefinition rowDef1;

        public DodawanieObwodow()
        {
            InitializeComponent();
        }

        private void Add_Line_Button_Click(object sender, RoutedEventArgs e)
        {
            rowDef1 = new RowDefinition();
            grid_one.RowDefinitions.Add(rowDef1); //Dodaje kolejny wiersz

            Label myLabel = new Label();
            labelRow4.Content = "Dodana linia";
            myLabel.Width = 300;

            StackPanel myStackPanel = new StackPanel();
            //myStackPanel.Children.Add({ Content = "Nowa linijka."});

            TextBox textBox = new TextBox();

            //myStackPanel.Children.Add(myLabel); //Dodawanie wiersza przez kliknięcie przycisku            

            Button myButton = new Button();
            //myButton.Children.Add({ Content = "+", Width = 30 }); //Dodwanie przycisku na końcu wiersza
        }
    }
}
