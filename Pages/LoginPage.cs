﻿using OpenQA.Selenium;
using ProjectMars_2021.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projectmars2021.Pages
{
    class LoginPage
    {
        public void GoToHomePage(IWebDriver testDriver)
        {
            // Launch turn up portal and maximize window;
            testDriver.Navigate().GoToUrl(ConstantHelpers.BaseUrl);
            testDriver.Manage().Window.Maximize();
            testDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            testDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
        }

        public void ClickSignInBtn(IWebDriver testDriver)
        {
            // Identify Sign In button and click
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//*[@id='home']/div/div/div[1]/div/a", 2);
            IWebElement loginButton = testDriver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
            loginButton.Click();
        }

        public void KeyInCredentials1(IWebDriver testDriver, string Email, string Password)
        {
            // Identify the email textbox enter valid email
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "email", 2);
            IWebElement emailTextBox = testDriver.FindElement(By.Name("email"));
            emailTextBox.SendKeys(Email);

            // Identify password textbox enter valid password
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "password", 2);
            IWebElement passwordTextBox = testDriver.FindElement(By.Name("password"));
            passwordTextBox.SendKeys(Password);
        }

        internal void KeyInCredentials1(IWebDriver testDriver, object email, object password)
        {
            throw new NotImplementedException();
        }

        public void ClickLoginBtn(IWebDriver testDriver)
        {
            // Identify login button and click
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "/html/body/div[2]/div/div/div[1]/div/div[4]/button", 2);
            IWebElement loginButton = testDriver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();
        }

        public void CloseBrowser(IWebDriver testDriver)
        {
            testDriver.Close();
        }
        public void LoginPageSteps(IWebDriver testDriver)
        {
            // Launch turn up portal and maximize window
            testDriver.Navigate().GoToUrl(ConstantHelpers.BaseUrl);
            testDriver.Manage().Window.Maximize();
            testDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            testDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);

            // Identify Sign In button and click
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//*[@id='home']/div/div/div[1]/div/a", 2);
            IWebElement loginButton = testDriver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
            loginButton.Click();

            // Identify the email textbox enter valid email
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "email", 2);
            IWebElement emailTextBox = testDriver.FindElement(By.Name("email"));
            string Email = "shalanqa2011@gmail.com";
            emailTextBox.SendKeys(Email);

            // Identify password textbox enter valid password
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "password", 2);
            IWebElement passwordTextBox = testDriver.FindElement(By.Name("password"));
            string Password = "Auckland@2015";
            passwordTextBox.SendKeys(Password);

            // Identify login button and click
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "/html/body/div[2]/div/div/div[1]/div/div[4]/button", 3);
            IWebElement loginBtn = testDriver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginBtn.Click();
        }
    }
}