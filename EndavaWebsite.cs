using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using UIAutomationEndavaWebsite.PageObjects;

namespace UIAutomationEndavaWebsite
{
    public class EndavaWebsite
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        private Home homePage;
        private Automation automationPage;
        private readonly string endavaURL = "https://www.endava.com/";

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void NotFillingAllTheFiledsForTheContactFormFromTheAutomationPage()
        {
            driver.Url = endavaURL;
            homePage = new Home(driver, wait);
            automationPage = new Automation(driver);
            homePage.
                OpenMainMenu().
                SelectAutomation();
            automationPage.
                FillFirstName("Sebastian").
                FillLastName("Leal").
                FillEmail("juan.leal@endava.com").
                FillPhoneNumber("555-555").
                FillCompany("Endava").
                FillMessage("Endava RLZ").
                SubmitContanctForm();
            Assert.IsTrue(automationPage.ContactErrorMessage());
            //TODO: Implement a builder with defaults
        }

        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }
    }
}