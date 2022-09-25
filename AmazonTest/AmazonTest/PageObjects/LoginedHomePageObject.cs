using AmazonTest.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonTest.PageObjects
{
    internal class LoginedHomePageObject : BasePage
    {
        private string ProductUrl => "https://www.amazon.com/Donerton-Over-Ear-Headphones-Canceling-Compatible/dp/B09LHG8779/ref=sr_1_1_sspa?keywords=gaming+headsets&pd_rd_r=c71c70aa-0f2c-4fcb-a972-f78068b7a181&pd_rd_w=4T3TJ&pd_rd_wg=MWOFJ&pf_rd_p=12129333-2117-4490-9c17-6d31baf0582a&pf_rd_r=BMZ6GRCTJ34X027X6MVD&qid=1663679064&sr=8-1-spons&psc=1&spLa=ZW5jcnlwdGVkUXVhbGlmaWVyPUEzQ1pVRVk3S1hJR1VYJmVuY3J5cHRlZElkPUEwNjA3MDQ5MTlOMEtBODg3V01DRiZlbmNyeXB0ZWRBZElkPUEwNjc2NDUzMlRJWjJOSlczSUdaUiZ3aWRnZXROYW1lPXNwX2F0ZiZhY3Rpb249Y2xpY2tSZWRpcmVjdCZkb05vdExvZ0NsaWNrPXRydWU=";
        private string SignOutXPath => "//span[contains(text(), 'Sign Out')]";
        private string LoginNameXpath => "//span[contains(text(), '{0}')]";

        private static LoginedHomePageObject loginedHomePageObject;
        public static LoginedHomePageObject Instance => loginedHomePageObject ?? new LoginedHomePageObject();

        public void LoginedHomePage(string email, string password)
        {
            SignInPageObject.Instance.OpenSignInPage();
            SignInPageObject.Instance.FillEmailField(email);
            SignInPageObject.Instance.PressContinueButton();
            SignInPageObject.Instance.FillPasswordField(password);
            SignInPageObject.Instance.PressSignInButton();
            Thread.Sleep(25000);
        }

        

        public void MoveToLoginName(string userName)
        {
            var a = new Actions(DriverManager.Instance());
            var element = FindElement(By.XPath("//a[@data-nav-ref = 'nav_youraccount_btn']"));
            a.MoveToElement(element).Perform();
        }

        public bool IsLogOutMenuDisplayed()
        {
            return IsDisplayed(By.XPath(SignOutXPath));
        }

        public void ClickSignOut()
        {
            DriverManager.Instance().FindElement(By.XPath(SignOutXPath)).Click();
        }

        public bool IsSignInPageDisplayed()
        {
           return SignInPageObject.Instance.IsDisplayedEmailField();
        }

        public void OpenProductPage()
        {
            DriverManager.Instance().Navigate().GoToUrl(ProductUrl);
        }
    }
}
