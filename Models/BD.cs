namespace TurnosPeluqueria_EJ06.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using TurnosPeluqueria_EJ06.Models;


public static class BD
{
    private static string _connectionString =
        @"Server=localhost;DataBase=TurnosDB;Integrated Security=True;TrustServerCertificate=True;";

    public static List<Turno> ObtenerTurnos()
    {
        // TODO
        List<Turno> turno = new List<Turno>();
        return turno;
    }

    public static int AgregarTurno(Turno t)
    {
        int devolucion = 67;
        return devolucion;
        // TODO
    }


    
    public static int CambiarEstado(int id, string nuevoEstado)
    {
        // TODO
        int devolucion = 67;
        return devolucion;
    }

}