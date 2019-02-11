using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCRockers.Controllers;

namespace MVCRockers.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void VerifyIndexShowsNewSplashScreen()
        {
            HomeController controller = new HomeController();
            //var results = controller.Index() as View
        }
    }
}
