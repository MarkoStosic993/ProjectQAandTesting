using SauceDemo.Test.POM;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Xunit;

namespace SauceDemo.Test.TEST
{
    public class UserLoginTest : BaseTest
    {
        private readonly LoginPage loginPage;
        private readonly ProductsPage productsPage;
        private readonly BasketPage basketPage;


        public UserLoginTest()
        {
            loginPage = new LoginPage(Driver);
            productsPage = new ProductsPage(Driver);
            basketPage = new BasketPage(Driver);
        }

        [Fact(DisplayName = "Login User")]
        public void WhenClickOnLoginLink_UserShoulLogin()
        {
            //Arrange
            Navigate();

            //act
            loginPage.LogIn("standard_user", "secret_sauce");
            Thread.Sleep(3000);

            //assert

            Assert.Equal("https://www.saucedemo.com/inventory.html", Driver.Url);
        }



        
        [Theory(DisplayName = "Failed Login User")]
        [InlineData("mkdsfljgj", "kjhkjhkj")]
        [InlineData("hjhgj", "opfgfdkgm")]
        [InlineData("jfdfgkj", "kjkjhkj")]

        public void WhenClickOnLoginLink_UserdFailedLogin(string userName, string password)
        {
            //Arrange
            Navigate();



            //Act
            loginPage.LogIn(userName, password);

            Thread.Sleep(3000);

            //Assert
            Assert.Equal("https://www.saucedemo.com/", Driver.Url);
        }


        [Fact(DisplayName = "Check number")]
        public void WhenClickOnButton_CheckNumber()
        {
            //Arrange
            Navigate();

            //act
            loginPage.LogIn("standard_user", "secret_sauce");
            
            productsPage.AddItems();

            Thread.Sleep(3000);
            string k = productsPage.Container.Text;



            //assert

            Assert.Equal("3",k);
        }

        [Fact(DisplayName = "Remove items")]
        public void WhenClickOnButton_RemoveItems()
        {
            //Arrange
            Navigate();

            //act
            loginPage.LogIn("standard_user", "secret_sauce");

            productsPage.AddItems();

            Thread.Sleep(3000);

            basketPage.GoAndRemove();

            Thread.Sleep(3000);

            string t = basketPage.Container1.Text;

            basketPage.Back();

            Thread.Sleep(3000);


            //assert

            Assert.Equal("", t);
        }
    }
}
