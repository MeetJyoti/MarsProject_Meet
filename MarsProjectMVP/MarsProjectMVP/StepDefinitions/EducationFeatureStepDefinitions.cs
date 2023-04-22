using MarsProjectMVP.Pages;
using MarsProjectMVP.Utilities;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsProjectMVP.StepDefinitions
{
    [Binding]
        
    public class EducationFeatureStepDefinitions: CommonDriver
    {
        LoginPage LoginPageObj = new LoginPage();
        Education educationObj = new Education();

        [Given(@"I Logged Into Mars Portal")]
        public void GivenILoggedIntoMarsPortal()
        {
            LoginPageObj.LoginActions(driver);
        }

        [When(@"I add new Education and Details")]
        public void WhenIAddNewEducationAndDetails()
        {
            
            educationObj.AddingNewEducation(driver);
        }

        [Then(@"The Education record should be added successfully")]
        public void ThenTheEducationRecordShouldBeAddedSuccessfully()
        {
            string EducatioNDetails = educationObj.WindowPopEducationAdded(driver);
            Assert.That(EducatioNDetails == "Education has been added", "Education Record not added - Error");
        }

        [When(@"I add Same University Name and Different Country")]
        public void WhenIAddSameUniversityNameAndDifferentCountry()
        {
            educationObj.AddingSameUniversityDifferentCountry(driver);
        }

        [Then(@"The record should have added successfully")]
        public void ThenTheRecordShouldHaveAddedSuccessfully()
        {
            string DifferentEducationDetails = educationObj.WindowPopDifferentEducationAdded(driver);
            Assert.That(DifferentEducationDetails == "Education has been added", "Education Record not added - Error");
        }

        [When(@"I add  existing Education")]
        public void WhenIAddExistingEducation()
        {
            educationObj.AddingExistingEducation(driver);
        }

        [Then(@"The record should throw notification and should not add")]
        public void ThenTheRecordShouldThrowNotificationAndShouldNotAdd()
        {
            string ExistingEducation = educationObj.WindowPopEducationAlreadyExist(driver);
            Assert.That(ExistingEducation == "This information is already exist.", "Education Record  Added - Error");
        }

        [When(@"I Edit the existing Education")]
        public void WhenIEditTheExistingEducation()
        {
            throw new PendingStepException();
        }

        [Then(@"The record should have Edited successfully")]
        public void ThenTheRecordShouldHaveEditedSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"I Delete the existing Education")]
        public void WhenIDeleteTheExistingEducation()
        {
            throw new PendingStepException();
        }

        [Then(@"The record should have Deleted successfully")]
        public void ThenTheRecordShouldHaveDeletedSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
