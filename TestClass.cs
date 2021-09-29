// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Tests3.BaseClass;
using System;

namespace NUnit.Tests3
{
    [TestFixture]
    public class TestClass : BaseTest1
    {
        [Test,Category("Group 1")]
        public void TestMethod()
        {
            
            IWebElement EmailTextField = driver.FindElement(By.XPath(".//*[@id='identifierId']"));
            EmailTextField.SendKeys("sriram@gmail.com");
            EmailTextField.Clear();
     
        }
        [Test,Category("Group 1")]
        public void TestMethod1()
        {

            IWebElement EmailTextField = driver.FindElement(By.XPath(".//*[@id='identifierId']"));
            EmailTextField.SendKeys("@gmail.com");

        }
        [Test,Category("Group 2")]
        public void TestMethod3()
        {

            IWebElement EmailTextField = driver.FindElement(By.XPath(".//*[@id='identifierId']"));
            EmailTextField.SendKeys("jkh@gmail.com");

        }

    }
}
