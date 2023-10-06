# ***CONFIGURACIÓN PASO A PASO PARA INSTALAR UN PROYECTO CON SELENIUM EN C# Y NUNIT.***

**Abrir la terminal de VSC e instalar las siguientes dependencias:**
- dotnet new nunit
- dotnet add package Selenium.WebDriver
- dotnet add package Selenium.Support
- dotnet add package WebDriverManager

**Para ejecutar las pruebas usar el comando:**
- dotnet test

**Para ejecutar el reporte usar el comando:**
- ./allureReport.sh

**Documentación:**
- https://docs.nunit.org/articles/nunit/intro.html
- https://github.com/rosolko/WebDriverManager.Net#info
- https://docs.qameta.io/allure/