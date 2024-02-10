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
            ChromeOptions options = new()
            {
                BrowserVersion = "Stable",
                PageLoadStrategy = PageLoadStrategy.Normal,
                AcceptInsecureCertificates = true,
            };
            options.AddArgument("--start-maximized");
            options.AddArgument("--disable-extensions");
            options.AddArgument("--disable-popup-blocking");
            options.AddArgument("--disable-infobars");
            options.AddArgument("--disable-notifications");
            options.AddArgument("--disable-popup-blocking");
            options.AddArgument("--disable-extensions");
            options.AddArgument("--disable-gpu");
            options.AddArgument("--disable-dev-shm-usage");
            options.AddArgument("--no-sandbox");
            options.AddArgument("--disable-software-rasterizer");

            IWebDriver driver = new ChromeDriver(options);

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
