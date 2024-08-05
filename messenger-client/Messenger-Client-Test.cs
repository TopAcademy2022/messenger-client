using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace messenger_client
{
    public class Demo
    {

        IWebDriver driver;
        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("D:\\3rdparty\\chrome");
        }
        [Test]
        public void test()
        {
            driver.Url = "http://www.google.co.in";
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}