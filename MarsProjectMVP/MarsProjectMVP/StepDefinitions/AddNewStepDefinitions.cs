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
    public class AddNewStepDefinitions : Hooks
    {

        [Given(@"I Logged Into Mars Portal")]
        public void GivenILoggedIntoMarsPortal()
        {

        }
        [When(@"I add new Skills and Level")]
        public void WhenIAddNewSkillsAndLevel()
        {
            
            createNewObj.AddingNewSkills("Python");
        }

        [Then(@"The record should be added successfully")]
        public void ThenTheRecordShouldBeAddedSuccessfully()
        {

            string newSkills = createNewObj.GetSkills(driver);

            Assert.That(newSkills == "Python", "Actual Skills and selected Skills do not match.");
        }


        [When(@"I add Existing Skills")]
        public void WhenIAddExistingSkills()
        {
            
            createNewObj.AddingNewSkills("Python");
        }

        [Then(@"The record should not be added successfully, should throw notofication")]
        public void ThenTheRecordShouldNotBeAddedSuccessfullyShouldThrowNotofication()
        {
                
                string DuplicateSkill = createNewObj.WindowPopDuplicateSkill(driver);
                Assert.That(DuplicateSkill == "This skill is already exist in your skill list.", "Skills Added");
            
        }


        [When(@"I edit the existing skills, '([^']*)', '([^']*)'")]
        public void WhenIEditTheExistingSkills(string AddSkill, string SkillLevel)
        {
            createNewObj.EditeSkills(driver, AddSkill, SkillLevel);
        }





        [Then(@"The record should have edited successfully")]
        public void ThenTheRecordShouldHaveEditedSuccessfully()
        {
            string newEditedSkills = createNewObj.EditedSkills(driver);

            Assert.That(newEditedSkills == "Java" || newEditedSkills == "Speckflow", "Actual Skills and selected Skills do not match.");
        }

        [When(@"I delete the existing skill")]
        public void WhenIDeleteTheExistingSkill()
        {
            createNewObj.DeleteSkills();
        }

        [Then(@"The record should have deleted successfully")]
        public void ThenTheRecordShouldHaveDeletedSuccessfully()
        {
            string deleteSkill = createNewObj.WindowPop(driver);
            Assert.That(deleteSkill == "Java has been deleted", "Failed to deleted the skill");
        }
        

    }
}