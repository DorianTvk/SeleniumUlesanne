using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace Seleniumülesanne
{
    public class FirstTestCase
    {
        static void Main(string[] args) 
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\Selenium\\Selenium\\Drivers", options);
            driver.Url = "file:///C:/Users/opilane/source/repos/onnelikud-autod-main/index.html/";
        }

    }
}
