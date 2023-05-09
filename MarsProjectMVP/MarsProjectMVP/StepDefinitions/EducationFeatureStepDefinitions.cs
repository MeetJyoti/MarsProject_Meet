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
        
        Education educationObj = new Education();

        [Given(@"I Logged Into Mars Portal")]
        public void GivenILoggedIntoMarsPortal()
        {
           
        }

        [When(@"I add new Education and Details")]
        public void WhenIAddNewEducationAndDetails()
        {
            
            educationObj.AddingNewEducation("Massey", "Information Science");
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
            //educationObj.AddingSameUniversityDifferentCountry();
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
            educationObj.AddingNewEducation("Massey", "Information Science");
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
            educationObj.EditingEducation("Canterbury", "Marketing");
        }

        [Then(@"The record should have Edited successfully")]
        public void ThenTheRecordShouldHaveEditedSuccessfully()
        {
            string EditingEducation = educationObj.WindowPopEducationEdit(driver);
            Assert.That(EditingEducation == "Education as been updated", "Education not Edited - Error");
        }

        [When(@"I Delete the existing Education")]
        public void WhenIDeleteTheExistingEducation()
        {
            educationObj.DeletingEducation(driver);
        }

        [Then(@"The record should have Deleted successfully")]
        public void ThenTheRecordShouldHaveDeletedSuccessfully()
        {
            string DeletingEducation = educationObj.WindowPopEducationDelete(driver);
            Assert.That(DeletingEducation == "Education entry successfully removed", "Education entry not removed - Error");
        }
    }
}
