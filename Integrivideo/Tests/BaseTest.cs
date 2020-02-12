using System;
using Integrivideo.Steps;
using Integrivideo.Utils.Driver;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Integrivideo.Tests
{
    public class BaseTest
    {
        protected DriverManager DriverManager;
        protected IWebDriver Driver;

        protected readonly string Login = "integriuser2@mailinator.com";
        protected readonly string Password = "integripassword";

        protected LoginPageSteps LoginPageSteps;

        public static void Main()
        {
            Console.WriteLine("test test");
        }
        
        [SetUp]
        public void Initialize()
        {
            DriverManager = DriverManagerFactory.GetDriverManager(DriverType.CHROME);
            Driver = DriverManager.GetWebDriver();
            Driver.Navigate().GoToUrl("https://dev.integrivideo.com/app/projects");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);
            
            LoginPageSteps = new LoginPageSteps(Driver);
        }

        [TearDown]
        public void Quite()
        {
            DriverManager.QuitWebDriver();
        }
    }
}