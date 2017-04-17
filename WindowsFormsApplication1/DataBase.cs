using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class DataBase
    {

        static string CadenaDeconexion = Properties.Settings.Default.Conexion;
        static SqlConnection conexion = new SqlConnection();

        public SqlConnection obtenerConexion()
        {
            conexion.ConnectionString = CadenaDeconexion;
            return conexion;

        }
    }
}
