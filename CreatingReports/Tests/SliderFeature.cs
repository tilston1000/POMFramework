using CreatingReports.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingReports.Tests
{
    [TestClass]
    [TestCategory("SliderFeature")]
    [TestCategory("LoggingPractise")]
    public class Reporting_SliderFeature : BaseTest
    {
        [TestMethod]
        [Description("Validate that slider changes images")]
        [TestProperty("Author", "AndyTilston")]
        public void SliderFeature_TCID3s()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.GoTo();
            var currentImage = homePage.Slider.CurrentImage;
            homePage.Slider.ClickNextButton();
            var newImage = homePage.Slider.CurrentImage;
            homePage.Slider.AssertThatImageChanged(currentImage, newImage);
        }

    }
}
