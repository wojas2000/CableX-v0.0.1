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
    public partial class Tabela : Window
    {
        public Tabela()
        {
            InitializeComponent();
            TabelaObwodow.ItemsSource = LoadCollectionData();
        }

        public class ObwodyHeader
        {
            public int Lp { get; set; }
            public string From { get; set; }
            public string To { get; set; }
            public int Power { get; set; }
        }
        private List<ObwodyHeader> LoadCollectionData()
        {
            List<ObwodyHeader> obwody = new List<ObwodyHeader>();
            obwody.Add(new ObwodyHeader()
            {
                Lp = 101,
                From = "ZK1",
                To = "ZK2",
                Power = 16
            });           
            return obwody;
        }        

        private void button_exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Tabela_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
