using AmazonTest.Drivers;
using AmazonTest.PageObjects;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AmazonTest.Steps
{
    [Binding]
    public class AmazonInBrowserStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;

        public AmazonInBrowserStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I open browser")]
        public void OpenBrowser()
        {
            BrowserPageObject.Instance.OpenChromeBrowser();
        }

        [When(@"I input site name to the address line of the browser")]
        public void InputSiteNameToTheAddressLineOfTheBrowser()
        {
            BrowserPageObject.Instance.InputAmazonToChromeBrowser();
        }

        [When(@"I click google search button")]
        public void ClickGoogleSearchButton()
        {
            BrowserPageObject.Instance.ClickSearchButtonInChromeBrowser();
        }

        [Then(@"Site Amazon should be appear in search result page")]
        public void SiteAmazonShouldBeAppearInSearchResultPage()
        {
            Assert.IsTrue(BrowserPageObject.Instance.IsAmazonDisplayedOnSearchResult(), "Amazon is not show on serch result page");
        }

        [AfterScenario]
        public static void AfterTestRun()
        {
            DriverManager.QuitDriver();
        }

    }
}
