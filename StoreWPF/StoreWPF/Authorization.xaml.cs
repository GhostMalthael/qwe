using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace StoreWPF
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        //User user;
        public Authorization()
        {
            InitializeComponent();
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            Hide();
            new MainWindow().Show();
        }

        private void ButtonAutSwap_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            new Registration().Show();
        }

        private void EntranceButtonAut_Click(object sender, RoutedEventArgs e)
        {

            autLoginError.Visibility = Visibility.Hidden;
            if (autLoginTextBox.Text == null)
            {
                autLoginError.Visibility = Visibility.Visible;
            }
            autPasswordError.Visibility = Visibility.Hidden;
            if (autPasswordTextBox.Text == null)
            {
                autPasswordError.Visibility = Visibility.Visible;
            }
            Repository repository = new Repository();
            repository.ReadFileJson();
            Repository.AutAccount(autLoginTextBox.Text, autPasswordTextBox.Text);
            if (User.checkAuthorization == true) 
            {
                Hide();
            }
        }
    }
}
