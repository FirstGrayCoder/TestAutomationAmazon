using AmazonTest.Drivers;
using OpenQA.Selenium;

namespace AmazonTest.PageObjects
{
    internal class CustomerServicePageObject : BasePage
    {
        private string InternationalShopButton => "//div[contains(text(), 'International shopping')]";
        private string FreeShippingButton => "//span[contains(text(), 'Free shipping and other promotions')]";
        private string FreeShippingEligibilityButton => "//span[contains(text(), 'Free shipping eligibility')]";
        private string INeedMoreHelp => "//button[contains(text(), 'I need more help')]";

        private static CustomerServicePageObject customerServicePageObject;
        public static CustomerServicePageObject Instance => customerServicePageObject ?? new CustomerServicePageObject();

        public void ClickInternationalShopButton()
        {
            DriverManager.Instance().FindElement(By.XPath(InternationalShopButton)).Click();       
        }

        public void ClickFreeShippingButton()
        {
            DriverManager.Instance().FindElement(By.XPath(FreeShippingButton)).Click();
        }
        public void ClickFreeShippingEligibilityButton()
        {
            Wait(By.XPath(FreeShippingEligibilityButton));
            DriverManager.Instance().FindElement(By.XPath(FreeShippingEligibilityButton)).Click();
        }
        public bool IsDisplayedINeedMoreHelpButton()
        {
            return IsDisplayed(By.XPath(INeedMoreHelp));
        }


    }
}
