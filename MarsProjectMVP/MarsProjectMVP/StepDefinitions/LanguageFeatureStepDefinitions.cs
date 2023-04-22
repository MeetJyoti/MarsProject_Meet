using MarsProjectMVP.Pages;
using MarsProjectMVP.Utilities;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsProjectMVP.StepDefinitions
{
    [Binding]
    public class LanguageFeatureStepDefinitions : CommonDriver
    {
        LoginPage LoginPageObj = new LoginPage();
        Language languageObj = new Language();

        [Given(@"I Logged Into Mars Portal Successfully")]
        public void GivenILoggedIntoMarsPortalSuccessfully()
        {
            LoginPageObj.LoginActions(driver);
        }

       
        [When(@"Adding Language on my profile")]
        public void GivenAddingLanguageOnMyProfile()
        {
            LoginPageObj.LoginActions(driver);
            languageObj.AddingNewLanguage(driver);

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
            LoginPageObj.LoginActions(driver);
            languageObj.AddingPreExistingLanguage(driver);
        }

        [Then(@"Should result in a notification ""([^""]*)""")]
        public void ThenShouldResultInANotification(string p0)
        {
            string DuplicateLanguage= languageObj.WindowPopExistingLanguage(driver);
            Assert.That(DuplicateLanguage == "Duplicated data", "English has been added to your languages");
        }


    }
}
