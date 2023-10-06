# ***CONFIGURACIÓN PASO A PASO PARA INSTALAR UN PROYECTO CON SELENIUM EN C# Y NUNIT.***

**Abrir la terminal de VSC e instalar las siguientes dependencias:**
- dotnet new nunit
[Link para ver la documentación oficial de nunit:](https://docs.nunit.org/articles/nunit/intro.html)

- dotnet add package Selenium.WebDriver

- dotnet add package Selenium.Support

- dotnet add package WebDriverManager 
[Link para ver documentación en GitHub de WebDriverManager:](https://github.com/rosolko/WebDriverManager.Net#info)

**Para ejecutar las pruebas usar el comando:**
dotnet test

**Para los reportes se utiliza allure report**
[Link para ver documentación oficial de allure:](https://docs.qameta.io/allure/)

**Para ejecutar el reporte usar el comando:**
./allureReport.sh