using OpenQA.Selenium;

namespace UIAutomationEndavaWebsite.PageObjects.AutomationPage
{
    class AutomationLocators
    {
        private readonly IWebDriver driver;
        public AutomationLocators(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement Firstname => driver.FindElement(By.Id("FirstName"));

        public IWebElement Lastname => driver.FindElement(By.Id("LastName"));

        public IWebElement Email => driver.FindElement(By.Id("Email"));

        public IWebElement PhoneNumber => driver.FindElement(By.Id("MobilePhone"));

        public IWebElement Company => driver.FindElement(By.Id("MobilePhone"));

        public IWebElement CustomMessage => driver.FindElement(By.Id("formCustomMessage"));

        public IWebElement SubmitButton => driver.FindElement(By.ClassName("mktoButton"));

        public IWebElement ContactError => driver.FindElement(By.ClassName("mktoErrorMsg"));
    }


}
