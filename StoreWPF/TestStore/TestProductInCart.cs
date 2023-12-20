using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreWPF;
using System;

namespace TestStore
{
    [TestClass]
    public class TestProductInCart
    {
        [TestMethod]
        public void TestAddProductInCart()
        {
            //Assert
            Repository repository = new Repository();
            //Act
            repository.WriteFileJsonProductInCart(1, @"C:\Users\alexc\OneDrive\Изображения\Saved Pictures\fonRevork.jpeg", "Рай", "Туда мне нада", 1000000000, 1, 1);
            //Arrange
        }
        [TestMethod]
        public void TestRemoveProductInCart() 
        {
            //Assert
            Repository repository = new Repository();
            //Act
            int idDeleteProduct = 0;
            repository.ReadFileJson();
            Repository.productsInCart.RemoveAt(idDeleteProduct);
            repository.ReloadFileJsonProductInCart(Repository.productsInCart);
            //Arrange
        }
    }
}
