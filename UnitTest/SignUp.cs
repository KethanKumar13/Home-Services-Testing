using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeServices_Testing.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

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

        [Test]
        public void TestSignUpWithEmptyFields()
        {
            Thread.Sleep(2000);
            IWebElement signup = driver.FindElement(By.XPath("//a[normalize-space()='Sign up']"));
            signup.Click();
            Thread.Sleep(2000);

            IWebElement name = driver.FindElement(By.XPath("//input[@id='Display Name']"));
            name.Click();
            Thread.Sleep(2000);
            name.SendKeys("");

            IWebElement email = driver.FindElement(By.XPath("//input[@id='Email Address']"));
            email.Click();
            Thread.Sleep(2000);
            email.SendKeys("");

            IWebElement password = driver.FindElement(By.XPath("//input[@id='Password']"));
            password.Click();
            password.SendKeys("");
            Thread.Sleep(2000);

            IWebElement register = driver.FindElement(By.XPath("//button[normalize-space()='Register']"));
            register.Click();
            Thread.Sleep(2000);


            IWebElement nameError = driver.FindElement(By.XPath("//span[normalize-space()='Display Name is required']"));
            IWebElement emailError = driver.FindElement(By.XPath("//span[normalize-space()='Email Address is required']"));
            IWebElement passwordError = driver.FindElement(By.XPath("//span[normalize-space()='Password is required']"));

            // Assert that error messages are displayed
            Assert.IsTrue(nameError.Displayed, "Error message for Display Name is not displayed.");
            Assert.IsTrue(emailError.Displayed, "Error message for Email Address is not displayed.");
            Assert.IsTrue(passwordError.Displayed, "Error message for Password is not displayed.");
        }

    }
}
