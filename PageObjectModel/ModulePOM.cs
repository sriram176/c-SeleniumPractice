using System.Collections;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Tests3.BaseClass;
using System;
using NUnit.Framework;
using System.Threading;

namespace NUnit.Tests3.POM
{
     
        [TestFixture]
        public class ModulePOM : BaseTest1
        {
            [Test]
            public void TestMethod()
            {
                var searchPage = new SearchPage(driver);
                var resultPage = searchPage.NavigateToResultPage();

                resultPage.NavigateToChannelPage();
                Thread.Sleep(5000);



                

            }
        }
}
