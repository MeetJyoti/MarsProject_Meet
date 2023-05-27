using MarsProjectMVP.Pages;
using MarsProjectMVP.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsProjectMVP.Utilities
{
    [Binding]
    public class Hooks : CommonDriver
    {
        public readonly Language languageObj;
        public readonly CreateNew createNewObj;
        public readonly Education educationObj;

        public Hooks()
        {
            createNewObj = new CreateNew();
            languageObj = new Language();
            educationObj = new Education();

        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
                LoginPage LoginPageObj = new LoginPage();
                // LoginPageObj.LoginActions(driver);
                LoginPageObj.Login("shahmeetnz@gmail.com", "123456");
            }
        }


        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }


    }
}