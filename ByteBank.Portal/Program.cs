// See https://aka.ms/new-console-template for more information

using ByteBank.Portal.Infraestrutura;

//Console.WriteLine("Hello, World!");

var prefixos = new string[] { "http://localhost:5341/" };
var webApplication = new WebApplication(prefixos);
webApplication.Iniciar();