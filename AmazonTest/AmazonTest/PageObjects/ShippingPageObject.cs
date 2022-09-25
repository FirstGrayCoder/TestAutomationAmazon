using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonTest.PageObjects
{
    internal class ShippingPageObject
    {
        

        private static HeadPhoneProductPageObject productPageObject;
        public static HeadPhoneProductPageObject Instance => productPageObject ?? new HeadPhoneProductPageObject();
    }
}
