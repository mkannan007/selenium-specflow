using OpenQA.Selenium;
using WebTechTest.PageObjects;

namespace WebTechTest.StepDefinitions
{
    [Binding]
    public sealed class ShoppingSteps
    {
        private readonly IWebDriver driver;
        private readonly ShoppingPage shoppingPage;

        public ShoppingSteps(IWebDriver driver)
        {
            this.driver = driver;
            shoppingPage = new ShoppingPage(driver);
        }

        [Given(@"I add (.*) random items to my cart")]
        public void GivenIAddRandomItemsToMyCart(int itemCount)
        {
            shoppingPage.AddItemsToCart(itemCount);
        }

        [When(@"I view my cart")]
        public void WhenIViewMyCart()
        {
            shoppingPage.ClickViewCart();
        }
    }
}
