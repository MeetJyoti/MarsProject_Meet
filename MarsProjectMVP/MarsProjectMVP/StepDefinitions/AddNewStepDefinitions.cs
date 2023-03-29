using MarsProjectMVP.Pages;
using MarsProjectMVP.Utilities;
using NUnit.Framework;
using System;
using System.Security.AccessControl;
using TechTalk.SpecFlow;

namespace MarsProjectMVP.StepDefinitions
{


    [Binding]
    public class AddNewStepDefinitions: CommonDriver
    {
        LoginPage LoginPageObj = new LoginPage();
        CreateNew CreateNewObj = new CreateNew();
        

        [Given(@"I logged into Mars application")]
        public void GivenILoggedIntoMarsApplication()
        {
            
            LoginPageObj.LoginActions(driver);
        }

        [When(@"I add new Skills and Level")]
        public void WhenIAddnewSkillsandLevel()
        {
            
            CreateNewObj.AddingNewSkills(driver);
        } 

        [Then(@"The record should be added successfully")]
        public void ThenTheRecordShouldBeAddedSuccessfully()
        {
            string newSkills = CreateNewObj.GetSkills(driver);

            Assert.That(newSkills == "Python", "Actual Skills and selected Skills do not match.");


        }
    }
}
