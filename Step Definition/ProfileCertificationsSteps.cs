using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using ProjectMars_2021.Pages;
using Projectmars2021.Pages;
using System;
using TechTalk.SpecFlow;

namespace ProjectMars_2021.Step_Definition
{
    [Binding]
    public class ProfileCertificationsSteps
    {
        // Login Page object initialization and definition
        LoginPage loginPageObj = new LoginPage();

        // Home Page object initialization and definition
        HomePage NaviHomePageObj = new HomePage();

        // Profile Certications Page object initialization and definition
        ProfileCertifications profileCertsObj = new ProfileCertifications();
        private ChromeDriver testDriver;

        [Given(@"I login to the Trade Skills portal for Certs successfully")]
        public void GivenILoginToTheTradeSkillsPortalForCertsSuccessfully()
        {
            // Open chrome browser
            testDriver = new ChromeDriver();
            loginPageObj.LoginPageSteps(testDriver);
        }
        
        [Given(@"I navigate to the skiils page under Certifications tab")]
        public void GivenINavigateToTheSkiilsPageUnderCertificationsTab()
        {
            NaviHomePageObj.CertificationsPage(testDriver);
        }
        
        [Given(@"I click on Add New button under Certifications tab")]
        public void GivenIClickOnAddNewButtonUnderCertificationsTab()
        {
            profileCertsObj.AddNewCertBtn(testDriver);
        }

        [When(@"I enter the records in '(.*)', '(.*)' and click on Add button")]
        public void WhenIEnterTheRecordsInAndClickOnAddButton(string Certificate, string From)
        {
            profileCertsObj.AddValidCert1(testDriver, Certificate, From);
        }

        [Then(@"The error popup message '(.*)' will shown")]
        public void ThenTheErrorPopupMessageWillShown(string Message)
        {
            // Assertion that error popup message record has been displayed.
            Assert.AreEqual(profileCertsObj.GetNotification(testDriver), Message, "Please enter Certification Name, Certification From and Certification Year");
        }

        [Then(@"I click on close browserTwo")]
        public void ThenIClickOnCloseBrowserTwo()
        {
            loginPageObj.CloseBrowser(testDriver);

        }


        [Given(@"I click on the Add New button under Certifications tab")]
        public void GivenIClickOnTheAddNewButtonUnderCertificationsTab()
        {
            profileCertsObj.AddNewCertBtn(testDriver);

        }

        [When(@"I enter the details in '(.*)', '(.*)', '(.*)' and click on add button")]
        public void WhenIEnterTheDetailsInAndClickOnAddButton(string Certificate, string From, string Year)
        {
            profileCertsObj.AddCertification(testDriver, Certificate, From, Year);

        }
        [Then(@"The display popup message '(.*)' will appear")]
        public void ThenTheDisplayPopupMessageWillAppear(string Message)
        {
            // Assertion that popup message record has been displayed.
            Assert.AreEqual(profileCertsObj.GetNotification(testDriver), Message, "ISTQB has been added to your certification");
        }

        [Then(@"A new row should be added as in '(.*)', '(.*)', '(.*)' successfully")]
        public void ThenANewRowShouldBeAddedAsInSuccessfully(string Certificate, string From, string Year)
        {
            // Assertion that Certificate, From and Year record has been added.
            Assert.AreEqual(profileCertsObj.GetCertification(testDriver), Certificate, "ISTQB has been added to your certification");
            Assert.AreEqual(profileCertsObj.GetFrom(testDriver), From, "INDIA has been added to your certification");
            Assert.AreEqual(profileCertsObj.GetYear(testDriver), Year, "2016 has been added to your certification");
        }
                    


        [Then(@"I click on close browserThree")]
        public void ThenIClickOnCloseBrowserThree()
        {
            loginPageObj.CloseBrowser(testDriver);
        }


        [Given(@"I click on the Add New button under Certifications section")]
        public void GivenIClickOnTheAddNewButtonUnderCertificationsSection()
        {
            profileCertsObj.AddNewCertBtn(testDriver);

        }

        [When(@"I enter the record in '(.*)', '(.*)', '(.*)' and click on Add button")]
        public void WhenIEnterTheRecordInAndClickOnAddButton(string Certificate, string From, string SecondYear)
        {
            profileCertsObj.AddCertification2(testDriver, Certificate, From, SecondYear);

        }

        [When(@"The error popup message of '(.*)' will be shown")]
        public void WhenTheErrorPopupMessageOfWillBeShown(string Message)
        {
            // Assertion that error popup message record has been displayed.
            Assert.AreEqual(profileCertsObj.GetNotification(testDriver), Message, "Data Duplicated");
        }

        [When(@"I enter the record '(.*)', '(.*)', '(.*)' and click on add button")]
        public void WhenIEnterTheRecordAndClickOnAddButton(string Certificate, string From, string SecondYear)
        {
            profileCertsObj.AddCertification2(testDriver, Certificate, From, SecondYear);

        }

        [When(@"The display prompt message '(.*)' will appear")]
        public void WhenTheDisplayPromptMessageWillAppear(string Message)
        {
            // Assertion that error popup message record has been displayed.
            Assert.AreEqual(profileCertsObj.GetNotification(testDriver), Message, "Duplicated data");
        }

        [Then(@"I click on close browserFive")]
        public void ThenIClickOnCloseBrowserFive()
        {
            loginPageObj.CloseBrowser(testDriver);
        }

        [Given(@"I click on the Certification pen icon")]
        public void GivenIClickOnTheCertificationPenIcon()
        {
            profileCertsObj.EditNewCertBtn(testDriver);
        }


        [When(@"edit the data in '(.*)', '(.*)', '(.*)' and click on Add button")]
        public void WhenEditTheDataInAndClickOnAddButton(string Certificate, string From, string SecondYear)
        {
            profileCertsObj.EditCertification(testDriver, Certificate, From, SecondYear);
        }

        [When(@"The prompt message of the '(.*)' will appear")]
        public void WhenThePromptMessageOfTheWillAppear(string Message)
        {
            // Assertion that popup message record has been displayed.
            Assert.AreEqual(profileCertsObj.GetNotification(testDriver), Message, "CTFL-AuT has been updated to your certification");
        }

        [Then(@"The new row should be updated as '(.*)', '(.*)', '(.*)' successfully")]
        public void ThenTheNewRowShouldBeUpdatedAsSuccessfully(string Certificate, string From, string Year)
        {
            // Assertion that Certificate, From and Year record has been edited.
            Assert.AreEqual(profileCertsObj.GetCertification(testDriver), Certificate, "CT-MT has been updated to your certification");
            Assert.AreEqual(profileCertsObj.GetFrom(testDriver), From, "ISTQB has been updated to your certification");
            Assert.AreEqual(profileCertsObj.GetYear(testDriver), Year, "2019 has been updated to your certification");
        }

        [Then(@"I click on close browserFour")]
        public void ThenIClickOnCloseBrowserFour()
        {
            loginPageObj.CloseBrowser(testDriver);
        }



        [Given(@"I click on delete icon under Certification tab")]
        public void GivenIClickOnDeleteIconUnderCertificationTab()
        {
            profileCertsObj.DeleteNewCertBtn(testDriver);
        }

        [Then(@"The display error popup message '(.*)' will shown")]
        public void ThenTheDisplayErrorPopupMessageWillShown(string Message)
        {
            // Assertion that popup message record has been displayed.
            Assert.AreEqual(profileCertsObj.GetNotification(testDriver), Message, "CTFL-AuT has been deleted from your certification");
        }


        [Then(@"the Certification should have the deleted successfully")]
        public void ThenTheCertificationShouldHaveTheDeletedSuccessfully()
        {
            string editedCertification = profileCertsObj.GetCertification2(testDriver);
            string editedFrom = profileCertsObj.GetFrom2(testDriver);
            string editedYear = profileCertsObj.GetYear2(testDriver);


            Assert.AreNotEqual(editedCertification == "ISTQB-V2", "Actual Certification and expected certification don't match");
            Assert.AreNotEqual(editedFrom == "INDIA", "Actual From and expected from don't match");
            Assert.AreNotEqual(editedYear == "2020", "Actual Year and expected year don't match");

        }
                  
        
       
        
        [Then(@"I click on close browserSix")]
        public void ThenIClickOnCloseBrowserSix()
        {
            loginPageObj.CloseBrowser(testDriver);
        }
    }
}
