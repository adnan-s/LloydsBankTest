using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;


namespace LloydsBankGroup.Test.Pages
{
    public class HomePage : DriverHelper
    {
        IWebElement lnkLogin => Driver.FindElement(By.LinkText("Login"));
        IWebElement lnkLogoff => Driver.FindElement(By.LinkText("log off"));

        public void ClickLogin() => lnkLogin.Click();
        public bool IsLogoffExist => lnkLogoff.Displayed;
    }
}
