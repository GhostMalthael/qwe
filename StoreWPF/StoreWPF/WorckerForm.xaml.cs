using Microsoft.Win32;
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
using System.IO;

namespace StoreWPF
{
    /// <summary>
    /// Логика взаимодействия для WorckerForm.xaml
    /// </summary>
    public partial class WorckerForm : Window
    {

        private string imagePath;
        Repository repository = new Repository();

        public WorckerForm()
        {
            InitializeComponent();
            ShowDisplay();
        }

        private void buttonExitWorker_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            User.checkAdmin = false;
            User.checkAuthorization = false;
            Hide();
            new MainWindow().Show();
        }

        private void buttonAddProduct_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNameProduct.Text) && !string.IsNullOrEmpty(textBoxDescriptionProduct.Text) && !string.IsNullOrEmpty(textBoxPriceProduct.Text))
            {
                if (imagePath == null)
                {
                    imagePath = @"C:\Users\alexc\Desktop\noImage.jpg";
                }
                else
                {
                    string destinationPath = @"C:\Users\alexc\source\repos\StoreWPF\StoreWPF\ImageStore\";
                    string uniqueFileName = Guid.NewGuid().ToString() + System.IO.Path.GetExtension(imagePath);
                    string destinationFilePath = System.IO.Path.Combine(destinationPath, uniqueFileName);
                    File.Copy(imagePath, destinationFilePath);

                    imagePath = destinationFilePath;
                }
                repository.WriteFileJsonProduct(imagePath, textBoxNameProduct.Text, textBoxDescriptionProduct.Text, int.Parse(textBoxPriceProduct.Text), int.Parse(textBoxAmountProduct.Text));
                MessageBox.Show("Продукт добавлен");
            }
            else
            {
                MessageBox.Show("Должны быть заполнены поля: Название, Описание, Цена.");
                return;
            }
        }

        private void buttonAddImageProduct_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Uri uri = new Uri(openFileDialog.FileName);
                imagePath = openFileDialog.FileName;
                imageProduct.Source = new BitmapImage(uri);
            }
        }

        private void buttonDeleteProduct_Click(object sender, RoutedEventArgs e)
        {
            int idDeleteProduct = listViewWorker.SelectedIndex;
            if (idDeleteProduct == -1)
            {
                MessageBox.Show("Сперва нужно выбрать продукт для удаления");
            }
            else
            {
                Repository.products.RemoveAt(idDeleteProduct);
                repository.ReloadFileJsonProduct(Repository.products);
                ShowDisplay();
            }
        }
        public void ShowDisplay()
        {
            listViewWorker.Items.Clear();
            repository.ReadFileJson();
            foreach (var product in Repository.products)
            {
                UserControlStore userControlStore = new UserControlStore(product);
                listViewWorker.Items.Add(userControlStore);
            }
        }

        private void buttonEditProduct_Click(object sender, RoutedEventArgs e)
        {
            int idEditProduct = listViewWorker.SelectedIndex;
            if (idEditProduct == -1)
            {
                MessageBox.Show("Вы не выбрали продукт для изменения.");
                return;
            }
            if (string.IsNullOrEmpty(textBoxNameProduct.Text) && string.IsNullOrEmpty(textBoxDescriptionProduct.Text) && string.IsNullOrEmpty(textBoxPriceProduct.Text))
            {
                MessageBox.Show("Все поля должны быть заполнены");
                return;
            }
            if (string.IsNullOrEmpty(imagePath))
            {
                imagePath = @"C:\Users\alexc\Desktop\noImage.jpg";
            }
            Repository.products.RemoveAt(idEditProduct);
            Repository.products.Add(new Product(idEditProduct, imagePath, textBoxNameProduct.Text, textBoxDescriptionProduct.Text, int.Parse(textBoxPriceProduct.Text), int.Parse(textBoxAmountProduct.Text)));
            Repository repository = new Repository();
            repository.ReloadFileJsonProduct(Repository.products);
            ShowDisplay();
            idEditProduct = -1;
        }
    }
}