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
    public class BaseTest
    {
        public IWebDriver driver;
        [OneTimeSetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            // TODO: Add your test code hiere
            driver.Url = "https://accounts.google.com/ServiceLogin/signinchooser?service=mail&passive=true&rm=false&" +
                "continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&ss=1&scc=1&ltmpl=default&ltmplcache=2&emr=1&" +
                "osid=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin";
        }
        [OneTimeTearDown]
        public void Close()
        {

            driver.Close();
        }
    }
}
