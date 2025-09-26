using System.Collections.Generic;
using SISPEL.BLL;
using SISPEL.BLL.Contracts;
using SISPEL.DAL.Implementations;
using SISPEL.Domain;
using System.Configuration;

namespace SISPEL.Service.Facade;
public class SispelFacade
{
    private readonly IClienteService _clientes;

    public SispelFacade()
    {
        var cs = ConfigurationManager.ConnectionStrings["SISPEL"].ConnectionString;
        var repo = new ClienteRepository(cs);
        _clientes = new ClienteService(repo);
    }

    public IEnumerable<Cliente> ListarClientes() => _clientes.Listar();
    // + métodos para Turnos, Ventas, etc. a medida que avances
}
