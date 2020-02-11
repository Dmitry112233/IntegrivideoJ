using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace Integrivideo.Pages
{
    public class LoginPage
    {
        
        private static readonly log4net.ILog log = log4net.LogManager
            .GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        
        private IWebDriver _driver;
        
        private readonly By _fieldLogin = By.XPath("//input[@placeholder='Email']");
        private readonly By _fieldPassword = By.XPath("//input[@placeholder='Password']");
        private readonly By _buttonLogin= By.XPath("//button[@class='btn btn-primary']");

        public LoginPage(IWebDriver driver)
        {
            this._driver = driver;
        }

        public LoginPage TypeLogin(string login)
        {
            log.Info("Type login: " + login);
            
            new WebDriverWait(_driver, TimeSpan.FromSeconds(5))
                .Until(ExpectedConditions.ElementExists(_fieldLogin));
            
            _driver.FindElement(_fieldLogin).SendKeys(login);
            return this;
        }
        
        public LoginPage TypePassword(string password)
        {
            log.Info("Type login: " + password);
            _driver.FindElement(_fieldPassword).SendKeys(password);
            return this;
        }
        
        public LoginPage ClickLoginButton()
        {
            _driver.FindElement(_buttonLogin).Click();
            return this;
        }
    }
}