using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeServices_Testing.Utilities;
using OpenQA.Selenium;

namespace HomeServices_Testing.UnitTest
{
    internal class BaskeTest : BaseTest
    {
        [Test]
        public void Test3()
        {
            Thread.Sleep(2000);
            IWebElement services = driver.FindElement(By.XPath("//a[normalize-space()='Services']"));
            services.Click();
            Thread.Sleep(2000);

            Thread.Sleep(2000);
            IWebElement cart = driver.FindElement(By.XPath("//body[1]/app-root[1]/div[1]/app-shop[1]/div[1]/div[1]/section[2]/div[2]/div[1]/app-service-item[1]/div[1]/div[1]/div[1]/button[1]"));
             cart.Click();
            Thread.Sleep(2000);

            Thread.Sleep(2000);
            IWebElement cartclick = driver.FindElement(By.XPath("//i[@class='fa fa-shopping-cart fa-2x text-dark']"));
            cartclick.Click();
            Thread.Sleep(2000);

            IWebElement service = driver.FindElement(By.XPath("//a[normalize-space()='Carpet Cleaning']"));

            string Service = service.Text;

            Console.WriteLine(Service);

            Assert.AreEqual("Carpet Cleaning", Service);
        }
        
    }
}
