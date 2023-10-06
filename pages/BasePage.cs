using OpenQA.Selenium;

//* Abstract significa que no se van a poder hacer instancias (new) de esta clase.
public abstract class BasePage
{
    //* Selenium Driver.
    protected IWebDriver driver;

    public BasePage(IWebDriver driver)
    {   
        this.driver = driver;
    }
}