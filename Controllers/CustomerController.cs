using ClienteBanco.Entities;
using ClienteBanco.Entities.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClienteBanco.Controllers;
public class CustomerController : Controller
{
    private readonly ICSVService _csvService;
    public CustomerController(ICSVService CSVService)
    {
        _csvService = CSVService;
    }

    [HttpPost]
    [Route("/api/customers")]
    public async Task<ActionResult> InicializarCargaDeDatos([FromForm] IFormFileCollection file)
    {
        var customers = _csvService.ReadCSV<Customer>(file[0].OpenReadStream());

        return Ok(customers);
    }
}
