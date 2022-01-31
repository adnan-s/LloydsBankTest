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

        [Test]
        public void PlatinumAccountFee()
        {
            string title = "Open a Current Account Online | UK Bank Accounts | Lloyds Bank";
            string platinumMonthlyFee = "£21 per month";

            // Act
            Driver.Navigate().GoToUrl("https://www.lloydsbank.com/current-accounts.html");
            Actions actions = new Actions(Driver);
            string fee = Driver.FindElement(By.XPath("//*[@id='main']/div[4]/div/div/div/div/div[2]/div/div/div/div[3]/div/div/div/div/div[2]/p/span/strong"))
                .Text;

            string actualTitle = Driver.Title;

            // Assert
            Assert.That(actualTitle, Is.EqualTo(title));
            Assert.That(fee, Is.EqualTo(platinumMonthlyFee));
            Thread.Sleep(2000);
            Driver.Quit();
        }

        [Test]
        public void CruntAccountClick()
        {
            string title = "Open a Current Account Online | UK Bank Accounts | Lloyds Bank";
            string[] accountTypes = {"Classic account","Club Lloyds account","Platinum account" };

            // Act
            Driver.Navigate().GoToUrl("https://www.lloydsbank.com/current-accounts.html");
            Actions actions = new Actions(Driver);



            string acc1 = Driver.FindElement(By.XPath("//*[@id='main']/div[4]/div/div/div/div/div[2]/div/div/div/div[1]/div/div/div/div/div[1]/h2/span"))
                .Text;
            string acc2 = Driver.FindElement(By.XPath("//*[@id='main']/div[4]/div/div/div/div/div[2]/div/div/div/div[2]/div/div/div/div/div[1]/h2/span"))
                .Text;
            string acc3 = Driver.FindElement(By.XPath("//*[@id='main']/div[4]/div/div/div/div/div[2]/div/div/div/div[3]/div/div/div/div/div[1]/h2/span"))
                .Text;

            string actualTitle = Driver.Title;


            // Assert
            Assert.That(actualTitle, Is.EqualTo(title));
            Assert.That(acc1, Is.EqualTo(accountTypes[0]));
            Assert.That(acc2, Is.EqualTo(accountTypes[1]));
            Assert.That(acc3, Is.EqualTo(accountTypes[2]));

            Thread.Sleep(2000);
            Driver.Quit();
        }

    }
}
