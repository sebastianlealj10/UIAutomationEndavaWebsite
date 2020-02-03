using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UIAutomationEndavaWebsite
{
    public class EndavaWebsite
    {
        private IWebDriver driver;
        private readonly string endavaURL = "https://www.endava.com/";

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Navigation()
        {
            driver.Url = endavaURL;
        }

        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }
    }
}