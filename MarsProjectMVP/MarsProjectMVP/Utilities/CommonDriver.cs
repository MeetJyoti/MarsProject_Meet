using MarsProjectMVP.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V109.DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProjectMVP.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;

       
        public void ClosingSteps()
        {
            driver.Quit();
        }
    }

}

//[OneTimeSetUp]
//public void LoginSteps()
//{
//    driver = new ChromeDriver();

//    // Login page object initialization and definition
//    LoginPage loginPageObj = new LoginPage();
//    loginPageObj.LoginActions(driver);
//}


//[OneTimeTearDown]