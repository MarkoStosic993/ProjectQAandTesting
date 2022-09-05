using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SauceDemo.Test.POM
{
    public class BasketPage
    {
        private IWebDriver driver { get; }

        public BasketPage(IWebDriver _driver)
        {
            driver = _driver;
        }

        public IWebElement Backpack => driver.FindElement(By.Id("remove-sauce-labs-backpack"));
        public IWebElement BikeLight => driver.FindElement(By.Id("remove-sauce-labs-bike-light"));
        public IWebElement TShirt => driver.FindElement(By.Id("remove-sauce-labs-bolt-t-shirt"));
        public IWebElement Container1 => driver.FindElement(By.ClassName("shopping_cart_container"));
        public IWebElement Shoping => driver.FindElement(By.Id("continue-shopping"));

        public bool DisplayedBackpack() => Backpack.Displayed;
        public bool DisplayedBikeLight() => BikeLight.Displayed;
        public bool DisplayedLoginTShir() => TShirt.Displayed;
        public bool DisplayedContainer1() => Container1.Displayed;
        public bool DisplayedShoping() => Shoping.Displayed;


        public void GoAndRemove()
        {
            Container1.Click();
            Backpack.Click();
            BikeLight.Click();
            TShirt.Click();
            
        }

        public void Back()
        {
            Shoping.Click();

        }
    }
}
