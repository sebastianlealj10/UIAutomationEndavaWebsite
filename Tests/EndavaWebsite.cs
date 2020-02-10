using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UIAutomationEndavaWebsite.PageObjects;

namespace UIAutomationEndavaWebsite
{
    public class EndavaWebsite
    {
        private IWebDriver driver;
        private Home homePage;
        private Automation automationPage;
        private readonly string endavaURL = "https://www.endava.com/";

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void NotFillingAllTheFiledsForTheContactFormFromTheAutomationPage()
        {
            driver.Url = endavaURL;
            homePage = new Home(driver);
            automationPage = new Automation(driver);
            homePage.
                OpenMainMenu().
                SelectAutomation();
            automationPage.DefaultUser();
            Assert.IsTrue(automationPage.ContactErrorMessage());
        }

        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }
    }
}