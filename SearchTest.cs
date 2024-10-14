using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using HomeServices_Testing.Utilities;
using Microsoft.VisualStudio.TestPlatform.PlatformAbstractions.Interfaces;

namespace HomeServices_Testing
{
    internal class SearchTest : BaseTest
    {
        [Test]
        public void BasicSearchTest()
        {
            Thread.Sleep(2000);
            IWebElement services = driver.FindElement(By.XPath("//a[normalize-space()='Services']"));
            services.Click();
            Thread.Sleep(2000);

            // Find the search bar element
            IWebElement searchBar = driver.FindElement(By.XPath("//input[@placeholder='Search']"));
            searchBar.Click();
            Thread.Sleep(1000);

            // Enter search query and submit
            string searchQuery = "CARPET CLEANING";
            searchBar.SendKeys(searchQuery);
            searchBar.SendKeys(Keys.Enter);
            Thread.Sleep(2000);

            // Verify search results
            IWebElement searchResults = driver.FindElement(By.XPath("//h6[normalize-space()='Carpet Cleaning']"));
            Assert.IsTrue(searchResults.Text.Contains(searchQuery), "Search results do not contain the query.");
        }

        

    }
}
