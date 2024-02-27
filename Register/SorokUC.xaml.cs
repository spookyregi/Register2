using Register.Models;
using Register.UserControls;
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

namespace Register
{
    /// <summary>
    /// Interaction logic for SorokUC.xaml
    /// </summary>
    public partial class SorokUC : UserControl
    {
        List<TermekModel> termekek;
        UserControl c;
        EladUC elad;
        public SorokUC(UserControl c, EladUC elad, RegisterContext rc)
        {
            termekek = (from b in rc.TermekLista.ToList()
                     where b.Kategoria == "Sör"
                     select b).ToList();
            InitializeComponent();
            this.c = c;
            this.elad = elad;
            setButtons();

        }
        private void btnOne(object sender, RoutedEventArgs e)
        {
            if (elad.lbField.Content != "")
            {
                elad.lbItemsIn.Items.Add($"{termekek[0].Nev}\n{elad.lbField.Content}\n{int.Parse(elad.lbField.Content.ToString()) * termekek[0].Ar}");
                elad.currentTotal += int.Parse(elad.lbField.Content.ToString()) * termekek[0].Ar;
            }
            else
            {
                elad.lbItemsIn.Items.Add($"{termekek[0].Nev}\n1\n{termekek[0].Ar}");
                elad.currentTotal += termekek[0].Ar;
            }

            elad.updateTotal();
            elad.lbField.Content = "";
        }

        private void btnBack(object sender, RoutedEventArgs e)
        {
            elad.ccCategories.Content = c;
        }

        private void btnTwo(object sender, RoutedEventArgs e)
        {
            if (elad.lbField.Content != "")
            {
                elad.lbItemsIn.Items.Add($"{termekek[1].Nev}\n{elad.lbField.Content}\n{int.Parse(elad.lbField.Content.ToString()) * termekek[1].Ar}");
                elad.currentTotal += int.Parse(elad.lbField.Content.ToString()) * termekek[1].Ar;
            }
            else
            {
                elad.lbItemsIn.Items.Add($"{termekek[1].Nev}\n1\n{termekek[1].Ar}");
                elad.currentTotal += termekek[1].Ar;
            }

            elad.updateTotal();
        }

        private void btnThree(object sender, RoutedEventArgs e)
        {
            if (elad.lbField.Content != "")
            {
                elad.lbItemsIn.Items.Add($"{termekek[2].Nev}\n{elad.lbField.Content}\n{int.Parse(elad.lbField.Content.ToString()) * termekek[2].Ar}");
                elad.currentTotal += int.Parse(elad.lbField.Content.ToString()) * termekek[2].Ar;
            }
            else
            {
                elad.lbItemsIn.Items.Add($"{termekek[2].Nev}\n1\n{termekek[2].Ar}");
                elad.currentTotal += termekek[2].Ar;
            }

            elad.updateTotal();
        }

        private void btnFour(object sender, RoutedEventArgs e)
        {
            if (elad.lbField.Content != "")
            {
                elad.lbItemsIn.Items.Add($"{termekek[3].Nev}\n{elad.lbField.Content}\n{int.Parse(elad.lbField.Content.ToString()) * termekek[3].Ar}");
                elad.currentTotal += int.Parse(elad.lbField.Content.ToString()) * termekek[3].Ar;
            }
            else
            {
                elad.lbItemsIn.Items.Add($"{termekek[3].Nev}\n1\n{termekek[3].Ar}");
                elad.currentTotal += termekek[3].Ar;
            }

            elad.updateTotal();
        }
        private void btnFive(object sender, RoutedEventArgs e)
        {
            if (elad.lbField.Content != "")
            {
                elad.lbItemsIn.Items.Add($"{termekek[4].Nev}\n{elad.lbField.Content}\n{int.Parse(elad.lbField.Content.ToString()) * termekek[4].Ar}");
                elad.currentTotal += int.Parse(elad.lbField.Content.ToString()) * termekek[4].Ar;
            }
            else
            {
                elad.lbItemsIn.Items.Add($"{termekek[4].Nev}\n1\n{termekek[4].Ar}");
                elad.currentTotal += termekek[4].Ar;
            }

            elad.updateTotal();
        }
        private void btnSix(object sender, RoutedEventArgs e)
        {
            if (elad.lbField.Content != "")
            {
                elad.lbItemsIn.Items.Add($"{termekek[5].Nev}\n{elad.lbField.Content}\n{int.Parse(elad.lbField.Content.ToString()) * termekek[5].Ar}");
                elad.currentTotal += int.Parse(elad.lbField.Content.ToString()) * termekek[5].Ar;
            }
            else
            {
                elad.lbItemsIn.Items.Add($"{termekek[5].Nev}\n1\n{termekek[5].Ar}");
                elad.currentTotal += termekek[5].Ar;
            }

            elad.updateTotal();
        }
        private void btnSeven(object sender, RoutedEventArgs e)
        {
            if (elad.lbField.Content != "")
            {
                elad.lbItemsIn.Items.Add($"{termekek[6].Nev}\n{elad.lbField.Content}\n{int.Parse(elad.lbField.Content.ToString()) * termekek[6].Ar}");
                elad.currentTotal += int.Parse(elad.lbField.Content.ToString()) * termekek[6].Ar;
            }
            else
            {
                elad.lbItemsIn.Items.Add($"{termekek[6].Nev}\n1\n{termekek[6].Ar}");
                elad.currentTotal += termekek[6].Ar;
            }

            elad.updateTotal();
        }
        private void btnEight(object sender, RoutedEventArgs e)
        {
            if (elad.lbField.Content != "")
            {
                elad.lbItemsIn.Items.Add($"{termekek[7].Nev}\n{elad.lbField.Content}\n{int.Parse(elad.lbField.Content.ToString()) * termekek[7].Ar}");
                elad.currentTotal += int.Parse(elad.lbField.Content.ToString()) * termekek[7].Ar;
            }
            else
            {
                elad.lbItemsIn.Items.Add($"{termekek[7].Nev}\n1\n{termekek[7].Ar}");
                elad.currentTotal += termekek[7].Ar;
            }

            elad.updateTotal();
        }
        private void btnNine(object sender, RoutedEventArgs e)
        {
            if (elad.lbField.Content != "")
            {
                elad.lbItemsIn.Items.Add($"{termekek[8].Nev}\n{elad.lbField.Content}\n{int.Parse(elad.lbField.Content.ToString()) * termekek[8].Ar}");
                elad.currentTotal += int.Parse(elad.lbField.Content.ToString()) * termekek[8].Ar;
            }
            else
            {
                elad.lbItemsIn.Items.Add($"{termekek[8].Nev}\n1\n{termekek[8].Ar}");
                elad.currentTotal += termekek[8].Ar;
            }

            elad.updateTotal();
        }
        private void btnTen(object sender, RoutedEventArgs e)
        {
            if (elad.lbField.Content != "")
            {
                elad.lbItemsIn.Items.Add($"{termekek[9].Nev}\n{elad.lbField.Content}\n{int.Parse(elad.lbField.Content.ToString()) * termekek[9].Ar}");
                elad.currentTotal += int.Parse(elad.lbField.Content.ToString()) * termekek[9].Ar;
            }
            else
            {
                elad.lbItemsIn.Items.Add($"{termekek[9].Nev}\n1\n{termekek[9].Ar}");
                elad.currentTotal += termekek[9].Ar;
            }

            elad.updateTotal();

        }

        private void btnEleven(object sender, RoutedEventArgs e)
        {
            if (elad.lbField.Content != "")
            {
                elad.lbItemsIn.Items.Add($"{termekek[10].Nev}\n{elad.lbField.Content}\n{int.Parse(elad.lbField.Content.ToString()) * termekek[10].Ar}");
                elad.currentTotal += int.Parse(elad.lbField.Content.ToString()) * termekek[10].Ar;
            }
            else
            {
                elad.lbItemsIn.Items.Add($"{termekek[10].Nev}\n1\n{termekek[10].Ar}");
                elad.currentTotal += termekek[10].Ar;
            }

            elad.updateTotal();

        }

        private void setButtons()
        {
            List<TermekModel> temporary = termekek;
            while (temporary.Count != 11)
            {
                temporary.Add(new TermekModel());
            }
            btn1.Content = temporary[0].Nev;
            btn2.Content = temporary[1].Nev;
            btn3.Content = temporary[2].Nev;
            btn4.Content = temporary[3].Nev;
            btn5.Content = temporary[4].Nev;
            btn6.Content = temporary[5].Nev;
            btn7.Content = temporary[6].Nev;
            btn8.Content = temporary[7].Nev;
            btn9.Content = temporary[8].Nev;
            btn10.Content = temporary[9].Nev;
            btn11.Content = temporary[10].Nev;

            if (btn1.Content == null)
            {
                btn1.Visibility = Visibility.Collapsed;
            }
            if (btn2.Content == null)
            {
                btn2.Visibility = Visibility.Collapsed;
            }
            if (btn3.Content == null)
            {
                btn3.Visibility = Visibility.Collapsed;
            }
            if (btn4.Content == null)
            {
                btn4.Visibility = Visibility.Collapsed;
            }
            if (btn5.Content == null)
            {
                btn5.Visibility = Visibility.Collapsed;
            }
            if (btn6.Content == null)
            {
                btn6.Visibility = Visibility.Collapsed;
            }
            if (btn7.Content == null)
            {
                btn7.Visibility = Visibility.Collapsed;
            }
            if (btn8.Content == null)
            {
                btn8.Visibility = Visibility.Collapsed;
            }
            if (btn9.Content == null)
            {
                btn9.Visibility = Visibility.Collapsed;
            }
            if (btn10.Content == null)
            {
                btn10.Visibility = Visibility.Collapsed;
            }
            if (btn11.Content == null)
            {
                btn11.Visibility = Visibility.Collapsed;
            }
        }
    }
}
