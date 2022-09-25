using AmazonTest.Drivers;
using OpenQA.Selenium;


namespace AmazonTest.PageObjects
{
    internal class FilterPageObject : BasePage
    {
        private string PageOfListProductsUrl => "https://www.amazon.com/s?i=specialty-aps&bbn=16225009011&rh=n%3A%2116225009011%2Cn%3A502394&ref=nav_em__nav_desktop_sa_intl_camera_and_photo_0_2_5_3";
        private string Filter1XPath => "//li[@aria-label = 'SanDisk']//i[@class ='a-icon a-icon-checkbox']";
        private string Filter2XPath => "//li[@aria-label = 'Amazon.com']//i[@class ='a-icon a-icon-checkbox']";
        private string FilterSerchResult => "//span[contains(text(), 'SDSQXAV-1T00-GN6MA')]";


        private static FilterPageObject filterPageObject;
        public static FilterPageObject Instance => filterPageObject ?? new FilterPageObject();

        public void OpenPageOfListProducts()
        {
            DriverManager.Instance().Navigate().GoToUrl(PageOfListProductsUrl);
        }

        public void CheckFilter1()
        {
            DriverManager.Instance().FindElement(By.XPath(Filter1XPath)).Click();
        }
        public void CheckFilter2()
        {
            DriverManager.Instance().FindElement(By.XPath(Filter2XPath)).Click();
        }

        public bool IsDisplayedNeededProducts()
        {
            return IsDisplayed(By.XPath(FilterSerchResult));
        }

    }
}
