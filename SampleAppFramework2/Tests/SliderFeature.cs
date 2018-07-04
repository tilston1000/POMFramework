using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAppFramework2.Tests
{
    [TestClass]
    [TestCategory("SliderFeature"), TestCategory("SampleApp2")]
    public class SliderFeature : BaseTest
    {
        [TestMethod]
        [Description("Validate that slider changes images")]
        [TestProperty("Author", "AndyTilston")]
        public void TCID3()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.GoTo();
            var currentImage = homePage.Slider.CurrentImage;
            homePage.Slider.ClickNextButton();
            var newImage = homePage.Slider.CurrentImage;
            Assert.AreNotEqual(currentImage, newImage,
                "The slider images did not change when pressing the next button");
        }

        [TestMethod]
        [Description("Validate that Shop Now button in slider redirects you")]
        [TestProperty("Author", "AndyTilston")]
        public void TCID4()
        {

        }

    }
}
