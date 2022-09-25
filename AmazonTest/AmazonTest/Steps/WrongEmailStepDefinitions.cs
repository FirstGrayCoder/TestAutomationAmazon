using AmazonTest.Drivers;
using AmazonTest.PageObjects;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace AmazonTest.Steps
{
    [Binding]
    public class WrongEmailStepDefinitions
    {
        [Given(@"I open SignIn page")]
        public void OpenSignInPage()
        {
            SignInPageObject.Instance.OpenSignInPage();
        }

        [When(@"I input wrong '([^']*)' to input field")]
        public void WhenIInputWrongToInputField(string email)
        {
            SignInPageObject.Instance.FillEmailField(email);
        }

        [When(@"I push Continue button with wrong password")]
        public void WhenIPushContinueButtonWithWrongPassword()
        {
            SignInPageObject.Instance.PressContinueButton();
        }

        [Then(@"Caution message should be appeard")]
        public void ThenCautionMessageShouldBeAppeard()
        {
            Assert.IsTrue(SignInPageObject.Instance.IsDisplayedMessageWrongEmail(), "Caution message not displayed");
        }

        [AfterScenario]
        public static void AfterTestRun()
        {
            DriverManager.QuitDriver();
        }
    }
}
