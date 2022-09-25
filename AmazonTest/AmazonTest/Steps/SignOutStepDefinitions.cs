using AmazonTest.Drivers;
using AmazonTest.PageObjects;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AmazonTest.Steps
{
    [Binding]
    public class SignOutStepDefinitions
    {
        [Given(@"Home page after succesefull avtorisation with valid '([^']*)' and '([^']*)'")]
        public void HomePageAfterSuccesefullAvtorisationWithValidAnd(string p0, string p1)
        {
            LoginedHomePageObject.Instance.LoginedHomePage(p0, p1);
            //HomePageObject.Instance.OpenHomePage();
        }

        [When(@"I move mouse to my user '([^']*)'")]
        public void WhenIMoveMouseToMyUser(string userName)
        {
            LoginedHomePageObject.Instance.MoveToLoginName(userName);
        }
        [When(@"I click on LogOut button from dropdown menu")]
        public void WhenIClickOnLogOutButtonFromDropdownMenu()
        {
            LoginedHomePageObject.Instance.ClickSignOut();
        }

        [Then(@"SignIn page should be opened")]
        public void ThenSignInPageShouldBeOpened()
        {
            Assert.IsTrue(SignInPageObject.Instance.IsDisplayedEmailField());
        }

        [AfterScenario]
        public static void AfterTestRun()
        {
            DriverManager.QuitDriver();
        }
    }
}
