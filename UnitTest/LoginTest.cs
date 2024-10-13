﻿using System;
using System.Threading;
using HomeServices_Testing.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace HomeServices_Testing.UnitTest
{
    internal class LoginTest : BaseTest
    {
        [Test]
        public void Test1()
        {
            Thread.Sleep(2000);
            IWebElement login = driver.FindElement(By.XPath("//a[normalize-space()='Login']"));
            login.Click();
            Thread.Sleep(2000);

            IWebElement email = driver.FindElement(By.XPath("//input[@id='Email Address']"));
            email.Click();
            Thread.Sleep(2000);
            email.SendKeys("kethankumar2002@gmail.com");

            IWebElement password = driver.FindElement(By.XPath("//input[@id='Password']"));
            password.Click();
            password.SendKeys("Pas$w0rd");
            Thread.Sleep(2000);

            IWebElement signin = driver.FindElement(By.XPath("/html[1]/body[1]/app-root[1]/div[1]/app-login[1]/div[1]/div[1]/form[1]"));
            signin.Click();
            Thread.Sleep(2000);
        }
    }
}
