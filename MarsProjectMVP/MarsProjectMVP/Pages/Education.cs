using MarsProjectMVP.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace MarsProjectMVP.Pages
{
    public class Education: CommonDriver
    {
        private IWebElement _addNewButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
        private IWebElement _collegeNameInput => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
        private IWebElement _countryDropdown => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
        private IWebElement _nzCountryOption => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[102]"));
        private IWebElement _titleDropdown => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
        private IWebElement _btechOption => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[7]"));
        private IWebElement _degreeInput => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
        private IWebElement _yearOfGraduationDropdown => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
        private IWebElement _selectYearOption => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[4]"));
        private IWebElement _addButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));



        public void AddingNewEducation(string Collegename, string Degree)
        {
            Thread.Sleep(2000);
            Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 5);
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")).Click();

            _addNewButton.Click();

            Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input", 5);
            _collegeNameInput.Click();


            Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input", 5);

            _collegeNameInput.SendKeys(Collegename);

            Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select", 5);
            _countryDropdown.Click();

            Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[102]", 5);
            _nzCountryOption.Click();

            Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select", 5);
            _titleDropdown.Click();

            Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[7]", 5);
            _btechOption.Click();

            Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input", 5);
            _degreeInput.SendKeys(Degree);

            Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select", 5);
            _yearOfGraduationDropdown.Click();

            Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[4]", 5);
            _selectYearOption.Click();

            Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]", 5);
            _addButton.Click();


        }


        public string WindowPopEducationAdded(IWebDriver driver)
        {
            Thread.Sleep(1000);
            Wait.WaitToBeClicakble(driver, "CssSelector", "body > div.ns-box.ns-growl.ns-effect-jelly.ns-type-success.ns-show > div", 5);

            IWebElement AddAlert = driver.FindElement(By.CssSelector("body > div.ns-box.ns-growl.ns-effect-jelly.ns-type-success.ns-show > div"));
            return AddAlert.Text;

        }

        //public void AddingSameUniversityDifferentCountry(IWebDriver driver)
        //{
        //    Thread.Sleep(2000);
        //    Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 5);
        //    driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")).Click();

        //    IWebElement AddNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
        //    AddNewButton.Click();

        //    Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input", 5);
        //    IWebElement CollegeName = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
        //    CollegeName.Click();
        //    CollegeName.SendKeys("Massey");

        //    Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select", 5);

        //    IWebElement Country = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
        //    Country.Click();

        //    Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[66]", 5);

        //    IWebElement IndiaCountry = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[66]"));
        //    IndiaCountry.Click();

        //    IWebElement Title = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
        //    Title.Click();

        //    Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[7]", 5);

        //    IWebElement Btech = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[7]"));
        //    Btech.Click();

        //    Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input", 5);

        //    IWebElement Degree = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
        //    Degree.SendKeys("Information Science");

        //    Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select", 5);

        //    IWebElement YearOfGraduation = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
        //    YearOfGraduation.Click();

        //    IWebElement SelectYear = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[4]"));
        //    SelectYear.Click();


        //    IWebElement Add = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
        //    Add.Click();

        //    Thread.Sleep(2000);

        //}

        public string WindowPopDifferentEducationAdded(IWebDriver driver)
        {
            Wait.WaitToBeClicakble(driver, "CssSelector", "body > div.ns-box.ns-growl.ns-effect-jelly.ns-type-success.ns-show", 5);

            IWebElement AddAlert = driver.FindElement(By.CssSelector("body > div.ns-box.ns-growl.ns-effect-jelly.ns-type-success.ns-show"));
            return AddAlert.Text;

        }

        //invalid input - should throw notification popup window

        public string WindowPopEducationAlreadyExist(IWebDriver driver)
        {
            Wait.WaitToBeClicakble(driver, "CssSelector", "body > div.ns-box.ns-growl.ns-effect-jelly.ns-type-error.ns-show", 5);
            Thread.Sleep(1000);
            IWebElement AddAlert = driver.FindElement(By.CssSelector("body > div.ns-box.ns-growl.ns-effect-jelly.ns-type-error.ns-show"));
            return AddAlert.Text;

        }
        public void EditingEducation(string Collegename, string Degree)
        {
            Thread.Sleep(2000);
            Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 5);
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")).Click();

            Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td[6]/span[1]/i", 5);
            IWebElement EditButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td[6]/span[1]/i"));
            EditButton.Click();

            Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td/div[1]/div[1]/input", 5);

            IWebElement CollegeEdit = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td/div[1]/div[1]/input"));
            CollegeEdit.Click();
            CollegeEdit.Clear();
            CollegeEdit.SendKeys(Collegename);


            IWebElement EditCourse = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td/div[2]/div[2]/input"));
            EditCourse.Click();
            EditCourse.Clear();
            EditCourse.SendKeys(Degree);

            IWebElement Update = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td/div[3]/input[1]"));
            Update.Click();
            Thread.Sleep(2000);

        }
        public string WindowPopEducationEdit(IWebDriver driver)
        {
            Wait.WaitToBeClicakble(driver, "CssSelector", "body > div.ns-box.ns-growl.ns-effect-jelly.ns-type-success.ns-show > div", 5);

            IWebElement EditAlert = driver.FindElement(By.CssSelector("body > div.ns-box.ns-growl.ns-effect-jelly.ns-type-success.ns-show > div"));
            return EditAlert.Text;

        }

        public void DeletingEducation(IWebDriver driver)
        {
            Thread.Sleep(2000);
            Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 5);
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")).Click();

            Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td[6]/span[2]/i", 5);
            IWebElement Delete = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td[6]/span[2]/i"));
            Delete.Click();

            Thread.Sleep(2000);

        }

        public string WindowPopEducationDelete(IWebDriver driver)
        {
            Wait.WaitToBeClicakble(driver, "CssSelector", "body > div.ns-box.ns-growl.ns-effect-jelly.ns-type-success.ns-show", 5);

            IWebElement DeleteAlert = driver.FindElement(By.CssSelector("body > div.ns-box.ns-growl.ns-effect-jelly.ns-type-success.ns-show"));
            return DeleteAlert.Text;

        }
    }
}