using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

public class BrowserSelector
{
    public static IWebDriver ChooseBrowser(string browserName)
    {
        IWebDriver driver;

        switch (browserName.ToLower())
        {
            case "chrome":
                new DriverManager().SetUpDriver(new ChromeConfig());
                driver = new ChromeDriver();
                break;

            case "edge":
                new DriverManager().SetUpDriver(new EdgeConfig());
                driver = new EdgeDriver();
                break;
            
            case "firefox":
                new DriverManager().SetUpDriver(new FirefoxConfig());
                driver = new FirefoxDriver();
                break;

            default:
                throw new ArgumentException("Navegador no válido.");
        }

        return driver;
    }
}