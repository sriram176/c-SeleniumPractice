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
    public class AuthorAndDescription : BaseTest1
    {
       
        [Test,]
        [Author("Sriram Yalla")]
        [Description("AuthorAndDescription")]
        public void TestMethod()
        {
            
            IWebElement EmailTextField = driver.FindElement(By.XPath(".//*[@id='identifierId']"));
            EmailTextField.SendKeys("1@gmail.com");
            
     
        }
        [Test,]
        [Author("Sriram Yalla")]
        [Description("AuthorAndDescription")]
        public void TestMethod1()
        {
            
            IWebElement EmailTextField = driver.FindElement(By.XPath(".//*[@id='identifierId']"));
            EmailTextField.SendKeys("2@gmail.com");

        }
        [Test,]
        [Author("Sriram Yalla")]
        [Description("AuthorAndDescription1")]
        public void TestMethod3()
        {
            
            IWebElement EmailTextField = driver.FindElement(By.XPath(".//*[@id='identifierId']"));
            EmailTextField.SendKeys("3@gmail.com");

        }
    
        

    }
}
