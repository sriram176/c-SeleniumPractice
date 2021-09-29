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
    public class OrderAndSkipAttribute : BaseTest1
    {
       
        [Test,Order(1),Category("Order&SkipSample")]
        public void TestMethod()
        {
            
            IWebElement EmailTextField = driver.FindElement(By.XPath(".//*[@id='identifierId']"));
            EmailTextField.SendKeys("1@gmail.com");
            
     
        }
        [Test,Order(0),Category("Order&SkipSample")]
        public void TestMethod1()
        {
            
            IWebElement EmailTextField = driver.FindElement(By.XPath(".//*[@id='identifierId']"));
            EmailTextField.SendKeys("2@gmail.com");

        }
        [Test,Order(2),Category("Order&SkipSample")]
        public void TestMethod3()
        {
            
            IWebElement EmailTextField = driver.FindElement(By.XPath(".//*[@id='identifierId']"));
            EmailTextField.SendKeys("3@gmail.com");

        }
        [Test, Order(3), Category("Order&SkipSample")]
        public void TestMethod4()
        {
            Assert.Ignore("skip this test");
           
            IWebElement EmailTextField = driver.FindElement(By.XPath(".//*[@id='identifierId']"));
            EmailTextField.SendKeys("4@gmail.com");

        }

    }
}
