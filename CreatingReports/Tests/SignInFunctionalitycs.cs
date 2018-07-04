using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreatingReports.PageObjects;

namespace CreatingReports.Tests
{
    [TestClass]
    [TestCategory("SignIn")]
    [TestCategory("FinalFramework")]
    public class SignInFunctionality : BaseTest
    {
        [TestMethod]
        [TestProperty("Author", "AndyTilston")]
        public void SiginFunctionality_TCID5()
        {
            var homePage = new HomePage(Driver);
            homePage.GoTo();
            Assert.IsTrue(homePage.IsLoaded, "Home page did not open successfully");

            var signInPage = homePage.Header.ClickSignInButton();
            Assert.IsTrue(signInPage.IsLoaded, "Sign in page did not open successfully");
        }
    }
}
