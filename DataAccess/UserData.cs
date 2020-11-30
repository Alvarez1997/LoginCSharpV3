using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class UserData : ConnectionToSql
    {
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection()) //variable implicita que es igual a la instancia del metodo sql de la conexion
            {
                connection.Open();
                //No hace falta cerrar la conexion por que al usar el bloque "Using" cuando termine de ejecutar
                //las filas dentro del bloque (el bloque using) va a desechar los recursos utilizados
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Users where LoginName=@user and Password=@pass"; //consulta parametrica
                    command.Parameters.AddWithValue("@user", user); //declaracion de los parametros con valor
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text; //especificar el tipo de comando
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                        return false;
                }
            }
        }
    }
}
