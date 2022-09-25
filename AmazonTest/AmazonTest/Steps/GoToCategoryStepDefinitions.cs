using AmazonTest.Drivers;
using AmazonTest.PageObjects;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AmazonTest.Steps
{
    [Binding]
    public class GoToCategoryStepDefinitions
    {
        [Given(@"I open Home page of Amazon")]
        public void OpenHomePageOfAmazon()
        {
            HomePageObject.Instance.OpenHomePage();
        }

        [When(@"I push burger menu button")]
        public void WhenIPushBurgerMenuButton()
        {
            PodcastsPageObject.Instance.ClickBurgerMenu();
        }

        [When(@"I push Amazon music button")]
        public void WhenIPushAmazonMusicButton()
        {
            PodcastsPageObject.Instance.ClickAmazonMusicButton();
        }
        [When(@"I push Amazon Podcasts button")]
        public void PushAmazonPodcastsButton()
        {
            PodcastsPageObject.Instance.ClickPodcastsButton();
        }

        [Then(@"Page with list of songs should be opened")]
        public void ThenPageWithListOfSongsShouldBeOpened()
        {
            Assert.AreEqual(DriverManager.Instance().Url, PodcastsPageObject.Instance.IsDisplayedRightUrl());
        }

        [AfterScenario]
        public static void AfterTestRun()
        {
            DriverManager.QuitDriver();
        }
    }
}
