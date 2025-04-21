using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
// - Added by BHavanaa 
// Feature 3 added 
// to add the cleanup code

// Feature 2 -    // Find and click the search button
 // Find and click the search button - Commit
            IWebElement searchButton = driver.FindElement(By.Id("nav-search-submit-button"));
            searchButton.Click();

            // Wait until the page title contains 'laptop', indicating the search results page has loaded
            wait.Until(driver => driver.Title.Contains("laptop"));

            // Verify that the page title contains the search term 'laptop'
            Assert.IsTrue(driver.Title.Contains("laptop"), "The page title does not contain 'laptop'");

            // Optionally: Print out the page title for confirmation
            Console.WriteLine("Page title after search: " + driver.Title);
        }

// Feature 2 -    // Find and click the search button
 // Find and click the search button - Commit
            IWebElement searchButton = driver.FindElement(By.Id("nav-search-submit-button"));
            searchButton.Click();

            // Wait until the page title contains 'laptop', indicating the search results page has loaded
            wait.Until(driver => driver.Title.Contains("laptop"));

            // Verify that the page title contains the search term 'laptop'
            Assert.IsTrue(driver.Title.Contains("laptop"), "The page title does not contain 'laptop'");

            // Optionally: Print out the page title for confirmation
            Console.WriteLine("Page title after search: " + driver.Title);
        }
// Bhavanaa
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

              // Find and click the search button
            IWebElement searchButton = driver.FindElement(By.Id("nav-search-submit-button"));
            searchButton.Click();

         
        // Cleanup method to close the browser after the test
        [TestCleanup]
        public void CleanUp()
        {
            // Close the driver (browser)
            driver.Quit();
        }


            // New Logic to be added to Home page 
            // Find the search bar by its ID and type 'laptop'
            IWebElement searchBox = driver.FindElement(By.Id("twotabsearchtextbox"));
            searchBox.SendKeys("laptop");

            // Find and click the search button
            IWebElement searchButton = driver.FindElement(By.Id("nav-search-submit-button"));
            searchButton.Click();

            // Wait until the page title contains 'laptop', indicating the search results page has loaded
        }

         
    }

}
