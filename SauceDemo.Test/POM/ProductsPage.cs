using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SauceDemo.Test.POM
{
    public class ProductsPage
    {

        private IWebDriver driver { get; }

        public ProductsPage(IWebDriver _driver)
        {
            driver = _driver;
        }

        public IWebElement Backpack => driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
        public IWebElement BikeLight => driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light"));
        public IWebElement TShirt => driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt"));
        public IWebElement Container => driver.FindElement(By.ClassName("shopping_cart_badge"));

        public bool DisplayedBackpack() => Backpack.Displayed;
        public bool DisplayedBikeLight() => BikeLight.Displayed;
        public bool DisplayedLoginTShir() => TShirt.Displayed;
        public bool DisplayedContainer() => Container.Displayed;

        public void AddItems()
        {
            Backpack.Click();
            BikeLight.Click();
            TShirt.Click();

        }

       

    }
}
