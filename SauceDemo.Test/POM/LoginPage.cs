using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SauceDemo.Test.POM
{
    public class LoginPage
    {

        private IWebDriver driver { get; }

        public LoginPage(IWebDriver _driver)
        {
            driver = _driver;
        }

        public IWebElement Username => driver.FindElement(By.Id("user-name"));
        public IWebElement Password => driver.FindElement(By.Id("password"));
        public IWebElement LoginButton => driver.FindElement(By.Id("login-button"));


        public bool DisplayedUsername() => Username.Displayed;
        public bool DisplayedPassword() => Password.Displayed;
        public bool DisplayedLoginButton() => LoginButton.Displayed;

        public void LogIn(string username_input, string passwird_input)
        {
            Username.SendKeys(username_input);
            Password.SendKeys(passwird_input);
            LoginButton.Click();
        }


    }
}
