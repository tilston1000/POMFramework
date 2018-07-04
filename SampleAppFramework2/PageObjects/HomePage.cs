using System;
using OpenQA.Selenium;
using SampleAppFramework2.PageObjects;

namespace SampleAppFramework2.Tests
{
    internal class HomePage : BaseApplicationPage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
            Slider = new Slider(driver);
        }

        public Slider Slider { get; set; }

        internal void GoTo()
        {
            Driver.Navigate().GoToUrl("http://automationpractice.com/");
        }

        internal SearchPage Search(string itemToSearchFor)
        {
            Driver.FindElement(By.Id("search_query_top")).SendKeys(itemToSearchFor);
            Driver.FindElement(By.Name("submit_search")).Click();
            return new SearchPage(Driver);
        }
    }
}