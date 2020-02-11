using Integrivideo.Pages;
using OpenQA.Selenium;

namespace Integrivideo.Steps
{
    public class LoginPageSteps
    {
        private LoginPage loginPage;

        public LoginPageSteps(IWebDriver driver)
        {
            loginPage = new LoginPage(driver);
        }

        public LoginPageSteps LogIn(string login, string password)
        {
            loginPage
                .TypeLogin(login)
                .TypePassword(password)
                .ClickLoginButton();
            return this;
        }
    }
}