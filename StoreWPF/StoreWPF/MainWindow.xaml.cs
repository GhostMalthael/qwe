using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace StoreWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Repository repository = new Repository();
        public MainWindow()
        {
            InitializeComponent();
            AccountDisplay();
            ShowDisplayForUser();

        }
        public void AccountDisplay()
        {
            if (User.checkAuthorization == true)
            {
                ButtonLoginToAccount.Visibility = Visibility.Hidden;
                ButtonExitToAccount.Visibility = Visibility.Visible;
                buttonBasket.Visibility = Visibility.Visible;
            }
            else
            {
                ButtonLoginToAccount.Visibility = Visibility.Visible;
                ButtonExitToAccount.Visibility= Visibility.Hidden;
                buttonBasket.Visibility= Visibility.Hidden;
            }
        }

        private void ButtonLoginToAccount_Click(object sender, RoutedEventArgs e)
        {
            Authorization authorization = new Authorization();
            Hide();
            authorization.Show();
        }

        private void ButtonExitToAccount_Click(object sender, RoutedEventArgs e)
        {
            User.checkAdmin = false;
            User.checkAuthorization = false;
            //if (User.checkAuthorization == false) 
            //{
            //    ButtonExitToAccount.Visibility = Visibility.Hidden;
            //    ButtonLoginToAccount.Visibility = Visibility.Visible;
            //    buttonBasket.Visibility = Visibility.Hidden; 
                
            //}
            //else
            //{
            //    ButtonExitToAccount.Visibility = Visibility.Visible;
            //    ButtonLoginToAccount.Visibility = Visibility.Hidden;
            //    buttonBasket.Visibility = Visibility.Visible;
            //}
            AccountDisplay();
            ShowDisplayForUser();
        }
        public void ShowDisplayForUser()
        {
            listViewForUser.Items.Clear();
            repository.ReadFileJson();
            foreach(var product in Repository.products)
            {
                var usercontrol = new UserControlStore(product);
                usercontrol.buttonDelete.Visibility = Visibility.Hidden;
                listViewForUser.Items.Add(usercontrol);
                if (User.checkAuthorization == false)
                {
                    usercontrol.buttonBuy.Visibility = Visibility.Hidden;
                }
                else
                {
                    usercontrol.buttonBuy.Visibility = Visibility.Visible;
                }
                //UserControlStore userControlStore = new UserControlStore(product);
                //listViewForUser.Items.Add(userControlStore);
            }
        }

        //private void Basket_Click(object sender, RoutedEventArgs e)
        //{

        //}

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //if (User.checkAuthorization)
            //{
            //    User.checkAuthorization = false;
            //    new MainWindow().Show();
            //}
            Process.GetCurrentProcess().Kill();
        }

        private void buttonBasket_Click(object sender, RoutedEventArgs e)
        {
            new Cart().Show();
        }

        //public void DeleteProductInCart()
        //{
        //    repository.ReadFileJson();
        //    int idDeleteProductInCart = listViewForUser.SelectedIndex;
        //    Repository.productsInCart.RemoveAt(idDeleteProductInCart);
        //    listViewForUser.Items.RemoveAt(idDeleteProductInCart);
        //}
    }
}
