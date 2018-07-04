using CreatingReports.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleAppFramework2.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAppFramework2.Tests
{
    [TestClass]
    [TestCategory("FinalFramework")]
    public class ComplicatedPageFeature : BaseTest
    {
        ComplicatedPage ComplicatedPage;
        [TestInitialize]
        public void OpenComplicatedPage()
        {
            ComplicatedPage = new ComplicatedPage(Driver);
            ComplicatedPage.GoTo();
            Assert.IsTrue(ComplicatedPage.IsLoaded, "The complicated page did not open");
        }

        [TestMethod]
        [TestProperty("Author", "AndyTilston")]
        public void TCID6()
        {
            //1. open automation page with many items
            //2. Fill out and submit the form in the "Section of random stuff"
            //3. Validate that the form was submitted successfully
            ComplicatedPage.RandomStuffSection.FillOutFormAndSubmit("my name", "x@x.com", "my message");
            Assert.IsTrue(ComplicatedPage.RandomStuffSection.IsFormSubmitted, "The form was not submitted successfully");
        }

        [TestMethod]
        [TestProperty("Author", "AndyTilston")]
        public void TCID7()
        {
            //1. Open automation page with many items
            //2. Perform a search for string "selenium errors"
            //3. Validate that correct search results were returned
            var searchResultsPage = ComplicatedPage.RandomStuffSection.LeftPane.Search("selenium errors");
            Assert.IsTrue(searchResultsPage.IsLoaded, "The search page did not open");
        }



    }
}
