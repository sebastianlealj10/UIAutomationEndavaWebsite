using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace UIAutomationEndavaWebsite.PageObjects
{
    class Home
    {
        private readonly IWebDriver driver;
        private WebDriverWait wait;
        private IWebElement Mainmenu => driver.FindElement(By.CssSelector(".show-menu"));
        private IWebElement Automationselect => wait
            .Until(SeleniumExtras.WaitHelpers.ExpectedConditions
            .ElementToBeClickable(driver
                .FindElement(By.XPath("//*[@id='mCSB_1_container']/div[1]/nav/ul/li[3]/a"))));

        public Home(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }
        
        public Home OpenMainMenu()
        {
            Mainmenu.Click();
            return this;
        }

        public Home SelectAutomation()
        {
            Automationselect.Click();
            return this;
        }
    }
}
