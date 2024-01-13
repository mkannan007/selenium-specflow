using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Configuration;

namespace WebTechTest.PageObjects
{
    public class CartPage : BasePage
    {
        public CartPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement table => driver.FindElement(By.CssSelector("table[class*='cart']"));
        private IReadOnlyCollection<IWebElement> ProductRows => driver.FindElements(By.CssSelector("tr[class*='cart_item']"));
        private IReadOnlyCollection<IWebElement> ProductQuantity => driver.FindElements(By.CssSelector("td[class='product-quantity']"));
        private IReadOnlyCollection<IWebElement> ProductPrice => driver.FindElements(By.CssSelector("td[class='product-price']"));

        public int GetProductListCount()
        {
            return this.ProductRows.Count;
        }

        public List<String> GetProductQuantityList()
        {
            List<String> productQuantityList = new List<string>();
            foreach (IWebElement productQuantity in ProductQuantity)
            {
                String productQuantityValue = productQuantity.FindElement(By.CssSelector("input[id*='quantity']")).GetAttribute("value");
                productQuantityList.Add(productQuantityValue);
            }

            //string inputString = String.Join(",", productQuantityList);
            //string[] elementsArray = inputString.Split(',');
            //productQuantityList = new List<string>(elementsArray);

            return productQuantityList;
        }
        public int SumProductQuantity()
        {
            int sum = 0;
            List<String> productQuantityList = GetProductQuantityList();
            foreach (String productQuantity in productQuantityList)
            {
                sum += Convert.ToInt32(productQuantity);
            }
            return sum;
        }

        public List<String> GetProductPriceList()
        {
            List<String> productPriceList = new List<String>();
            foreach (IWebElement productPrice in ProductPrice)
            {
                productPriceList.Add(productPrice.Text);
            }
            //string inputString = String.Join(",", productPriceList);
            //string[] elementsArray = inputString.Split(',');
            //productPriceList = new List<string>(elementsArray);

            return productPriceList;
        }

        public int GetLowestPriceItem()
        {
            List<String> productPriceList = GetProductPriceList();
            int lowestPriceIndex = 0;
            

            for (int i = 1; i < productPriceList.Count; i++)
            {
                if (Convert.ToDouble(productPriceList[i].Replace("$", "")) < Convert.ToDouble(productPriceList[lowestPriceIndex].Replace("$", "")))
                {
                    lowestPriceIndex = i;
                }
            }

            return lowestPriceIndex;
            //ProductRows.ElementAt(lowestPriceIndex).FindElement(By.CssSelector("a[class*='remove']")).Click();
        }

        public void RemoveLowestPriceItem()
        {
            ProductRows.ElementAt(GetLowestPriceItem()).FindElement(By.CssSelector("a[class*='remove']")).Click();
            Thread.Sleep(2000);
        }
    }
}
