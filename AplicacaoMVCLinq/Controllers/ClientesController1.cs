using AplicacaoMVCLinq.Models;
using Microsoft.AspNetCore.Mvc;

namespace AplicacaoMVCLinq.Controllers
{
    public class ClientesController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetClientes()
        {
            Clientes c1 = new Clientes(1, "Alice", "alice@example.com", "1234-5678", new DateOnly(2000, 6, 1));
            Clientes c2 = new Clientes(2, "Ana", "Ana@exemple.com", "2345-6543", new DateOnly(23, 4, 1));
            Clientes c3 = new Clientes(3, "joana", "Joana@exemple.com", "9463-8635", new DateOnly(23, 4, 1));
            Clientes c4 = new Clientes(4, "Joao", "Joaoexemple.com", "6789-2345", new DateOnly(22, 4, 5));
            Clientes c5 = new Clientes(5, "Paulo", "Paulo@exemple.com", "1356-9467", new DateOnly(23, 4, 1));


            List<Clientes> ListaClientes = new List<Clientes>();
            ListaClientes.Add(c1);
            ListaClientes.Add(c2);
            ListaClientes.Add(c3);
            ListaClientes.Add(c4);
            ListaClientes.Add(c5);

            return View();
        }


    }
}
