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
using System.IO;

namespace WPFFormResumeMax
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

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string name = tbName.Text;
            string lastName = tbLastName.Text;
            string fatherName = tbFatherName.Text;
            string sex = tbSex.Text;
            string dateOfBirth = tbDateOfBirth.Text;
            string maritalStatus = tbMaritalStatus.Text;
            string addInfo = tbAddInfo.Text;

            string resume = string.Format("Имя: {0}\nФамилия: {1}\nОтчество: {2}\nПол: {3}\nДата рождения: {4}\nСемейный статус: {5}\nДоп информация: {6}",
                                         name, lastName, fatherName, sex, dateOfBirth, maritalStatus, addInfo);

            File.WriteAllText("Resume.txt", resume);
        }
    }
}