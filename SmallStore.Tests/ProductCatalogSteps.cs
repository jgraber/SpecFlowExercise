using System;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace SmallStore.Tests
{
    [Binding]
    public class ProductCatalogSteps
    {
        [Given(@"the product catalog has (.*) items")]
        public void GivenTheProductCatalogHasItems(int p0)
        {
            //ScenarioContext.Current.Pending();
        }

        [When(@"I navigate to the store")]
        public void WhenINavigateToTheStore()
        {
        }

        [Then(@"I find those (.*) items on the start page")]
        public void ThenIFindThoseItemsOnTheStartPage(int numberOfItems)
        {
            var storePage = "http://localhost:8717/";
            using (var driver = new FirefoxDriver())
            {
                driver.Navigate().GoToUrl(storePage);
                var itemsOnPage = driver.FindElementById("itemCount").Text;
                Assert.AreEqual(numberOfItems.ToString(), itemsOnPage);
                driver.Quit();
            }


        }
    }
}
