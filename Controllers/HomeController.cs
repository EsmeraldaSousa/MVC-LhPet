using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LhPet.Models;

namespace LhPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //Instância do tipo Cliente
        Cliente cliente1 = new Cliente(01, "Arthur A. Ferreira", "876.345.432-65", "arthurferreira@sp.senai.br", "Madruga" );
        Cliente cliente2 = new Cliente(02, "Willyam h. Gates", "345.432.234-55", "billbilll@sp.senai.br", "Bug" );
        Cliente cliente3 = new Cliente(03, "Grace Hopper", "432.764.986-87", "hoppergrace.senai.br", "Loboc" );

        //Lista de Clientes
        List<Cliente> ListaClientes = new List<Cliente>();
        ListaClientes.Add(cliente1);
        ListaClientes.Add(cliente2);
        ListaClientes.Add(cliente3);

        ViewBag.ListaClientes = ListaClientes;

        //Instância do tipo Fornecedor e atribui os fornecedores
        Fornecedor fornecedor1 = new Fornecedor(01,"C# Pet S/A", "14.182.102/0001-80", "c-sharp@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02,"Crtl Alt Dog", "15.182.689/0001-70", "ctrl@pet.org");
        Fornecedor fornecedor3 = new Fornecedor(03,"Bifinhi forever", "40.102.098/0001-88", "boots@pet.org");

        //Lista de Fornecedores
        List<Fornecedor> Listafornecedores = new List<Fornecedor>();
        Listafornecedores.Add(fornecedor1);
        Listafornecedores.Add(fornecedor2);
        Listafornecedores.Add(fornecedor3);

        ViewBag.Listafornecedores = Listafornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
