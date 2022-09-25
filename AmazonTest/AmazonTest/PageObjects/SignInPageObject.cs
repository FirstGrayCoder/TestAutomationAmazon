using AmazonTest.Drivers;
using AmazonTest.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V102.Debugger;

namespace AmazonTest.PageObjects
{
    internal class SignInPageObject : BasePage
    {
        private static string UrlSignIn => "https://www.amazon.com/ap/signin?openid.pape.max_auth_age=0&openid.return_to=https%3A%2F%2Fwww.amazon.com%2Fs%3Fk%3Dsony%2Bplaystation%26crid%3DFPN9ZL2JIBGH%26sprefix%3Dsony%2Bplaystation%252Caps%252C197%26ref%3Dnav_signin&openid.identity=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.assoc_handle=usflex&openid.mode=checkid_setup&openid.claimed_id=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.ns=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0&";
        private static string Email => "{0}";
        private static string Password => "{0}";
        private string EmailField => "//input[@type = 'email']";
        private string ContinueButton => "//input[@id = 'continue']";
        private string PasswordField => "//input[@type = 'password']";
        private string SignInButton => "//input[@id = 'signInSubmit']";
        private string UserProfileName => "//span[contains(text(), '{0}')]";
        private string ResultOfWrongEmail => "//span[contains(text(), 'We cannot find an account with that email address')]";



        private static readonly SignInPageObject signInPageObject;
        public static SignInPageObject Instance => signInPageObject ?? new SignInPageObject();


        public void OpenSignInPage()
        {
            DriverManager.Instance().Navigate().GoToUrl(UrlSignIn);
        }
        public void FillEmailField(string email)
        {
            DriverManager.Instance().FindElement(By.XPath(EmailField)).SendKeys(string.Format(Email, email));
        }

        public void PressContinueButton()
        {
            DriverManager.Instance().FindElement(By.XPath(ContinueButton)).Click();
        }

        public void FillPasswordField(string password)
        {
            DriverManager.Instance().FindElement(By.XPath(PasswordField)).SendKeys(string.Format(Password, password));
        }
        public void PressSignInButton()
        {
            DriverManager.Instance().FindElement(By.XPath(SignInButton)).Click();
        }

        public bool IsDisplayedUserName(string userName)
        {
            return IsDisplayed(By.XPath(string.Format(UserProfileName, userName)));
        }
        public bool IsDisplayedPasswordField()
        {
            return IsDisplayed(By.XPath(PasswordField));
        }
        public bool IsDisplayedEmailField()
        {
            return IsDisplayed(By.XPath(EmailField));
        }

        public bool IsDisplayedMessageWrongEmail()
        {
            return IsDisplayed(By.XPath(ResultOfWrongEmail));
        }

    }
}

