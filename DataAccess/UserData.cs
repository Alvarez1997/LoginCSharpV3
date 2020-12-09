using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaSoporte.Cache;

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
                        while (reader.Read()) //agregamos los valores de las colunmas a los campos de la clase statica (capa soporte / userLoginCache)
                        {
                            UserLoginCache.IdUser = reader.GetInt32(0); //posicion de la tabla base de datos 0 es Id usuario
                            UserLoginCache.FirstName = reader.GetString(3);
                            UserLoginCache.LastName = reader.GetString(4);
                            UserLoginCache.Position = reader.GetString(5);
                            UserLoginCache.Email = reader.GetString(6);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }

        //cualquier metodo que se necesite ya con la seguridad/privilegios del ususario, desde admin hasta usuario comun
        public void CualquierMetodo()
        {
            if (UserLoginCache.Position == CargosBD.Administrator)
            {
                //cualquier cosa que solo el admin pueda hacer
                //como modificar la base de datos
            }

            if (UserLoginCache.Position == CargosBD.Receptionist || UserLoginCache.Position == CargosBD.Accounting)
            {
                //limitaciones de ususarios standar
            }
        }

    }
}
