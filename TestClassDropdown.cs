using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Tests3.BaseClass;
using System;
using OpenQA.Selenium.Support.UI;

namespace NUnit.Tests3
{
    [TestFixture]
    public class TestClassDropdown
    {
        [Test, Category("Handling Dropdown")]
        public void TestMethod()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://en-gb.facebook.com/";
            driver.FindElement(By.XPath(".//*[@class='_42ft _4jy0 _6lti _4jy6 _4jy2 selected _51sy']")).Click();
            IWebElement DropdownMonth = driver.FindElement(By.XPath(".//select[@id='month']"));
            SelectElement selectElement = new SelectElement(DropdownMonth);
            selectElement.SelectByIndex(1);
        }
    }
}
