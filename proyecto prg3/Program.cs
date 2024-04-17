using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
class Program
{
    
        static void Main(string[] args)
    {
        // Inicializar el WebDriver
        IWebDriver driver = new ChromeDriver();

        // Navegar a la página web de Google
        driver.Navigate().GoToUrl("https://www.google.com");

        try
        {
            // Prueba 1: Verificar el título de la página
            string expectedTitle = "Google";
            string actualTitle = driver.Title;
            Console.WriteLine("Prueba 1 - Verificar el título de la página:");
            Console.WriteLine("  Resultado: " + (expectedTitle == actualTitle ? "PASSED" : "FAILED"));

            // Prueba 2: Verificar que el campo de búsqueda esté presente
            IWebElement searchBox = driver.FindElement(By.Name("q"));
            bool isSearchBoxDisplayed = searchBox.Displayed;
            Console.WriteLine("Prueba 2 - Verificar que el campo de búsqueda esté presente:");
            Console.WriteLine("  Resultado: " + (isSearchBoxDisplayed ? "PASSED" : "FAILED"));

            // Prueba 3: Verificar que el botón de búsqueda esté presente
            IWebElement searchButton = driver.FindElement(By.Name("btnK"));
            bool isSearchButtonDisplayed = searchButton.Displayed;
            Console.WriteLine("Prueba 3 - Verificar que el botón de búsqueda esté presente:");
            Console.WriteLine("  Resultado: " + (isSearchButtonDisplayed ? "PASSED" : "FAILED"));

            // Prueba 4: Verificar que el enlace de "Acerca de" esté presente en el pie de página
            IWebElement aboutLink = driver.FindElement(By.LinkText("Privacidad"));
            bool isAboutLinkDisplayed = aboutLink.Displayed;
            Console.WriteLine("Prueba 4 - Verificar que el enlace de 'Acerca de' esté presente en el pie de página:");
            Console.WriteLine("  Resultado: " + (isAboutLinkDisplayed ? "PASSED" : "FAILED"));

            // Prueba 5: Verificar que el enlace de "Gmail" esté presente en el pie de página
            IWebElement gmailLink = driver.FindElement(By.PartialLinkText("Gmail"));
            bool isGmailLinkDisplayed = gmailLink.Displayed;
            Console.WriteLine("Prueba 5 - Verificar que el enlace de 'Gmail' esté presente en el pie de página:");
            Console.WriteLine("  Resultado: " + (isGmailLinkDisplayed ? "PASSED" : "FAILED"));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error durante la ejecución de las pruebas: " + ex.Message);
        }
        finally
        {
            // Cerrar el WebDriver
            
        
        }
    }
}