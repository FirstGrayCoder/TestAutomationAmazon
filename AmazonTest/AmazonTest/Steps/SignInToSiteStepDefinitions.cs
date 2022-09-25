using AmazonTest.Drivers;
using AmazonTest.PageObjects;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AmazonTest.Steps
{
    [Binding]
    public class SignInToSiteStepDefinitions
    {
        [Given(@"I open sign in page of site")]
        public void GivenIOpenSignInPageOfSite()
        {
            SignInPageObject.Instance.OpenSignInPage();
        }

        [When(@"I input '([^']*)' to inpun field")]
        public void InputEmailToInpunField(string email)
        {
            SignInPageObject.Instance.FillEmailField(email);
        }

        [When(@"I push Continue button")]
        public void PushContinueButton()
        {
            SignInPageObject.Instance.PressContinueButton();
        }

        [Then(@"Page for input password shoul be opened")]
        public void PageForInputPasswordShoulBeOpened()
        {
            Assert.IsTrue(SignInPageObject.Instance.IsDisplayedPasswordField(), "Page with password field not displayed");
        }

        [Then(@"I input '([^']*)' to inpun field")]
        public void InputPasswordToInpunField(string password)
        {
            SignInPageObject.Instance.FillPasswordField(password);
        }

        [Then(@"I push SignIn button")]
        public void ThenIPushSignInButton()
        {
            SignInPageObject.Instance.PressSignInButton();
        }

        [Then(@"Home page with '([^']*)' should be opened")]
        public void ThenHomePageWithShouldBeOpened(string userName)
        {
            Assert.IsTrue(SignInPageObject.Instance.IsDisplayedUserName(userName), "Page with user name not displayed");
        }

        [AfterScenario]
        public static void AfterTestRun()
        {
            DriverManager.QuitDriver();
        }
    }
}
