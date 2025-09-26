using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using SISPEL.DAL.Contracts;
using SISPEL.Domain;

namespace SISPEL.DAL.Implementations;
public class ClienteRepository : IClienteRepository
{
    private readonly string _cs;
    public ClienteRepository(string connectionString) => _cs = connectionString;

    public IEnumerable<Cliente> Listar()
    {
        using var cn = new SqlConnection(_cs);
        using var cmd = new SqlCommand("SELECT Id,Nombre,Telefono,Email FROM Cliente", cn);
        cn.Open();
        using var rd = cmd.ExecuteReader();
        while (rd.Read())
        {
            yield return new Cliente
            {
                Id = rd.GetInt64(0),
                Nombre = rd.GetString(1),
                Telefono = rd.GetString(2),
                Email = rd.GetString(3)
            };
        }
    }

    public Cliente? ObtenerPorId(long id) { /* ...similar... */ return null; }
    public void Crear(Cliente c) { /* INSERT ... */ }
    public void Actualizar(Cliente c) { /* UPDATE ... */ }
    public void Eliminar(long id) { /* DELETE ... */ }
}
