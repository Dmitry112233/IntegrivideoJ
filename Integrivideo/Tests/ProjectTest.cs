using NUnit.Framework;

namespace Integrivideo.Tests
{
    public class ProjectTest : BaseTest
    {
        
        [Test, Order(1)]
        [Description("Login test")]
        public void Test_LogIn()
        {
            LoginPageSteps.LogIn(Login, Password);
        }
    }
}