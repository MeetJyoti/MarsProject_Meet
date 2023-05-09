using MarsProjectMVP.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsProjectMVP.Pages
{
    public class CreateNew : CommonDriver
    {
       

        public IWebElement addNewSkillsButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
        public IWebElement addNewSkillsHeader => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
        public IWebElement skillsInput => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
        public IWebElement skillsLevelDropdown => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
        public IWebElement beginnerOption => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[2]"));
        public IWebElement addButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));

    

        public void AddingNewSkills(string skills)
        {
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")).Click();
            addNewSkillsButton.Click();

            Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div", 5);
            addNewSkillsHeader.Click();

            Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input", 5);
            skillsInput.SendKeys(skills);

            Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select", 5);
            skillsLevelDropdown.Click();

            Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[2]", 5);
            beginnerOption.Click();

            Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]", 5);
            addButton.Click();



        }

        //Confirming that the record is created - Skills - Python(Beginner)
        public string GetSkills(IWebDriver driver)
        {
            IWebElement actualSkills = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            return actualSkills.Text;
        }

        

        public string WindowPopDuplicateSkill(IWebDriver driver)
        {
            IWebElement DuplicateAlert = driver.FindElement(By.CssSelector("body > div.ns-box.ns-growl.ns-effect-jelly.ns-type-error.ns-show > div"));
            return DuplicateAlert.Text;

        }


        public void EditSkills(IWebDriver driver)
        {
            Thread.Sleep(2000);
            Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 5);
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")).Click();
            Thread.Sleep(2000);
            Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i", 5);
            IWebElement editButtonn = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            editButtonn.Click();

            Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input", 5);
            IWebElement textChange = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            textChange.Click();
            textChange.Clear();
            textChange.SendKeys("Java");

            Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]", 5);
            IWebElement update = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            update.Click();
            Thread.Sleep(2000);

        }

        public string EditedSkills(IWebDriver driver)
        {
            IWebElement SkillsEditedText = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            return SkillsEditedText.Text;
        }


        public void DeleteSkills(IWebDriver driver)
        {
            Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 5);
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")).Click();

            Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i", 5);
            IWebElement Deleterecord = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            Deleterecord.Click();
            Thread.Sleep(1000);

        }

        public string WindowPop(IWebDriver driver)
        {
            IWebElement DeleteAlert = driver.FindElement(By.CssSelector("[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]"));
            return DeleteAlert.Text;

        }

       


    }
}
