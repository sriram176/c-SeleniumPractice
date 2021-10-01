// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Tests3.BaseClass;
using System;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace NUnit.Tests3
{
    [TestFixture]
    class JSExecutor : BaseTest1
    {
        [Test]
        public void TestMethod()
        {
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("document.getElementsByName('search_query')[0].value='selenium'");
            Thread.Sleep(5000);

            jse.ExecuteScript("document.getElementById('search-icon-legacy').click()");
            Thread.Sleep(10000);


        }
    }
}