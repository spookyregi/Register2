using Register.Models;
using Register.UserControls;
using System.Text;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public RegisterContext rc;
        public MainWindow()
        {
            InitializeComponent();
            KezdoCC.Content = new MainUC(this);
            rc = new RegisterContext();
            rc.Database.EnsureCreated();
        }
    }
}