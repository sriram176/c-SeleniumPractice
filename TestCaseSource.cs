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
    public class TestCaseSource : BaseTest1
    {
        [Test,Category("Group 1")]
        [TestCaseSource("DataDrivenTesting")]
        public void TestMethod(String data)
        {
            
            IWebElement EmailTextField = driver.FindElement(By.XPath(".//*[@id='identifierId']"));
            EmailTextField.SendKeys(data);
            EmailTextField.Clear();
     
        }
     

        
        static IList DataDrivenTesting()
        {
            ArrayList values = new ArrayList();
            values.Add("sriram@gmail.com");
            values.Add("ram@gmail.com");
            values.Add("sri@gmail.com");

            return values;

        }

    }
}
