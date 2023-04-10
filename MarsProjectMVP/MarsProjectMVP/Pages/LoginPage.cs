using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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
        public void LoginActions(IWebDriver driver)
        {

            //Login Functionality
            
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("http://localhost:5000/");
            Thread.Sleep(1000);

            Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"home\"]/div/div/div[1]/div/a", 5);
            IWebElement signin = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            signin.Click();

            IWebElement emailID = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            emailID.SendKeys("shahmeetnz@gmail.com");

            IWebElement password = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            password.SendKeys("123456");

            IWebElement loginbutton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginbutton.Click();
            

        }
    }
}
            

            //-------------------------------

            //driver.Quit(); 