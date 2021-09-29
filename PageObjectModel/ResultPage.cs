using System.Collections;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Tests3.BaseClass;
using System;
using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace NUnit.Tests3.POM
{

    public class ResultPage
    {
        IWebDriver driver;
        public ResultPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Id, Using = "main-link")]
        public IWebElement ChannelName { get; set; }

       

        public void NavigateToChannelPage()
        {
            Thread.Sleep(3000);
            ChannelName.Click();
        }


    }
}
