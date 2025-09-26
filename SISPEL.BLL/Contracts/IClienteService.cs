using System.Collections.Generic;
using SISPEL.Domain;

namespace SISPEL.BLL.Contracts;
public interface IClienteService
{
    IEnumerable<Cliente> Listar();
    Cliente? Obtener(long id);
    void Crear(Cliente c);
    void Editar(Cliente c);
    void Borrar(long id);
}
