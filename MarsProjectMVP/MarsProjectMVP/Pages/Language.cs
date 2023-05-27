using MarsProjectMVP.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MarsProjectMVP.Pages
{
    public class Language : CommonDriver
    {
        public IWebElement AddnewButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        public IWebElement AddnewLanguage => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
        public IWebElement LanguageLevel => driver.FindElement(By.Name("level"));
        public IWebElement Fluent => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[4]"));
        public IWebElement AddLanguage => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));


        public void AddNewLanguage(IWebDriver driver, string LanguageAdd, string ChooseLanguageLevel)
        {
            Thread.Sleep(2000);
            Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]", 5);
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]")).Click();

            AddnewButton.Click();

            Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input", 5);
            AddnewLanguage.Click();
            AddnewLanguage.SendKeys(LanguageAdd);

            LanguageLevel.Click();
            Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[4]", 5);
            SelectElement CLL = new SelectElement(LanguageLevel);
            Thread.Sleep(2000);
            CLL.SelectByValue(ChooseLanguageLevel);

            AddLanguage.Click();

            Thread.Sleep(2000);
        }

        public string GetLanguage(IWebDriver driver)
        {
            Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]", 5);
            IWebElement actualLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            return actualLanguage.Text;
        }//*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]




        public string WindowPopExistingLanguage(IWebDriver driver)
        {
            Wait.WaitToBeClicakble(driver, "CssSelector", "body > div.ns-box.ns-growl.ns-effect-jelly.ns-type-error.ns-show > div", 5);
            IWebElement DuplicateAlert = driver.FindElement(By.CssSelector("body > div.ns-box.ns-growl.ns-effect-jelly.ns-type-error.ns-show > div"));
            return DuplicateAlert.Text;



        }

    

    }
}
    
