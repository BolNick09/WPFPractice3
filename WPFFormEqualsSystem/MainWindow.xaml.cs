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

namespace WPFFormEqualsSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            int x;
            int.TryParse (tbX.Text, out x);
            if (x  <0)
            {
                float result = 2 * x + (float)Math.Cos(2 * x);
                MessageBox.Show(result.ToString());
            }
            else
            {
                float result = 3 * x + (float)Math.Sin(3 * x);
                MessageBox.Show(result.ToString());
            }
        }
    }
}