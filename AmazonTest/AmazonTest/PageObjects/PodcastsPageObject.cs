using AmazonTest.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonTest.PageObjects
{
    internal class PodcastsPageObject : BasePage
    {
        private string BurgerMenu => "//i[@class = 'hm-icon nav-sprite']";
        private string AmazonMusicXPath => "//div[contains(text(), 'Amazon Music')] ";
        private string PlayMusicXPath => "//a[contains(text(), 'Podcasts')]";
        private string PlayMusicPageUrl => "https://www.amazon.com/music/lp/podcasts?ref_=nav_em__dm_nav_rh_0_2_2_4";

        private static PodcastsPageObject playMusicPageObject;
        public static PodcastsPageObject Instance => playMusicPageObject ?? new PodcastsPageObject();

        public void ClickBurgerMenu()
        {
            Wait(By.XPath(BurgerMenu));
            DriverManager.Instance().FindElement(By.XPath(BurgerMenu)).Click();
            
        }

        public void ClickAmazonMusicButton()
        {
            Wait(By.XPath(AmazonMusicXPath));
            DriverManager.Instance().FindElement(By.XPath(AmazonMusicXPath)).Click();
        }

        public void ClickPodcastsButton()
        {
            Wait(By.XPath(PlayMusicXPath)); 
            DriverManager.Instance().FindElement(By.XPath(PlayMusicXPath)).Click();   
        }

        public string IsDisplayedRightUrl()
        {
            return PlayMusicPageUrl;
        }

    }
}
