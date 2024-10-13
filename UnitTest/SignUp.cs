using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeServices_Testing.Utilities;
using OpenQA.Selenium;

namespace HomeServices_Testing.UnitTest
{
    internal class SignUp : BaseTest
    {

        [Test]
        public void Test2()
        {
            Thread.Sleep(2000);
            IWebElement signup = driver.FindElement(By.XPath("//a[normalize-space()='Sign up']"));
            signup.Click();
            Thread.Sleep(2000);

            IWebElement name = driver.FindElement(By.XPath("//input[@id='Display Name']"));
            name.Click();
            Thread.Sleep(2000);
            name.SendKeys("kethan");

            IWebElement email = driver.FindElement(By.XPath("//input[@id='Email Address']"));
            email.Click();
            Thread.Sleep(2000);
            email.SendKeys("kethankumar136@gmail.com");

            IWebElement password = driver.FindElement(By.XPath("//input[@id='Password']"));
            password.Click();
            password.SendKeys("Pas$w0rd");
            Thread.Sleep(2000);

            IWebElement register = driver.FindElement(By.XPath("//button[normalize-space()='Register']"));
            register.Click();
            Thread.Sleep(2000);
        }

    }
}
