using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace Persistencia
{
    public class UserDao : Conexion
    {
        public bool Login (string user, string pass)
        {
            using (var Connection = GetConnection())
            {
                Connection.Open();
                using (OdbcCommand command = new OdbcCommand())
                {
                    command.Connection = Connection;
                    command.CommandText = "select * from [PruebaRafael].[dbo].[Usuarios] where LoginName =@user and Password =@pass ";
                    command.Parameters.AddWithValue("@user",user);
                    command.Parameters.AddWithValue("@pass",pass);
                    command.CommandType = CommandType.Text;
                    OdbcDataReader read = command.ExecuteReader();
                    if (read.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
