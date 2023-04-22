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
            CreateNew createNewObj = new CreateNew();
            
            
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}