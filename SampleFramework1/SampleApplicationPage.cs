using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;

namespace SampleFramework1
{
    internal class SampleApplicationPage : BaseSampleApplicationPage
    {
        public SampleApplicationPage(IWebDriver driver) : base(driver){}

        public bool IsVisible {
            get
            {
                return Driver.Title.Contains(PageTitle);
            }
            internal set { }
        }

        public IWebElement FirstNameField => Driver.FindElement(By.Name("firstname"));
        public IWebElement SecondNameField => Driver.FindElement(By.Name("lastname"));
        public IWebElement FirstNameFieldForEmergencyContact => Driver.FindElement(By.Id("f2"));
        public IWebElement SecondNameFieldForEmergencyContact => Driver.FindElement(By.Id("l2"));
        public IWebElement SubmitButton => Driver.FindElement(By.XPath("//*[@type='submit']"));
        public IWebElement FemaleGenderRadioButton => Driver.FindElement(By.Id("radio1-f"));
        public IWebElement MaleGenderRadioButton => Driver.FindElement(By.XPath("//input[@value='male']"));
        public IWebElement OtherGenderRadioButton => Driver.FindElement(By.XPath("//input[@value='other']"));
        public IWebElement MaleGenderRadioButtonForEmergencyContact => Driver.FindElement(By.Id("radio2-m"));
        public IWebElement FemaleGenderRadioButtonForEmergencyContact => Driver.FindElement(By.Id("radio2-f"));
        public IWebElement OtherGenderRadioButtonForEmergencyContact => Driver.FindElement(By.Id("radio2-0"));


        private string PageTitle => "Sample Application Lifecycle";



        internal void GoTo()
        {
            Driver.Navigate().GoToUrl("https://www.ultimateqa.com/sample-application-lifecycle-sprint-4");
            Assert.IsTrue(IsVisible, 
                $"Sample Application page was not visible. Expected=>{PageTitle}." +
                $"Actual=>{Driver.Title}");
        }

        internal UltimateQAHomePage FillOutPrimaryContactFormAndSubmit(TestUser user)
        {
            SetGender(user);
            FirstNameField.SendKeys(user.FirstName);
            SecondNameField.SendKeys(user.LastName);
            SubmitButton.Submit();
            return new UltimateQAHomePage(Driver);
        }

        internal void FillOutEmergencyContactForm(TestUser emergencyContactUser)
        {
            SetGenderForEmergencyContact(emergencyContactUser);
            FirstNameFieldForEmergencyContact.SendKeys(emergencyContactUser.FirstName);
            SecondNameFieldForEmergencyContact.SendKeys(emergencyContactUser.LastName);
        }

        private void SetGenderForEmergencyContact(TestUser user)
        {
            switch (user.GenderType)
            {
                case Gender.Male:
                    MaleGenderRadioButtonForEmergencyContact.Click();
                    break;
                case Gender.Female:
                    FemaleGenderRadioButtonForEmergencyContact.Click();
                    break;
                case Gender.Other:
                    OtherGenderRadioButtonForEmergencyContact.Click();
                    break;
                default:
                    break;
            }
        }

        private void SetGender(TestUser user)
        {
            switch (user.GenderType)
            {
                case Gender.Male:
                    MaleGenderRadioButton.Click();
                    break;
                case Gender.Female:
                    FemaleGenderRadioButton.Click();
                    break;
                case Gender.Other:
                    OtherGenderRadioButton.Click();
                    break;
                default:
                    break;
            }
        }
    }
}