
using Dapper;
using Microsoft.Data.SqlClient;
using TurnosPeluqueria_EJ06.Models;
namespace TurnosPeluqueria_EJ06.Models;

public static class BD
{
    private static string _connectionString =
        @"Server=localhost;DataBase=TurnosDB;Integrated Security=True;TrustServerCertificate=True;";

    public static List<Turno> ObtenerTurnos()
    {
        // TODO
        List<Turno> turno = new List<Turno>();
        using(SqlConnection connection = new SqlConnection(_connectionString))
        {
                string query = "SELECT * FROM Turnos";
                turno = connection.Query<Turno>(query).ToList();
        }
        return turno;
    }

    public static int AgregarTurno(Turno t)
    {
        int turno;
        using(SqlConnection connection = new SqlConnection(_connectionString))
        {
                string query = "INSERT INTO Turnos(NombreCliente, Servicio, FechaHora, Estado) VALUES (@NOMBRE, @SERVICIO,@fecha, @estado)";
                turno = connection.Execute(query, new{NOMBRE = t.NombreCliente, SERVICIO = t.Servicio, fecha = t.FechaHora, estado = t.Estado});
        }
        return turno;
        // TODO
    }


    
    public static int CambiarEstado(int id, string nuevoEstado)
    {
        // TODO
        int devolucion = 67;
        return devolucion;
    }

}
