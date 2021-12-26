using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProjectMars_2021.Pages;
using Projectmars2021.Pages;
using System;
using TechTalk.SpecFlow;

namespace ProjectMars_2021.Step_Definition
{
    [Binding]
    public class LoginPageSteps
     {
        LoginPage loginPageObj = new LoginPage();
        private IWebDriver testDriver;


        [Given(@"I logged into the Trade Skills portal successfully")]
        public void GivenILoggedIntoTheTradeSkillsPortalSuccessfully()
        {
            testDriver = new ChromeDriver();
            loginPageObj.GoToHomePage(testDriver);

        }

        [Given(@"I click on the sign in button")]
        public void GivenIClickOnTheSignInButton()
        {
            loginPageObj.ClickSignInBtn(testDriver);
        }
        
        [When(@"I enter valid '(.*)', '(.*)' records")]
        public void WhenIEnterValidRecords(string EmailID, string Password)
        {
            loginPageObj.KeyInCredentials1(testDriver, EmailID, Password);

        }

        [Then(@"I click on the login button")]
        public void ThenIClickOnTheLoginButton()
        {
            loginPageObj.ClickLoginBtn(testDriver);
        }

        [Then(@"I click on close browser")]
        public void ThenIClickOnCloseBrowser()
        {
            loginPageObj.CloseBrowser(testDriver);
        }
    }
}
