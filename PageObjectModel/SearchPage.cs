using System.Collections;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Tests3.BaseClass;
using System;
using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;

namespace NUnit.Tests3.POM
{
    
    public class SearchPage
    {
        IWebDriver driver;
        public SearchPage(IWebDriver driver)
        {
            this.driver=driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Name,Using ="search_query")]
        public IWebElement SearchTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "search-icon-legacy")]
        public IWebElement SearchButton { get; set; }

        public ResultPage NavigateToResultPage()
        {
            SearchTextBox.SendKeys("Magical Messi");
            SearchButton.Click();
            return new ResultPage(driver);
        }


    }
}
