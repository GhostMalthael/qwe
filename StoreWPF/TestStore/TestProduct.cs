using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreWPF;
using System;

namespace TestStore
{
    [TestClass]
    public class TestProduct
    {
        [TestMethod]
        public void TestAddProductInAdminAccaunt()
        {
            //Arrange
            Repository repository = new Repository();
            //Act
            repository.ReadFileJson();
            repository.WriteFileJsonProduct(@"C:\Users\alexc\OneDrive\Изображения\Saved Pictures\frog.jpg", "Лягушка", "Просто прикольная лягушка", 99999999, 10);
            //Assert
        }
        [TestMethod]
        public void TestDeleteProductInAdminAccaunt()
        {
            //Arrange
            Repository repository = new Repository();
            //Act
            repository.ReadFileJson();
            int idDeleteProduct = 6;
            Repository.products.RemoveAt(idDeleteProduct);
            repository.ReloadFileJsonProduct(Repository.products);
            repository.ReadFileJson();
            //Assert
        }
        [TestMethod]
        public void TestEditProductInAdminAccaunt()
        {
            //Arrange
            Repository repository = new Repository();
            //Act
            repository.ReadFileJson();
            int idEditProduct = 5;
            Repository.products.RemoveAt(idEditProduct);
            Repository.products.Add(new Product(idEditProduct, @"C:\Users\alexc\OneDrive\Изображения\Saved Pictures\frog.jpg", "Лягушка", "Просто прикольная лягушка", 99999999, 1000));
            repository.ReloadFileJsonProduct(Repository.products);
            //Assert
        }
    }
}
