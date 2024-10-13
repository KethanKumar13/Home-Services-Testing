using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;

namespace HomeServices_Testing.Utilities
{
    public class BaseTest
    {
        protected IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            // Set up the Edge driver
            new DriverManager().SetUpDriver(new EdgeConfig());

            var options = new EdgeOptions();
            options.AddArgument("--ignore-certificate-errors");
            options.AddArgument("--allow-insecure-localhost");

            driver = new EdgeDriver(options);

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://localhost:4200/");
        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}
