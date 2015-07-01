using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Forms;
using ConecctorOneC;

namespace ClientOneC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {

        public Connection Con;
        
        public MainWindow()
        {
            InitializeComponent();
            Con = new Connection();
            Con.ConnectionString();
       }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = Con.GroupnOfNomenclatureList();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            
            DataGrid.ItemsSource = null;
            DataGrid.ItemsSource = Con.SearchNomenclatureName(TextBoxSearch.Text);
            

        }

        private void SearchByCode_Click(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = null;
            DataGrid.ItemsSource = new List<Connection.Nomenclature>
            {
                Con.SearchNomenclatureByCode(TextBoxSearchByCode.Text)
            };
        }

        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            Con.Nomen();
        }

    }
    
}
