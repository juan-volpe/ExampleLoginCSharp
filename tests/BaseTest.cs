using Allure.Net.Commons;
using OpenQA.Selenium;

//* Abstract significa que no se van a poder hacer instancias (new) de esta clase.
public abstract class BaseTest
{
    //* Selenium Driver.
    protected IWebDriver driver;
    private string url = "https://www.saucedemo.com/";

    //* Anotación de NUnit para ejecutar un método antes de cada test.
    [SetUp]
    public void BeforeBaseTest()
    {   
        string browserName = "chrome";
        driver = BrowserSelector.ChooseBrowser(browserName);                
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl(url);
        Assert.That(driver.Url, Does.Contain("saucedemo"));
    }

    [OneTimeSetUp]
    public void ClearResultsDir()
    {
        AllureLifecycle.Instance.CleanupResultDirectory();
    }

    //* Anotación de NUnit para ejecutar un método después de cada test.
    [TearDown]
    public void AfterBaseTest()
    {
        if (driver != null) 
        {
            driver.Quit();
        }
    }
}