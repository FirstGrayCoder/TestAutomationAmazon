using OpenQA.Selenium;
using AmazonTest.Drivers;

namespace AmazonTest.PageObjects
{
    internal class HomePageObject : BasePage
    {
        private string Url => "https://amazon.com";
        private string SearchFieldXpath => "//input[@id = 'twotabsearchtextbox']";
        private string SearchButtonXpath => "//input[@id = 'nav-search-submit-button']";
        private string SearchWord => "{0}";
        private string DeliveriButton => "//span[contains(text(), 'Deliver to')]";
        private string CustomerServiceButton => "//a[@data-csa-c-content-id = 'nav_cs_help']";
        


        private string DropBoxCountryXpath => "//div[@class = ' a-declarative']";
        private string CountryDeliveryXPath => "//a[contains(text(), 'United Arab Emirates')]";
        private string ButtonDoneCountryDelivery => "//button[@name = 'glowDoneButton']";

        private static HomePageObject homePageObject;
        public static HomePageObject Instance => homePageObject ?? new HomePageObject();

        public void OpenHomePage()
        {
            DriverManager.Instance().Navigate().GoToUrl(Url);
        }

        public void WriteSearchWord(string searchWord)
        {
            FindElement(By.XPath(SearchFieldXpath)).SendKeys(string.Format(SearchWord, searchWord));
        }

        public void PressSearchButton()
        {
            FindElement(By.XPath(SearchButtonXpath)).Click();
        }

        public void ChangeDeliveriCountry()
        {
            FindElement(By.XPath(DeliveriButton)).Click();
            Wait(By.XPath(DropBoxCountryXpath));
            FindElement(By.XPath(DropBoxCountryXpath)).Click();
            FindElement(By.XPath(CountryDeliveryXPath)).Click();
            FindElement(By.XPath(ButtonDoneCountryDelivery)).Click();
        }

        public void OpenCustomerService()
        {
            DriverManager.Instance().FindElement(By.XPath(CustomerServiceButton)).Click();
        }
    }
}

