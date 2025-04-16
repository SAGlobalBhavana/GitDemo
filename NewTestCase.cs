using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace AmazonSearchTest
{
    [TestClass]
    public class AmazonSearchTests
    {
         private IWebDriver driver;
        private WebDriverWait wait;

        // Setup method to initialize the WebDriver
        [TestInitialize]
        public void SetUp()
        {
            // Initialize the ChromeDriver and WebDriverWait
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
        
      // Test method to search for laptops on Amazon
        [TestMethod]
        public void TestSearchLaptopOnAmazon()
        {
            // Navigate to Amazon's homepage
            driver.Navigate().GoToUrl("https://www.amazon.com");

            // Find the search bar by its ID and type 'laptop'
            IWebElement searchBox = driver.FindElement(By.Id("twotabsearchtextbox"));
            searchBox.SendKeys("laptop");
        
    }
}
