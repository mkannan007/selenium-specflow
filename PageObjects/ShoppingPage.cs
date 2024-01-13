using OpenQA.Selenium;

namespace WebTechTest.PageObjects
{
    public class ShoppingPage : BasePage
    {
        public ShoppingPage(IWebDriver driver) : base(driver)
        {
        }

        private IReadOnlyCollection<IWebElement> ProductListWithAddToCart => driver.FindElements(By.CssSelector("[href^='?add-to-cart=']"));
        private IWebElement ViewCart => driver.FindElement(By.CssSelector("[href='https://cms.demo.katalon.com/cart/']"));

        public int GetProductListCount()
        {
            return this.ProductListWithAddToCart.Count;
        }

        public void AddItemsToCart(int ItemToAdd)
        {
            for (int i = 1; i <= ItemToAdd; i++)
            {
                this.ProductListWithAddToCart.ElementAt(i).Click();
                Thread.Sleep(1000);
            }
        }

        public void ClickViewCart()
        {
            this.ViewCart.Click();
        }
    }
}
