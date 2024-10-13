using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeServices_Testing.Utilities;
using OpenQA.Selenium;

namespace HomeServices_Testing.UnitTest
{
    internal class SignupRequiredField : BaseTest
    {
        public void Test2()
        {
            driver.FindElement(By.XPath("//a[normalize-space()='Sign up']")).Click();

            // Check if the error messages are displayed
            Assert.IsTrue(driver.FindElement(By.XPath("//span[normalize-space()='Display Name is required']")).Displayed);
            Assert.IsTrue(driver.FindElement(By.XPath("//span[normalize-space()='Email Address is required']")).Displayed);
            Assert.IsTrue(driver.FindElement(By.XPath("//span[normalize-space()='Password is required']")).Displayed);
        }
    }
}
