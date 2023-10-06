using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using OpenQA.Selenium;

//* Anotación de NUnit para marcar una clase que contenga los casos de prueba.
[TestFixture(Author = "Juan Volpe", Description = "Example Login")]
[AllureNUnit]
//* Clase que hereda de BaseTest.
public class LoginTest : BaseTest
{
    private void Login(string username, string password)
    {
        LoginPage loginPage = new LoginPage(driver);

        loginPage.EnterUsername(username);
        loginPage.EnterPassword(password);
        loginPage.SubmitButton();

        Thread.Sleep(1000);        
    }
    
    [Test] //* Anotación de NUnit para marcar a un método como un caso de prueba automatizado.
    [AllureTag("Smoke", "Sanity", "Regression")]
    [AllureSeverity(SeverityLevel.critical)]
    [Description("TC1: Validar poder iniciar sesión con credenciales válidas.")]
    public void TC1()
    {
        Login("standard_user", "secret_sauce");

        Assert.That(driver.Url, Does.Contain("inventory"));
    }

    [Test]
    [AllureTag("Smoke", "Sanity", "Regression")]
    [AllureSeverity(SeverityLevel.critical)]
    [Description("TC2: Validar NO poder iniciar sesión con usuario locked_out_user.")]
    public void TC2()
    {
        Login("locked_out_user", "secret_sauce");
        
        Assert.That(driver.Url, Does.Not.Contain("inventory"));
    }

    [Test]
    [AllureTag("Smoke", "Sanity", "Regression")]
    [AllureSeverity(SeverityLevel.critical)]
    [Description("TC3: Validar poder iniciar sesión con usuario problem_user.")]
    public void TC3()
    {
        Login("problem_user", "secret_sauce");
        
        Assert.That(driver.Url, Does.Contain("inventory"));
    }

    [Test]
    [AllureTag("Smoke", "Sanity", "Regression")]
    [AllureSeverity(SeverityLevel.critical)]
    [Description("TC4: Validar poder iniciar sesión con usuario performance_glitch_user.")]
    public void TC4()
    {
        Login("performance_glitch_user", "secret_sauce");
        
        Assert.That(driver.Url, Does.Contain("inventory"));
    }

    [Test]
    [AllureTag("Smoke", "Sanity", "Regression")]
    [AllureSeverity(SeverityLevel.critical)]
    [Description("TC5: Validar NO poder iniciar sesión con campos vacíos.")]
    public void TC5()
    {
        Login(string.Empty, string.Empty);
        
        //* Obtiene el elemento que contiene el mensaje de error.
        IWebElement errorElement = driver.FindElement(By.CssSelector("[data-test=error]"));

        //* Obtiene el texto del elemento.
        string actualErrorMessage = errorElement.Text;

        //* Define el texto esperado.
        string expectedErrorMessage = "Epic sadface: Username is required";

        //* Realiza la afirmación para verificar si el texto coincide.
        Assert.That(actualErrorMessage, Is.EqualTo(expectedErrorMessage));
    }
}