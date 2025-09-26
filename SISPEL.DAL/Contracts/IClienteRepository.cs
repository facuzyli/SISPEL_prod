using System.Collections.Generic;
using SISPEL.Domain;

namespace SISPEL.DAL.Contracts;
public interface IClienteRepository
{
    IEnumerable<Cliente> Listar();
    Cliente? ObtenerPorId(long id);
    void Crear(Cliente c);
    void Actualizar(Cliente c);
    void Eliminar(long id);
}
