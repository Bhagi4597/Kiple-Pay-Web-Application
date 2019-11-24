using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;
using NUnit;
using TechTalk.SpecFlow;
using Kiple_Pay_Web.PageObjects;

namespace Kiple_Pay_Web.StepDefinitions
{
    [Binding]
    public class SignUpSteps
    {
        private readonly SignUp _page;
        private readonly IWebDriver _driver;

        public SignUpSteps(IWebDriver driver)
        {
            _driver = driver;
            _page = new SignUp(driver);
        }


        [Given(@"I navigate to Kiple Pay website")]
        public void NavigateToApplication()
        {
            _page.Navigate();
            _page.Delay();

        }

        [Then(@"verify navigated to Kiple Pay Website")]
        public void VerifyNavigatedToKiplePayWebsite()
        {
            _page.PageTitle();
            bool isSignUpExist = _page.IsElementexist("//*[text()='Sign In']");
            _page.AssertTwoBooleanValues(isSignUpExist, true);
            bool isSignInExist = _page.IsElementexist("//*[text()='Sign Up']");
            _page.AssertTwoBooleanValues(isSignInExist, true);
           
        }

        [When(@"I click on Sign UP button in menu bar")]
        public void ClickOnSighUp()
        {
            _page.ClickSignUpMenu();
            _page.Delay();



        }

        [Then(@"verify navigated to sigh up page")]
        public void VerifyNavigatedToSignUp()
        {

            bool pageTitleExist = _page.IsElementexist("//*[text()='Sign up a Kiple Account']");
            _page.AssertTwoBooleanValues(pageTitleExist, true);


        }


        [When(@"I enter full name (.*) in name text field")]
        public void EnterFullName(String fullName)
        {
            _page.EnterUsername(fullName);

        }

        [When(@"I enter email address (.*) in email text field")]
        public void EnterEmailAddress(String emailAddress)
        {
            _page.EnterEmailAddress(emailAddress);

        }

        [When(@"I enter password (.*) in password text field")]
        public void EnterPassword(String password)
        {
            _page.EnterPassword(password);


        }

        [When(@"I enter same password (.*) in verify text field")]
        public void VerifyPassword(String password)
        {
            _page.VerifyPassword(password);
            _page.ScrollTillEnd();
          


        }

        [When(@"I accept privacy terms")]
        public void AcceptPrivacyTerms()
        {
            //Unable to automate captcha

        }

        [When(@"I click on sign up button after entering all details")]
        public void ClickOnSignUpAfterEnteringAllData()
        {
            _page.ClickSignUp();
            _page.Delay();

        }

        [Then(@"verify output messages")]
        public void VerifyPopupMessage()
        {
            //verify captcha is there
            bool isCaptchaAlertExist = _page.IsElementexist("//h2[text()='Please check your Recaptcha Box.']");
            _page.AssertTwoBooleanValues(isCaptchaAlertExist, true);

            //accept captcha
            _page.AcceptAlertMessages();
            
        }

        [Then(@"close session of driver")]
        public void CloseDriverSession()
        {
            _page.CloseSession();
        }
    }
 }
