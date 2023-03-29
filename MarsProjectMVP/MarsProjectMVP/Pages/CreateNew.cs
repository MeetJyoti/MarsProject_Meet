using MarsProjectMVP.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProjectMVP.Pages
{
    public class CreateNew : CommonDriver
    {
        public void AddingNewSkills(IWebDriver driver)
        {
            //-----ADD Skill ----------

            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"))
                .Click();
                
            IWebElement AddnewSkills = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddnewSkills.Click();
            Thread.Sleep(3000);

            IWebElement TypeSkills = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            TypeSkills.SendKeys("Python");

            IWebElement dropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            dropdown.Click();

            IWebElement chooseBeginner = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[2]"));
            chooseBeginner.Click();

            IWebElement AddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            AddButton.Click();
            Thread.Sleep(2000);

        }
        //Confirming that the record is created - Skills - Python(Beginner)
        public string GetSkills(IWebDriver driver)
        {
            IWebElement actualSkills = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            return actualSkills.Text;
        }


    }
}
