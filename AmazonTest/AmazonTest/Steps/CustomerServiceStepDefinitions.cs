using AmazonTest.Drivers;
using AmazonTest.PageObjects;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace AmazonTest.Steps
{
    [Binding]
    public class CustomerServiceStepDefinitions
    {
        [Given(@"I open Customer service page as registered user with valid '([^']*)' and '([^']*)'")]
        public void OpenCustomerServicePageAsRegisteredUserWithValidAnd(string email, string password)
        {
            LoginedHomePageObject.Instance.LoginedHomePage(email, password);
            HomePageObject.Instance.OpenCustomerService();
        }

        [When(@"I click International shopping button")]
        public void WhenIClickInternationalShoppingButton()
        {
            CustomerServicePageObject.Instance.ClickInternationalShopButton();
        }

        [When(@"I click Free shipping en other promotions button")]
        public void WhenIClickFreeShippingEnOtherPromotionsButton()
        {
            CustomerServicePageObject.Instance.ClickFreeShippingButton();
        }

        [When(@"I click Free shipping eligibility button")]
        public void WhenIClickFreeShippingEligibilityButton()
        {
            CustomerServicePageObject.Instance.ClickFreeShippingEligibilityButton();
        }

        [Then(@"Help information should be appeard")]
        public void ThenHelpInformationShouldBeAppeard()
        {
            Assert.IsTrue(CustomerServicePageObject.Instance.IsDisplayedINeedMoreHelpButton());
        }

        [AfterScenario]
        public static void AfterTestRun()
        {
            DriverManager.QuitDriver();
        }
    }
}
