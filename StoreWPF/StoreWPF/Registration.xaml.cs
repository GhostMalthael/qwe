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

namespace StoreWPF
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void ButtonRegSwap_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            new Authorization().Show();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();   
            mainWindow.Show();
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            Repository repository = new Repository();
            LoginNull.Visibility = Visibility.Hidden;
            if(LoginNull == null)
            {
                LoginNull.Visibility= Visibility.Visible;
            }
            PasswordNull.Visibility = Visibility.Hidden;
            if(PasswordNull == null)
            {
                PasswordNull.Visibility= Visibility.Visible;
            }
            PasswordsError.Visibility = Visibility.Hidden;
            if (RegPasswordTextBox.Text != regPasswordRepeatTextBox.Text)
            {
                PasswordsError.Visibility = Visibility.Visible;
            }
            Repository.RegAccount(regLoginTextBox.Text, RegPasswordTextBox.Text);
        }
    }
}
