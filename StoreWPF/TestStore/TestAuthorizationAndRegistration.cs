using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreWPF;
using System;
using System.Globalization;

namespace TestStore
{
    [TestClass]
    public class TestAuthorizationAndRegistration
    {
        [TestMethod]
        public void TestEnterUserInAccount()
        {
            //Arrange
            User user = new User(1, "qwe", "1");
            Repository repository = new Repository();
            //Act 
            repository.ReadFileJson();
            string login = user.Login; string password = user.Password;
            Repository.AutAccount(login, password);
            bool result = login == user.Login && password == user.Password;
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestEnterAdminInAccount()
        {
            //Arrange
            User user = new User(0, "Admin", "Admin");
            Repository repository = new Repository();
            //Act
            repository.ReadFileJson();
            string login = user.Login; string password = user.Password;
            Repository.AutAccount(login, password);
            bool result = login == user.Login && password == user.Password;
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CheckEnterInAccauntNotRightLogin()
        {
            //Arrange
            Repository repository = new Repository();
            User user = new User(1, "qwezxcasd", "1");
            //Act
            repository.ReadFileJson();
            int id = user.Id; string login = user.Login; string password = user.Password;
            bool result = id == user.Id && login == user.Login && password == user.Password;
            Repository.AutAccount(login, password);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestRegistrationUser()
        {
            //Arrange
            Repository repository = new Repository();
            //Act
            repository.ReadFileJson();
            int id = 3; string login = "asd"; string password = "1";
            Repository.RegAccount(login, password);
            User user = new User(3, login, password);
            bool result = id == user.Id && login == user.Login && user.Password == password;
            repository.ReadFileJson();
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestRegAccountError()
        {
            //Arrange
            Repository repository = new Repository();
            User user = new User(1, "qwe", "1");
            string login = user.Login; string password = user.Password;
            bool result = login == user.Login && password == user.Password;
            //Act
            repository.ReadFileJson();
            Repository.RegAccount(login, password);
            //Accert
            Assert.IsTrue(result);
        }
    }
}
