using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using ProjectMars_2021.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProjectMars_2021.Pages
{
    class ProfileDescription
    {
        private IWebDriver testDriver;

        public void DescriptionPenIcon(IWebDriver testDriver)
        {
            // Identify Description icon and click
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i", 4);
            IWebElement DescriptionIcon = testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
            DescriptionIcon.Click();
            testDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }
        public void AddDescription(IWebDriver testDriver, string Description)
        {
            this.testDriver = testDriver;
            Actions Hover = new Actions(testDriver);

            //Identify and enter valid description

            WaitHelpers.WaitForElementPresent(testDriver, "Name", "value", 2);
            IWebElement descriptionTextBox = testDriver.FindElement(By.Name("value"));
            Hover.Click(descriptionTextBox).Perform();
            descriptionTextBox.Clear();
            Thread.Sleep(2000);
            descriptionTextBox.SendKeys(Description);

            //Click on Save Button
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "(//button[text()='Save'])[2]", 5);
            IWebElement SaveDescButton = testDriver.FindElement(By.XPath("(//button[text()='Save'])[2]"));
            SaveDescButton.Click();

        }

        public string GetDescription1(IWebDriver testDriver)
        {
            IWebElement newDescription1 = testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
            return newDescription1.Text;
        }

        public void EditDescription(IWebDriver testDriver, string Description)
        {
            this.testDriver = testDriver;


            // Identify the description textarea enter valid description
            WaitHelpers.WaitForElementPresent(testDriver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea", 2);
            IWebElement descriptionTextBox = testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
            descriptionTextBox.Clear();
            Thread.Sleep(2000);
            descriptionTextBox.SendKeys(Description);

            // Click on "Save" button
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button", 5);
            IWebElement saveButton = testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            saveButton.Click();


        }
        public string GetDescription2(IWebDriver testDriver)
        {
            IWebElement newDescription1 = testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/span"));
            return newDescription1.Text;
        }



    }
}
