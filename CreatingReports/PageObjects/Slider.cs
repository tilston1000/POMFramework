﻿using System;
using OpenQA.Selenium;
using CreatingReports.PageObjects;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CreatingReports.PageObjects
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
            Reporter.LogPassingTestStepToBugLogger("click the next button in the slider");
        }

        public void AssertThatImageChanged(string currentImage, string newImage)
        {
            Reporter.LogTestStepForBugLogger(Status.Info, "Validate that the images rotated in the slider");
            Assert.AreNotEqual(currentImage, newImage,
                "The slider images did not change when pressing the next button");
        }
    }
}