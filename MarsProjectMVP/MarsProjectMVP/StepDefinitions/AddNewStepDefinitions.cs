using MarsProjectMVP.Pages;
using MarsProjectMVP.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Security.AccessControl;
using TechTalk.SpecFlow;

namespace MarsProjectMVP.StepDefinitions
{


    [Binding]
    public class AddNewStepDefinitions : CommonDriver
    {
        LoginPage LoginPageObj = new LoginPage();
        CreateNew createNewObj = new CreateNew();
        


        [Given(@"I logged into Mars application")]
        public void GivenILoggedIntoMarsApplication()
        {
            
            LoginPageObj.LoginActions(driver);
        }

        [When(@"I add new Skills and Level")]
        public void WhenIAddNewSkillsAndLevel()
        {
            CreateNew createNewObj = new CreateNew();
            createNewObj.AddingNewSkills(driver);
        }

        [Then(@"The record should be added successfully")]
        public void ThenTheRecordShouldBeAddedSuccessfully()
        {
            string newSkills = createNewObj.GetSkills(driver);

            Assert.That(newSkills == "Python", "Actual Skills and selected Skills do not match.");


        }

        [When(@"I edit the existing skills")]
        public void WhenIEditTheExistingSkills()
        {
            createNewObj.EditSkills(driver);


        }

        [Then(@"The record should have edited successfully")]
        public void ThenTheRecordShouldHaveEditedSuccessfully()
        {
            string newEditedSkills = createNewObj.EditedSkills(driver);

            Assert.That(newEditedSkills == "Java", "Actual Skills and selected Skills do not match.");
        }

        [When(@"I delete the existing skill")]
        public void WhenIDeleteTheExistingSkill()
        {
            createNewObj.DeleteSkills(driver);
        }

        [Then(@"The record should have deleted successfully")]
        public void ThenTheRecordShouldHaveDeletedSuccessfully()
        {
            string deleteSkill = createNewObj.WindowPop(driver);
            Assert.That(deleteSkill == "Java has been deleted", "Failed to deleted the skill");
        }
        

    }
}