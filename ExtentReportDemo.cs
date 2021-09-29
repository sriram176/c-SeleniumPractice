using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Tests3.BaseClass;
using System;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;


namespace NUnit.Tests3
{
    [TestFixture]
    class ExtentReportDemo
    {
        public IWebDriver driver = null;

        ExtentReports extentReport = null;
       

        [OneTimeSetUp]
        public void Open()
        {

            extentReport = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\91996\Desktop\extent.html");
            extentReport.AttachReporter(htmlReporter);
            
        }
        [OneTimeTearDown]
        public void Close()
        {

            extentReport.Flush();
        }
        [Test, Category("Group 1")]
        public void TestMethod()
        {
            ExtentTest test = null;
            test=extentReport.CreateTest("Test1").Info("Test1 Started");
            
            driver = new ChromeDriver();
            // TODO: Add your test code hiere
            driver.Url = "https://accounts.google.com/ServiceLogin/signinchooser?service=mail&passive=true&rm=false&" +
                "continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&ss=1&scc=1&ltmpl=default&ltmplcache=2&emr=1&" +
                "osid=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin";
            test.Log(Status.Info, "chromebrowser launched");

            IWebElement EmailTextField = driver.FindElement(By.XPath(".//*[@id='identifierId']"));
            EmailTextField.SendKeys("sriram@gmail.com");
            test.Log(Status.Info, "emailentered");

            driver.Quit();
            test.Log(Status.Pass, "Test1 Passed");


        }
    }
}
