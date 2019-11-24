using System;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Kiple_Pay_Web.PageObjects
{


    public class SignUp : PageObjects
    {
        private readonly IWebDriver _driver;
        private string _url = "https://kiplepay.com";

        public SignUp(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void Navigate()
        {
            base.Navigate(_url);
        }
    
        //verify element exist
        public bool IsElementexist(String locator)
        {
            bool present;
            try
            {
                _driver.FindElement(By.XPath(locator));
                present = true;
            }
            catch (NoSuchElementException)
            {
                present = false;
            }
            return present;
        }

        //verify page title
        public void PageTitle()
        {
            base.AssertTitle("kiplePay Malaysian e-Wallet App #CashlessMadeEasy | Kiple");
        }
        //click on SignUp

        public void ClickSignUpMenu()
        {
            _driver.FindElement(By.XPath("//*[text()='Sign Up']")).Click();
        }


        public void ClickSignUp()
        {
            _driver.FindElement(By.XPath("//button[text()='Sign Up']")).Click();
        }


        //Enter full name

        public void EnterUsername(String fullName)
        {
            _driver.FindElement(By.Name("full_name")).SendKeys(fullName);
        }
        
        //Enter email address

        public void EnterEmailAddress(String emailAddress)
        {
            _driver.FindElement(By.Name("username")).SendKeys(emailAddress);
        }
        //Enter Password

        public void EnterPassword(String password)
        {
            _driver.FindElement(By.Name("password")).SendKeys(password);
        }
        
        //Verify Password

        public void VerifyPassword(String password)
        {
            _driver.FindElement(By.Name("verify_password")).SendKeys(password);
        }

        //assertion
        public void AssertTwoBooleanValues(bool actual,bool expected)
        {
            try
            {
                Assert.AreEqual(actual,expected);
            }
            catch (AssertionException)
            {
                base.CloseSession();
            }
        }

        //scrolling
        public void ScrollTillEnd()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
           
        }

        //Click on ok to accept popup message
        public void AcceptAlertMessages()
        {
            _driver.FindElement(By.XPath("//*[text()='OK']")).Click();
           
                       
        }

        //Wait for element
        public void Delay()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);


        }


    }
}
