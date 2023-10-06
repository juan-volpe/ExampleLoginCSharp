using OpenQA.Selenium;

//* Clase que hereda de BasePage.
public class LoginPage : BasePage
{
    //* Localizadores. 
    private By usernameInput = By.CssSelector("[data-test=username]");
    private By passwordInput = By.CssSelector("[data-test=password]");
    private By submitButton = By.CssSelector("[data-test=login-button]");

    //* Constructor.
    public LoginPage(IWebDriver driver) : base(driver)
    {
        
    }

    //* Método para escribir el username.
    public void EnterUsername(string username)
    {
        driver.FindElement(usernameInput).SendKeys(username);
    }

    //* Método para escribir el password.
    public void EnterPassword(string password)
    {
        driver.FindElement(passwordInput).SendKeys(password);
    }

    //* Método para hacer click en el botón de Login.
    public void SubmitButton()
    {
        driver.FindElement(submitButton).Click();
    }
}