using OpenQA.Selenium;
using LoggingPractise.PageObjects;
using System;

namespace LoggingPractise.Tests
{
    internal class ContactUsPage : BaseApplicationPage
    {
        private IWebDriver driver;

        private IWebElement CenterColumn => Driver.FindElement(By.Id("center_column"));


        public ContactUsPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public bool IsLoaded
        { get
            {
                try
                {
                    return CenterColumn.Displayed;
                }
                catch(NoSuchElementException)
                {
                    return false;
                }
            }
        }

        internal void GoTo()
        {
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=contact");
        }
    }
}