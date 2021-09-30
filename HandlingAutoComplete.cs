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

namespace NUnit.Tests3
{
    [TestFixture]
    class HandlingAutoComplete : BaseTest1
    {
        [Test]
        public void TestMethod()
        {
            IWebElement SearchTextField = driver.FindElement(By.Name("search_query"));
            SearchTextField.SendKeys("selenium");
            SearchTextField.SendKeys(" ");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath(".//*[@class='sbsb_b']")));
            IWebElement Suggestions = driver.FindElement(By.XPath(".//*[@class='sbsb_b']"));
            IReadOnlyCollection<IWebElement> SugList = Suggestions.FindElements(By.TagName("li"));

            foreach ( IWebElement sug in SugList)
            {
                if(sug.Text.Equals("selenium tutorial"))
                {
                    sug.Click();
                    break;
                }
            }
           
        }
    }
}
