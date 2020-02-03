using OpenQA.Selenium;

namespace UIAutomationEndavaWebsite.PageObjects
{
    class Home
    {
        private readonly IWebDriver driver;
        private IWebElement Mainmenu => driver.FindElement(By.CssSelector(".show-menu"));
        private IWebElement Automationselect => driver.FindElement(By.XPath("//*[@id='mCSB_1_container']/div[1]/nav/ul/li[3]/a"));

        public Home(IWebDriver driver)
        {
            this.driver = driver;
        }
        
        public Home OpenMainMenu()
        {
            Mainmenu.Click();
            return this;
        }

        public Home SelectAutomation()
        {
            // TODO: Implement wait 
            System.Threading.Thread.Sleep(5000);
            Automationselect.Click();
            return this;
        }
    }
}
