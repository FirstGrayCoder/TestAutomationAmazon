using AmazonTest.Drivers;
using AmazonTest.PageObjects;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AmazonTest.Steps
{
    [Binding]
    public class BuyProductStepDefinitions
    {
        [Given(@"I open product  page as registered user with valid '([^']*)' and '([^']*)'")]
        public void GivenIOpenProductPageAsRegisteredUserWithValidAnd(string email, string password)
        {
            LoginedHomePageObject.Instance.LoginedHomePage(email, password);
            LoginedHomePageObject.Instance.OpenProductPage();
        }

        [When(@"I change delivery country")]
        public void WhenIChangeDeliveryCountry()
        {
            HomePageObject.Instance.ChangeDeliveriCountry();
        }

        [When(@"I click Buy now button")]
        public void WhenIClickBuyNowButton()
        {
            HeadPhoneProductPageObject.Instance.ClickBuyNowButton();
        }

        [Then(@"Shipping page should be opened")]
        public void ThenShippingPageShouldBeOpened()
        {
            Assert.AreEqual(DriverManager.Instance().Url, HeadPhoneProductPageObject.Instance.IsDisplayedRightUrl());
        }

        [AfterScenario]
        public static void AfterTestRun()
        {
            DriverManager.QuitDriver();
        }
    }
}
