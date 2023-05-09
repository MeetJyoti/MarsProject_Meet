using MarsProjectMVP.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProjectMVP.Pages
{
    public class LoginPage : CommonDriver
    {


        //Login Functionality

        public readonly By _signInButton = By.CssSelector("[class=\"item\"]");
        public readonly By _emailInput = By.Name("email");
        public readonly By _passwordInput = By.Name("password");
        public readonly By _rememberMeCheckbox = By.Name("rememberDetails");
        public readonly By _loginButton = By.XPath("//*[contains(text(),'Login')]");

        public void Login(string email, string password)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/Home");

            driver.FindElement(_signInButton).Click();
            driver.FindElement(_emailInput).SendKeys(email);
            driver.FindElement(_passwordInput).SendKeys(password);
            driver.FindElement(_rememberMeCheckbox).Click();
            driver.FindElement(_loginButton).Click();
        }
    }



}



