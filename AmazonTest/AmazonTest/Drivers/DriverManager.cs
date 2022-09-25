using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

[assembly: Parallelizable(ParallelScope.Fixtures)]
[assembly: LevelOfParallelism(2)]

namespace AmazonTest.Drivers
{
    class DriverManager
    {
        private static ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();

        public static IWebDriver Instance()
        {
            if (driver.Value == null)
            {
                driver.Value = new ChromeDriver();
                driver.Value.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(30));
                driver.Value.Manage().Window.Maximize();
            }
            return driver.Value;
        }
        public static IWebDriver Inkognito()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("inkognito");
            if (driver.Value == null)
            {
                driver.Value = new ChromeDriver(options);
                driver.Value.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(30));
                driver.Value.Manage().Window.Maximize();
            }
            return driver.Value;
        }

        public static void QuitDriver()
        {
            Instance().Quit();
            driver.Value = null;
        }

        public static void ClosePage()
        {
            Instance().Close();
        }
    }
}
