using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace SeleniumSpecflow.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private readonly IObjectContainer _container;

        public Hooks(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            IWebDriver driver = new ChromeDriver(new ChromeOptions() { PageLoadStrategy = PageLoadStrategy.Normal });

            driver.Navigate().GoToUrl("https://cms.demo.katalon.com/");
            driver.Manage().Window.Maximize();

            _container.RegisterInstanceAs<IWebDriver>(driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            var driver = _container.Resolve<IWebDriver>();

            driver?.Quit();
        }
    }
}
