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
    }
}
