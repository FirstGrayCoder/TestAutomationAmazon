using AmazonTest.PageObjects;
using AmazonTest.Drivers;
using OpenQA.Selenium;


namespace AmazonTestsFT.PageObjects
{
    internal class SearchResultPageObject : BasePage
    {

        private string SearchResults => "//div[@class = 'sg-col-inner']//span[contains(text(), '{0}')]";
        private string TitleXPath => "//title[contains(text(), '{0}')]";

        private static SearchResultPageObject searchResultPageObject;
        public static SearchResultPageObject Instance => searchResultPageObject ?? new SearchResultPageObject();


        public bool IsSearchResultPageDisplayed(string titleXPath)
        {
            return IsDisplayed(By.XPath(string.Format(TitleXPath, titleXPath)));
        }

        public bool IsSearchResultWordDisplayed(string searchResult)
        {
            return IsDisplayed(By.XPath(string.Format(SearchResults, searchResult)));
        }



    }
}

