using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess //Encapsulacion y Herencia de POO
{
    public abstract class ConnectionToSql //Abstracta, no puede ser instanciada, solo se puede usar como una clase base
    {
        private readonly string connectionString;
        public ConnectionToSql() //Constructor
        {
            connectionString = "Server=DESKTOP-IAAKTJQ;DataBase= MyCompany; integrated security= true";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString); //instancia de sqlconnection con parametro de la cadena de conexion
        }
    }
}

