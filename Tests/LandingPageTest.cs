using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace LloydsBankGroup.Test.Tests
{
    class LandingPageTest : DriverHelper
    {
        // Browser Driver
        public new IWebDriver Driver = new ChromeDriver(@"c:\driver");

        // Hooks in Nunit
        [SetUp]
        public void Setup()  // Run This code before each test
        {
            Driver = new ChromeDriver();
            System.Console.WriteLine("Setup");
        }
        [Test]
        public void ProductServiceTab()
        {
            // Arange 
            string title = "Lloyds Bank - Personal Banking, Personal Finances & Bank Accounts";

            // Act
            Driver.Navigate().GoToUrl("https://www.lloydsbank.com/");
            Actions actions = new Actions(Driver);
            actions.MoveToElement(Driver.FindElement(By.XPath("//*[@id='mainnav']/li[2]/a/span[1]")))
                .Build()
                .Perform();

            string actualTitle = Driver.Title;

            // Assert
            Assert.That(actualTitle, Is.EqualTo(title));

            Thread.Sleep(2000);
            Driver.Quit();
        }
    }
}
