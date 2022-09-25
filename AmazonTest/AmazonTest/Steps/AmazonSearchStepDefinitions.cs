using AmazonTest.Drivers;
using AmazonTest.PageObjects;
using AmazonTestsFT.PageObjects;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AmazonTest.Steps
{
    [Binding]
    public class AmazonSearchStepDefinitions
    {
        [Given(@"I open  '([^']*)' of Amazon")]
        public void OpenPageOfAmazon(string p0)
        {
            HomePageObject.Instance.OpenPageWithSearchField(p0);
        }

        [When(@"I input '([^']*)' to the search field")]
        public void InputToTheSearchField(string p0)
        {
            HomePageObject.Instance.WriteSearchWord(p0);
        }

        [When(@"I click site search button")]
        public void WhenIClickSiteSearchButton()
        {
            HomePageObject.Instance.PressSearchButton();
        }

        [Then(@"Page with '([^']*)' should be opened")]
        public void ThenPageWithShouldBeOpened(string p0)
        {
            //Assert.IsTrue(SearchResultPageObject.Instance.IsSearchResultPageDisplayed(), "Amazon search result page not displayed");
            Assert.IsTrue(SearchResultPageObject.Instance.IsSearchResultWordDisplayed(p0), "Search result don`t displayed search word - " + p0);
        }
        [AfterScenario]
        public static void AfterTestRun()
        {
            DriverManager.QuitDriver();
        }
    }
}
