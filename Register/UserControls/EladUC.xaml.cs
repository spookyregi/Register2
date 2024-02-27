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
using Register;

namespace Register.UserControls
{
    /// <summary>
    /// Interaction logic for SellUC.xaml
    /// </summary>
    public partial class EladUC : UserControl
    {
        MainWindow mw;
        public int currentTotal = 0;
        public EladUC(MainWindow mw)
        {
            InitializeComponent();
            ccCategories.Content = new KategoriakUC(this, mw.rc);
            this.mw = mw;
        }
        public void updateTotal()
        {
            lbTotal.Content = $"{currentTotal}";
        }

        private void removeItems(object sender, RoutedEventArgs e)
        {
            List<string> toClear = new List<string>();
            foreach (string s in lbItemsIn.SelectedItems)
            {
                toClear.Add(s);
            }
            foreach (var item in toClear)
            {
                lbItemsIn.Items.Remove(item);
                currentTotal -= int.Parse(item.Split("\n")[2]);
                updateTotal();
            }
            lbItemsIn.UnselectAll();


        }
        private void selectAllItems(object sender, RoutedEventArgs e)
        {
            if (lbItemsIn.SelectedItems.Count == lbItemsIn.Items.Count)
            {
                lbItemsIn.UnselectAll();
            }
            else
            {
                lbItemsIn.SelectAll();
            }

        }
        private void btnExit(object sender, RoutedEventArgs e)
        {
            mw.KezdoCC.Content = new MainUC(mw);

        }

        private void btnClearField(object sender, RoutedEventArgs e)
        {
            lbField.Content = "";
        }

        private void btnOne(object sender, RoutedEventArgs e)
        {
            lbField.Content += "1";
        }
        private void btnTwo(object sender, RoutedEventArgs e)
        {
            lbField.Content += "2";
        }
        private void btnThree(object sender, RoutedEventArgs e)
        {
            lbField.Content += "3";
        }
        private void btnFour(object sender, RoutedEventArgs e)
        {
            lbField.Content += "4";
        }
        private void btnFive(object sender, RoutedEventArgs e)
        {
            lbField.Content += "5";
        }

        private void btnSix(object sender, RoutedEventArgs e)
        {
            lbField.Content += "6";
        }

        private void btnSeven(object sender, RoutedEventArgs e)
        {
            lbField.Content += "7";
        }

        private void btnEight(object sender, RoutedEventArgs e)
        {
            lbField.Content += "8";
        }

        private void btnNine(object sender, RoutedEventArgs e)
        {
            lbField.Content += "9";
        }
        private void btnZero(object sender, RoutedEventArgs e)
        {
            lbField.Content += "0";
        }

        private void btnDoubleZero(object sender, RoutedEventArgs e)
        {
            lbField.Content += "00";
        }
        private void createInvoice(object sender, RoutedEventArgs e)
        {
            List<TermekModel> items = new List<TermekModel>();
            foreach (string i in lbItemsIn.Items)
            {
                string[] temp = i.Split('\n');
                for (int j = 0; j < int.Parse(temp[1]); j++)
                {
                    for (int k = 0; k < int.Parse(temp[1]); k++)
                    {
                        items.Add((from TermekModel c in mw.rc.TermekLista
                                   where c.Nev == temp[0]
                                   select c).FirstOrDefault());
                    }

                }
                foreach (TermekModel item in mw.rc.TermekLista)
                {
                    if (item.Nev == temp[0])
                    {
                        item.Stock -= int.Parse(temp[1]);
                    }
                }

            }
            BlokkModel nim = new BlokkModel { Vegosszeg = int.Parse(lbTotal.Content.ToString()), Termekek = items, Datum = DateTime.Now, Fizetve = true };
            mw.rc.BlokkLista.Add(nim);
            List<TermekModel> ok = nim.Termekek;
            mw.rc.SaveChanges();
            MessageBox.Show("Számla lezárva.", "Köszönjük a vásárlást!");

        }
    }
}

