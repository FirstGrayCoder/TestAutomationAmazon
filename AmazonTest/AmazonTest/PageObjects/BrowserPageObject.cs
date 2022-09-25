using AmazonTest.Drivers;
using OpenQA.Selenium;


namespace AmazonTest.PageObjects
{
    class BrowserPageObject : BasePage
    {
        private string URL => "https://www.google.com";
        private string SearchField => "//input[@class = 'gLFyf gsfi']";
        private string SearchAmazon => "https://www.amazon.com/";
        private string SearchButton => "//div[@class = 'CqAVzb lJ9FBc']//input[@class = 'gNO89b']";
        private string ExpectedSearchResult => "//cite[contains(text(), 'https://www.amazon.com')]";

        private static readonly BrowserPageObject browserPage;
        public static BrowserPageObject Instance => browserPage ?? new BrowserPageObject();

        public void OpenChromeBrowser()
        {
            DriverManager.Instance().Navigate().GoToUrl(URL);
        }

        public void InputAmazonToChromeBrowser()
        {
            DriverManager.Instance().FindElement(By.XPath(SearchField)).SendKeys(SearchAmazon);
        }

        public void ClickSearchButtonInChromeBrowser()
        {
            DriverManager.Instance().FindElement(By.XPath(SearchButton)).Click();
        }

        public bool IsAmazonDisplayedOnSearchResult()
        {
            return IsDisplayed(By.XPath(ExpectedSearchResult));
        }

    }
}

