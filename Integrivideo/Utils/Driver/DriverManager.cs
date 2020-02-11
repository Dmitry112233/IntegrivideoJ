using OpenQA.Selenium;

namespace Integrivideo.Utils.Driver
{
    public class DriverManager
    {
        protected IWebDriver Driver;

        protected virtual void CreateWebDriver()
        {
        }

        public void QuitWebDriver()
        {
            if (Driver != null)
            {
                Driver.Quit();
            }
        }

        public IWebDriver GetWebDriver() {
            if (null == Driver) {
                CreateWebDriver();
            }
            return Driver;
        }
    }
}