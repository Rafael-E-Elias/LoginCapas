using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;


namespace Persistencia
{
    public abstract class Conexion
    {


        private readonly string connectionString = "";



        

        protected  OdbcConnection GetConnection()
        {
            return new OdbcConnection(connectionString);//new SqlConnection(connectionString);
        }
    }
}
