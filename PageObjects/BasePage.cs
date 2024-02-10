using OpenQA.Selenium;

namespace SeleniumSpecflow.PageObjects
{
    public class BasePage
    {
        protected IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
