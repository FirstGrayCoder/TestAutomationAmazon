using AmazonTest.Drivers;
using OpenQA.Selenium;

namespace AmazonTest.PageObjects
{
    internal class HeadPhoneProductPageObject : BasePage
    {
        private string ProductUrl => "https://www.amazon.com/Donerton-Over-Ear-Headphones-Canceling-Compatible/dp/B09LHG8779/ref=sr_1_1_sspa?keywords=gaming+headsets&pd_rd_r=c71c70aa-0f2c-4fcb-a972-f78068b7a181&pd_rd_w=4T3TJ&pd_rd_wg=MWOFJ&pf_rd_p=12129333-2117-4490-9c17-6d31baf0582a&pf_rd_r=BMZ6GRCTJ34X027X6MVD&qid=1663679064&sr=8-1-spons&psc=1&spLa=ZW5jcnlwdGVkUXVhbGlmaWVyPUEzQ1pVRVk3S1hJR1VYJmVuY3J5cHRlZElkPUEwNjA3MDQ5MTlOMEtBODg3V01DRiZlbmNyeXB0ZWRBZElkPUEwNjc2NDUzMlRJWjJOSlczSUdaUiZ3aWRnZXROYW1lPXNwX2F0ZiZhY3Rpb249Y2xpY2tSZWRpcmVjdCZkb05vdExvZ0NsaWNrPXRydWU=";
        private string AddToListButton => "//a[@title = 'Add to List'] ";
        private string ShippingPageXPath => "https://www.amazon.com/gp/buy/addressselect/handlers/display.html?hasWorkingJavascript=1";
        private string BuyNowButtonXPath => "//input[@id = 'buy-now-button'] ";
        private string SignInButtonXPath => "//a[@id = 'nav-link-accountList']";

        private static HeadPhoneProductPageObject productPageObject;
        public static HeadPhoneProductPageObject Instance => productPageObject ?? new HeadPhoneProductPageObject();


        public void OpenProductPage()
        {
            DriverManager.Instance().Navigate().GoToUrl(ProductUrl);
        }

        public void ClickAddToListButton()
        {
            DriverManager.Instance().FindElement(By.XPath(AddToListButton)).Click();
        }

        public void ClickSignInButton()
        {
            DriverManager.Instance().FindElement(By.XPath(SignInButtonXPath)).Click();
        }

        public void ClickBuyNowButton()
        {
            DriverManager.Instance().FindElement(By.XPath(BuyNowButtonXPath)).Click();
        }

        public string IsDisplayedRightUrl()
        {
            return ShippingPageXPath;
        }


    }
}
