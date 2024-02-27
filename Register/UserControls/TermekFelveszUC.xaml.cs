using Register.Models;
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

namespace Register.UserControls
{
    /// <summary>
    /// Interaction logic for AddItemUC.xaml
    /// </summary>
    public partial class TermekFelveszUC : UserControl
    {
        MainWindow mw;
        RegisterContext rc;
        public TermekFelveszUC(RegisterContext rc, MainWindow mw)
        {
            this.mw = mw;
            InitializeComponent();
            this.rc = rc;
            refreshCB();
        }

        private void btnAddItem(object sender, RoutedEventArgs e)
        {
            if (tbUjKategoria.Text.Length > 0)
            {
                rc.TermekLista.Add(new TermekModel { Nev = tbUjNev.Text, Ar = int.Parse(tbUjAr.Text), Stock = int.Parse(tbUjKeszlet.Text), Kategoria = tbUjKategoria.Text });
            }
            else
            {
                rc.TermekLista.Add(new TermekModel { Nev = tbUjNev.Text, Ar = int.Parse(tbUjAr.Text), Stock = int.Parse(tbUjKeszlet.Text), Kategoria = cbUjKategoria.SelectedItem.ToString() });
            }
            
            rc.SaveChanges();
            MessageBox.Show("Item added.", "Saved");
            tbUjNev.Clear();
            tbUjKategoria.Clear();
            cbUjKategoria.SelectedIndex = -1;
            tbUjAr.Clear();
            tbUjKeszlet.Clear();
            refreshCB();
        }

        private void ClearCombo(object sender, RoutedEventArgs e)
        {
            cbUjKategoria.SelectedIndex = -1;
        }

        private void ClearTB(object sender, SelectionChangedEventArgs e)
        {
            tbUjKategoria.Text = string.Empty;
        }
        private void refreshCB()
        {
            cbUjKategoria.ItemsSource = (from i in rc.TermekLista
                                         select i.Kategoria).Distinct().ToList();
        }

        private void btnExit(object sender, RoutedEventArgs e)
        {
            mw.KezdoCC.Content = new MainUC(mw);
        }
    }
}
