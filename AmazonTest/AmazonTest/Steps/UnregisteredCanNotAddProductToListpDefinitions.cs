using AmazonTest.Drivers;
using AmazonTest.PageObjects;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AmazonTest.Steps
{
    [Binding]
    public class UnregisteredCanNotAddProductToListpDefinitions
    {
        [Given(@"I open page of product")]
        public void GivenIOpenPageOfProduct()
        {
            HeadPhoneProductPageObject.Instance.OpenProductPage();
        }

        [When(@"As unregistered user I push Add to List button")]
        public void WhenAsUnregisteredUserIPushAddToListButton()
        {
            HeadPhoneProductPageObject.Instance.ClickAddToListButton();
        }

        [Then(@"SignIn page should be opened for signin or register")]
        public void SignInPageShouldBeOpenedForSigninOrRegister()
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
