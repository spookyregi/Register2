using Register.Models;
using Register.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    /// Interaction logic for KategoriakUC.xaml
    /// </summary>
    public partial class KategoriakUC : UserControl
    {
        EladUC elad;
        RegisterContext rc;
        public KategoriakUC(EladUC elad, RegisterContext rc)
        {
            InitializeComponent();
            this.rc = rc;
            this.elad = elad;
        }

        private void btnSorok(object sender, RoutedEventArgs e)
        {
            elad.ccKategoriak.Content = new SorokUC(this, elad, rc);
        }
    }
}
