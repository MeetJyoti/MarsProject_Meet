using MarsProjectMVP.Pages;
using MarsProjectMVP.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsProjectMVP.StepDefinitions
{
    [Binding]
    public class LanguageFeatureStepDefinitions : Hooks
    {
       

        [Given(@"I Logged Into Mars App")]
        public void GivenILoggedIntoMarsPortalApp()
        {
            // Code for the step definition
        }

        [When(@"Adding Language on my profile, '([^']*)', '([^']*)'")]
        public void WhenAddingLanguageOnMyProfile(string LanguageAdd, string ChooseLanguageLevel)
        {
            languageObj.AddNewLanguage(driver, LanguageAdd, ChooseLanguageLevel);
        }

        [Then(@"The language should be added succesfully")]
        public void ThenTheLanguageShouldBeAddedSuccessfully()
        {
            string newLanguage = languageObj.GetLanguage(driver);
            Assert.That(newLanguage == "English" || newLanguage == "Spanish", "Actual Language and selected Language do not match.");
        }

        [When(@"Pre Existing record is entered, '([^']*)', '([^']*)'")]
        public void WhenPreExistingRecordIsEntered(string LanguageAdd, string ChooseLanguageLevel)
        {
            languageObj.AddNewLanguage(driver, LanguageAdd, ChooseLanguageLevel);
        }

        [Then(@"Should result in a notification")]
        public void ThenShouldResultInANotification()
        {
            string DuplicateLanguage = languageObj.WindowPopExistingLanguage(driver);
            Assert.That(DuplicateLanguage == "This language is already exist in your language list.", "English has been added to your languages");
        }
    }
}
