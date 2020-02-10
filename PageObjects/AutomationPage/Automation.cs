using OpenQA.Selenium;

namespace UIAutomationEndavaWebsite.PageObjects.AutomationPage
{
    class Automation
    {
        private readonly IWebDriver driver;
           
        public Automation(IWebDriver driver)
        {
            this.driver = driver;
        }

        protected AutomationLocators Locator => new AutomationLocators(driver);

        public Automation FillFirstName(string firstName)
        {
            Locator.Firstname.SendKeys(firstName);
            return this;
        }
        public Automation FillLastName(string lastName)
        {
            Locator.Lastname.SendKeys(lastName);
            return this;
        }
        public Automation FillEmail(string email)
        {
            Locator.Email.SendKeys(email);
            return this;
        }
        public Automation FillPhoneNumber(string phoneNumber)
        {
            Locator.PhoneNumber.SendKeys(phoneNumber);
            return this;
        }
        public Automation FillCompany(string company)
        {
            Locator.Company.SendKeys(company);
            return this;
        }
        public Automation FillMessage(string message)
        {
            Locator.CustomMessage.SendKeys(message);
            return this;
        }

        public Automation SubmitContanctForm()
        {
            Locator.SubmitButton.Click();
            return this;
        }

        public bool ContactErrorMessage()
        {
            return Locator.ContactError.Displayed;
        }
    }

}
