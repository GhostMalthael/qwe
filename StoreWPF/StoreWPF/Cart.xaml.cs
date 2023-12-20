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
    /// Логика взаимодействия для Cart.xaml
    /// </summary>
    public partial class Cart : Window
    {
        public Cart()
        {
            InitializeComponent();
            ShowDisplayCart();
        } 
       
        //private void Window_Closed(object sender, EventArgs e)
        //{
        //    Hide();
        //    new MainWindow().Show();
        //}
        public void ShowDisplayCart()
        {
            Repository repository = new Repository();
            listViewCart.Items.Clear();
            repository.ReadFileJson();
           foreach (var item in Repository.productsInCart)
           {
               if (item.IdUser == UserControlStore.userId)
               {
                   UserControlStore userControlStore = new UserControlStore(item);
                   userControlStore.buttonDelete.Visibility = Visibility.Visible;
                   UserControlStore.ListView = listViewCart;
                   listViewCart.Items.Add(userControlStore);
               }
           }
        }
    }
}
