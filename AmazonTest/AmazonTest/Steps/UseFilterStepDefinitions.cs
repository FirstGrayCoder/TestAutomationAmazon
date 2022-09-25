using AmazonTest.Drivers;
using AmazonTest.PageObjects;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AmazonTest.Steps
{
    [Binding]
    public class UseFilterStepDefinitions
    {
        [Given(@"I open page with list of products")]
        public void GivenIOpenPageWithListOfProducts()
        {
            FilterPageObject.Instance.OpenPageOfListProducts();
        }
        [When(@"I check filter SanDisc")]
        public void WhenICheckFilterSanDisc()
        {
            FilterPageObject.Instance.CheckFilter1();
        }

        [When(@"I check filter Amazon\.com")]
        public void WhenICheckFilterAmazon_Com()
        {
            FilterPageObject.Instance.CheckFilter2();
        }

        [Then(@"Page with result what i need should be opened")]
        public void ThenPageWithResultWhatINeedShouldBeOpened()
        {
            Assert.IsTrue(FilterPageObject.Instance.IsDisplayedNeededProducts());
        }

        [AfterScenario]
        public static void AfterTestRun()
        {
            DriverManager.QuitDriver();
        }
    }
}
