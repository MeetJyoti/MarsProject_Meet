using MarsProjectMVP.Pages;
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
        [BeforeScenario]
        public void BeforeScenarioWithTag()
        {
            driver = new ChromeDriver();
            LoginPage LoginPageObj = new LoginPage();
            LoginPageObj.LoginActions(driver);
            CreateNew createNewObj = new CreateNew();
            Education educationObj = new Education();
            Language languageObj = new Language();



        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}