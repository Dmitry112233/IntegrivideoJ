namespace Integrivideo.Utils.Driver
{
    public class DriverManagerFactory
    {
        public static DriverManager GetDriverManager(DriverType type) {
            DriverManager driverManager;
            
            switch (type) {
                case DriverType.CHROME:
                    driverManager = new ChromeDriverManager();
                    break;
                default:
                    driverManager = new ChromeDriverManager();
                    break;
            }
            return driverManager;
        }
    }
}