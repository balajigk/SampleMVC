using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using Selenium;

namespace SampleBuildApplication.AutomatedTests
{
    [TestFixture]
    public class SampleMVCTests
    {
        private ISelenium selenium;
        private StringBuilder verificationErrors;

        [SetUp]
        public void SetupTest()
        {
            selenium = new DefaultSelenium("localhost", 8888, "*firefox", "http://192.168.37.31:8088/");
            selenium.Start();
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                selenium.Stop();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
                                                 
        [Test]
        public void TheSampleMVCTestsTest()
        { 
            selenium.Open("/");
            selenium.WindowMaximize();
            selenium.Click("link=Home");
            selenium.WaitForPageToLoad("30000");
            selenium.Click("link=About");
            selenium.WaitForPageToLoad("30000");
            selenium.Click("link=Contact");
            selenium.WaitForPageToLoad("30000");
            selenium.Click("link=Home");
            selenium.WaitForPageToLoad("30000");
            selenium.Click("link=About");
            selenium.WaitForPageToLoad("30000");
            selenium.Click("link=Contact");
            selenium.WaitForPageToLoad("30000");
        }
    }
}
