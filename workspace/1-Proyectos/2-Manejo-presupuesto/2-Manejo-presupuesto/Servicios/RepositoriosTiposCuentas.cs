using _2_Manejo_presupuesto.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace _2_Manejo_presupuesto.Servicios
{
    public interface IRepositorioTiposCuentas
    {
        void Crear(TipoCuenta tipoCuenta);  
    }

    public class RepositorioTiposCuentas : IRepositorioTiposCuentas
    {
        private readonly string connectionString;

        public RepositorioTiposCuentas(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public void Crear(TipoCuenta tipoCuenta)
        {
            using var connection = new SqlConnection(connectionString);
            var id = connection.QuerySingle<int>($@"INSERT INTO TiposCuentas (Nombre, UsuarioId, Orden)
                     VALUES(@Nombre, @UsuarioId, 0);
                     SELECT SCOPE_IDENTITY()", tipoCuenta);
            tipoCuenta.Id = id;
        }
    }
}
