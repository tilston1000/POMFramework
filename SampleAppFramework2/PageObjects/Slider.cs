using System;
using OpenQA.Selenium;
using SampleAppFramework2.PageObjects;

namespace SampleAppFramework2.Tests
{
    public class Slider : BaseApplicationPage
    {
        private IWebDriver driver;

        private IWebElement MainSliderImage => Driver.FindElement(By.Id("homeslider"));


        public Slider(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public string CurrentImage => MainSliderImage.GetAttribute("style");

        internal void ClickNextButton()
        {
            Driver.FindElement(By.ClassName("bx-next")).Click();
        }
    }
}