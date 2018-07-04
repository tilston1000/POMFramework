using AutomationResources;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace LoggingPractise.Tests

{
    [TestClass]
    [TestCategory("ContactUsPage"), TestCategory("LoggingPractise")]
    public class ContactUsFeature : BaseTest
    {
        [TestMethod]
        [TestProperty("Author", "AndyTilston")]
        [Description("Validate that the contact us page opens successfully with a form")]
        public void ContactUsFeature_TCID2()
        {
            ContactUsPage contactUsPage = new ContactUsPage(Driver);
            contactUsPage.GoTo();
            Assert.IsTrue(contactUsPage.IsLoaded,
                "The contact us page did not open successfully");
        }
    }
}
