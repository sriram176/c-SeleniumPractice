using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Collections;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnit.Tests3.BaseClass
{
    [TestFixture]
    public class BaseTest1
    {
        public IWebDriver driver;
        [SetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            // TODO: Add your test code hiere
            driver.Url = "https://www.youtube.com/";
        }
        [TearDown]
        public void Close()
        {
            driver.Quit();

        }
    }
}
