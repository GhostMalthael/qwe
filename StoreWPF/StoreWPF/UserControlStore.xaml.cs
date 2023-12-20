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

namespace StoreWPF
{
    /// <summary>
    /// Логика взаимодействия для UserControlStore.xaml
    /// </summary>
    public partial class UserControlStore : UserControl
    {
        public static ListView ListView { get; set; }
        Repository repository = new Repository();
        public static int userId;
        private Product products;
        public Product Products { 
            get => this.products; 
            set { this.products = value; productName.Content = $"Название:\n {this.products.Name}";
                productDescription.Content = $"Описание:\n{this.products.Description}";
                productPrice.Content = $"Цена:\n{this.products.Price}";
                imageProduct.Source = new BitmapImage(new Uri(this.products.ImagePath));} }
        public UserControlStore(Product product)
        {
            InitializeComponent();
            this.Products = product;
        }

        public void buttonBuy_Click(object sender, RoutedEventArgs e)
        {
            buttonBuy.Visibility = Visibility.Hidden;
            buttonPlusProduct.Visibility = Visibility.Visible;
            buttonMinusProduct.Visibility = Visibility.Visible;
            amountAddProduct.Visibility = Visibility.Visible;
            repository.WriteFileJsonProductInCart(userId, Products.ImagePath, Products.Name, Products.Description, Products.Price, int.Parse(amountAddProduct.Content.ToString()) ,Products.MaxAmount); 
        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            int productId = Products.Id;
            repository.ReadFileJson();
            var productToRemove = Repository.productsInCart.FirstOrDefault(item => item.Id == productId);
            if (productToRemove != null)
            {
                Repository.productsInCart.Remove(productToRemove);
                var deleteProduct = ListView.Items.OfType<UserControlStore>().FirstOrDefault(item => item.Products.Id == productId);
                if (deleteProduct != null)
                {
                    ListView.Items.Remove(deleteProduct);
                }
                for (int i = 0; i < Repository.productsInCart.Count; i++)
                {
                    Repository.productsInCart[i].Id = i + 1;
                }
                repository.ReloadFileJsonProductInCart(Repository.productsInCart);
            }
        }

        private void buttonPlusProduct_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
