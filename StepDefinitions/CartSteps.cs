using NUnit.Framework;
using OpenQA.Selenium;
using WebTechTest.PageObjects;

namespace WebTechTest.StepDefinitions
{
    [Binding]
    public sealed class CartSteps
    {
        private readonly IWebDriver driver;
        private readonly CartPage cartPage;

        public CartSteps(IWebDriver driver)
        {
            this.driver = driver;
            cartPage = new CartPage(driver);
        }

        [Then(@"I should see total (.*) items listed in my cart")]
        public void ThenIShouldSeeTotalItemsListedInMyCart(int expectedItemsInCart)
        {
            Assert.AreEqual(expectedItemsInCart, cartPage.SumProductQuantity());
            Assert.AreEqual(expectedItemsInCart, cartPage.GetProductListCount());
        }

        [When(@"I search and remove the lowest price item from my cart")]
        public void WhenISearchAndRemoveTheLowestPriceItemFromMyCart()
        {
            Thread.Sleep(1000);
            cartPage.RemoveLowestPriceItem();
        }


    }
}