using MarsProjectMVP.Pages;
using MarsProjectMVP.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsProjectMVP.StepDefinitions
{
    [Binding]
    public class LanguageFeatureStepDefinitions : CommonDriver
    {
        
        Language languageObj = new Language();

        [Given(@"I Logged Into Mars Portal Successfully")]
        public void GivenILoggedIntoMarsPortalSuccessfully()
        {
            
        }

       
        [When(@"Adding Language on my profile")]
        public void GivenAddingLanguageOnMyProfile()
        {
            
            languageObj.AddNewLanguage("English");

        }

        [Then(@"The language  should be added succesfully")]
        public void ThenTheLanguageShouldBeAddedSuccesfully()
        {
            string newLanguage = languageObj.GetLanguage(driver);

            Assert.That(newLanguage == "English", "Actual Skills and selected Skills do not match.");
        }
        [When(@"Pre Existing record is entered")]
        public void WhenPreExistingRecordIsEntered()
        {
            
            languageObj.AddNewLanguage("English");
        }

        [Then(@"Should result in a notification")]
        public void ThenShouldResultInANotification()
        {
            string DuplicateLanguage = languageObj.WindowPopExistingLanguage(driver);
            Assert.That(DuplicateLanguage == "This language is already exist in your language list.", "English has been added to your languages");
        }


    }
}
