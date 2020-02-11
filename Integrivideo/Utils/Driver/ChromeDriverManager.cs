using OpenQA.Selenium.Chrome;

namespace Integrivideo.Utils.Driver
{
    public class ChromeDriverManager : DriverManager
    {
        protected override void CreateWebDriver() 
        {
            Driver = new ChromeDriver();
        }
    }
}