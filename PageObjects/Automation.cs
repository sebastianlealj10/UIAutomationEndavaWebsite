using OpenQA.Selenium;

namespace UIAutomationEndavaWebsite.PageObjects
{
    class Automation
    {
        //TODO: Implement a separate class to the locators
        private readonly IWebDriver driver;
        private IWebElement Firstname => driver.FindElement(By.Id("FirstName"));
        private IWebElement Lastname => driver.FindElement(By.Id("LastName"));
        private IWebElement Email => driver.FindElement(By.Id("Email"));
        private IWebElement PhoneNumber => driver.FindElement(By.Id("MobilePhone"));
        private IWebElement Company => driver.FindElement(By.Id("new_companyname"));
        private IWebElement CustomMessage => driver.FindElement(By.Id("formCustomMessage"));
        private IWebElement SubmitButton => driver.FindElement(By.ClassName("mktoButton"));
        private IWebElement ContactError => driver.FindElement(By.ClassName("mktoErrorMsg"));
        public Automation(IWebDriver driver)
        {
            this.driver = driver;
        }

        public Automation FillFirstName(string firstName)
        {
            Firstname.SendKeys(firstName);
            return this;
        }
        public Automation FillLastName(string lastName)
        {
            Lastname.SendKeys(lastName);
            return this;
        }
        public Automation FillEmail(string email)
        {
            Email.SendKeys(email);
            return this;
        }
        public Automation FillPhoneNumber(string phoneNumber)
        {
            PhoneNumber.SendKeys(phoneNumber);
            return this;
        }
        public Automation FillCompany(string company)
        {
            Company.SendKeys(company);
            return this;
        }
        public Automation FillMessage(string message)
        {
            CustomMessage.SendKeys(message);
            return this;
        }

        public Automation SubmitContanctForm() 
        {
            SubmitButton.Click();
            return this;
        }

        public bool ContactErrorMessage() 
        {
            return ContactError.Displayed;
        }
    }

}
