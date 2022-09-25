using AmazonTest.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AmazonTest.PageObjects
{
    class BasePage
    {
        private string Url = "{0}";
        public static IWebElement FindElement(By locator)
        {
            return DriverManager.Instance().FindElement(locator);
        }

        public IReadOnlyCollection<IWebElement> FindElements(By locator)
        {
            return DriverManager.Instance().FindElements(locator);
        }

        public static bool IsDisplayed(By locator, int timeout = 30)
        {
            var wait = new WebDriverWait(DriverManager.Instance(), TimeSpan.FromSeconds(timeout));
            return wait.Until(driver => DriverManager.Instance().FindElement(locator).Displayed);
        }

        public void OpenPageWithSearchField(string url)
        {
            DriverManager.Instance().Navigate().GoToUrl(string.Format(Url, url));
        }

        public static void Wait(By locator, int timeout = 30)
        {
            var wait = new WebDriverWait(DriverManager.Instance(), TimeSpan.FromSeconds(timeout));
            wait.Until(driver => DriverManager.Instance().FindElement(locator).Displayed);
        }

    }
}

