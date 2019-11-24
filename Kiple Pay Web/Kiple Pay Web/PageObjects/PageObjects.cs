using FluentAssertions;
using OpenQA.Selenium;
using Xunit;

namespace Kiple_Pay_Web.PageObjects
{
    public abstract class PageObjects
    {
        private readonly IWebDriver _driver;

        public PageObjects(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Navigate(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void AssertTitle(string title)
        {
            string pageTitle = _driver.Title;
            pageTitle.Should().Be(title);
        }

        public void CloseSession()
        {
            _driver.Close();
        }

    }
}