// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Tests3.BaseClass;
using System;
using NUnit.Tests3.Utilities;

namespace NUnit.Tests3
{
    [TestFixture]
    public class ParallelTestClass : BrowserUtility
    {
        
        [Test,Category("Parallel Testing")]
        [Parallelizable]
        public void TestMethod()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement EmailTextField = Driver.FindElement(By.XPath(".//*[@id='identifierId']"));
            EmailTextField.SendKeys("sriram@gmail.com");

        }
        [Test, Category("Parallel Testing")]
        [Parallelizable]
        public void TestMethod1()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement EmailTextField = Driver.FindElement(By.XPath(".//*[@id='identifierId']"));
            EmailTextField.SendKeys("sriram@gmail.com");

        }
        [Test, Category("Parallel Testing")]
        [Parallelizable]
        public void TestMethod2()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement EmailTextField = Driver.FindElement(By.XPath(".//*[@id='identifierId']"));
            EmailTextField.SendKeys("sriram@gmail.com");

        }


    }
}

// Parallel Testing can also be acheived by changing the level of parallelizam in properties>assembly.info file without using parallelizable attribute
