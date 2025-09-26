using System.Collections.Generic;
using SISPEL.BLL.Contracts;
using SISPEL.DAL.Contracts;
using SISPEL.Domain;

namespace SISPEL.BLL;
public class ClienteService : IClienteService
{
    private readonly IClienteRepository _repo;
    public ClienteService(IClienteRepository repo) => _repo = repo;

    public IEnumerable<Cliente> Listar() => _repo.Listar();
    public Cliente? Obtener(long id) => _repo.ObtenerPorId(id);
    public void Crear(Cliente c) => _repo.Crear(c);
    public void Editar(Cliente c) => _repo.Actualizar(c);
    public void Borrar(long id) => _repo.Eliminar(id);
}
