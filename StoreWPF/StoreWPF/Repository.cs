using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;

namespace StoreWPF
{
    //cинглтон
    public class Repository
    {
        public static List<User> peopleDataBase = new List<User>();
        public static List<Product> products = new List<Product>();
        public static List<ProductInCart> productsInCart = new List<ProductInCart>();
        string filePeoplePath = @"C:\Users\alexc\Desktop\PeopleDataBase.json";
        static string fileProductPath = @"C:\Users\alexc\Desktop\AllProducts.json";
        string fileProductInCartPath = @"C:\Users\alexc\Desktop\ProductsInCart.json";
        private int countIdPeople;
        private int countIdProduct;
        private int countIdProductInCart;
        public void WriteFileJson(string login, string password)
        {
            string registrationFileJson = File.ReadAllText(filePeoplePath);
            if (!string.IsNullOrEmpty(registrationFileJson))
            {
                peopleDataBase = JsonConvert.DeserializeObject<List<User>>(registrationFileJson);
                countIdPeople = peopleDataBase.Count;
            }
            peopleDataBase.Add(new User(countIdPeople, login, password));
            File.WriteAllText(filePeoplePath, JsonConvert.SerializeObject(peopleDataBase));
            Console.WriteLine("Успешно");
            //MessageBox.Show("Успешно");

        }
        public void ReadFileJson()
        {
            string readRegistrationFileJson = File.ReadAllText(filePeoplePath);
            if (!string.IsNullOrEmpty(readRegistrationFileJson))
            {
                peopleDataBase = JsonConvert.DeserializeObject<List<User>>(readRegistrationFileJson);
                countIdPeople = peopleDataBase.Count;
            }
            string productContentJson = File.ReadAllText(fileProductPath);
            if (!string.IsNullOrEmpty(productContentJson))
            {
                products = JsonConvert.DeserializeObject<List<Product>>(productContentJson);
                countIdProduct = products.Count;
            }
            string productInCartContentJson = File.ReadAllText(fileProductInCartPath);
            if (!string.IsNullOrEmpty(productInCartContentJson))
            {
                productsInCart = JsonConvert.DeserializeObject<List<ProductInCart>>(productInCartContentJson);
                countIdProductInCart = productsInCart.Count;
            }
        }
        public static void RegAccount(string login, string password)
        {
            Repository repository = new Repository();
            repository.ReadFileJson();
            foreach (var user in peopleDataBase)
            {
                if (user.Login == login)
                {
                    //MessageBox.Show("Логин занят, введите другой");
                    Console.WriteLine("Логин занят, введите другой");
                    continue;
                }
                user.Id = peopleDataBase.Count;
            }
            repository.WriteFileJson(login, password);
        }
        public static void AutAccount(string login, string password)
        {
            Authorization authorization = new Authorization();
            foreach (var user in peopleDataBase)
            {
                if (user.Login == login && user.Password == password)
                {
                    UserControlStore.userId = user.Id;
                    //MessageBox.Show($"Добро пожаловать {user.Login}");
                    Console.WriteLine($"Добро пожаловать {user.Login}");
                    User.checkAuthorization = true;
                    if (login == "Admin" && password == "Admin")
                    {
                        User.checkAdmin = true;
                        new WorckerForm().Show();
                        break;
                    }
                    new MainWindow().Show();
                    break;
                }

            }
            if (User.checkAuthorization == false && User.checkAdmin == false)
            {
                //MessageBox.Show("Такого пользователя нет, зарегистрируйтесь или повторите попытку!");
                //Console.WriteLine("Такого пользователя нет, зарегистрируйтесь или повторите попытку!");
            }
        }

        public void WriteFileJsonProduct(string imagePath, string name, string description, int price, int maxAmount)
        {
            string productContentJson = File.ReadAllText(fileProductPath);
            if (!string.IsNullOrEmpty(productContentJson))
            {
                products = JsonConvert.DeserializeObject<List<Product>>(productContentJson);
            }
            ReadFileJson();
            products.Add(new Product(countIdProduct, imagePath, name, description, price,maxAmount));
            File.WriteAllText(fileProductPath, JsonConvert.SerializeObject(products));
            //Console.WriteLine("Продукт добавлен");
        }

        public void WriteFileJsonProductInCart(int userId, string imagePath, string name, string description, int price, int amount, int maxAmount)
        {
            string productInCart = File.ReadAllText(fileProductInCartPath);
            if (!string.IsNullOrEmpty(productInCart))
            {
                productsInCart = JsonConvert.DeserializeObject<List<ProductInCart>>(productInCart);
            }
            ReadFileJson();
            productsInCart.Add(new ProductInCart(userId, countIdProductInCart, imagePath, name, description, price, amount, maxAmount));
            File.WriteAllText(fileProductInCartPath, JsonConvert.SerializeObject(productsInCart));
            Console.WriteLine("Продукт добавлен в корзину");
        }

        public void ReloadFileJsonProduct(List<Product> products)
        {
            File.WriteAllText(fileProductPath, JsonConvert.SerializeObject(products));
            ReadFileJson();
            //Console.WriteLine("Продукт удален");

        }

        public void ReloadFileJsonProductInCart(List<ProductInCart> productInCart)
        {
            File.WriteAllText(fileProductInCartPath, JsonConvert.SerializeObject(productInCart));
            ReadFileJson();
            Console.WriteLine("Файл обновлен");
        }
        public void ReloadListView(ListView listView)
        {
            //string productInCart = File.ReadAllText(fileProductInCartPath);
            //if (!string.IsNullOrEmpty(productInCart))
            //{
            //    productsInCart = JsonConvert.DeserializeObject<List<ProductInCart>>(productInCart);
            //}
            //ReadFileJson();
            //productsInCart.Add(new ProductInCart(userId, countIdProductInCart, imagePath, name, description, price));
            //File.WriteAllText(fileProductInCartPath, JsonConvert.SerializeObject(productsInCart));
        }
    }
}