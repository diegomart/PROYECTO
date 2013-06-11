using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proyecto_final
{
    class conexion
    {


        public static MySqlConnection abrirConexion()
        {
            MySqlConnection myConexion = new MySqlConnection(
                "Server=127.0.0.1;"+
                "Database=directorio;"+
                "User ID= JUAN2;"+
                "Password=;"+
                "pooling=false;");
                
            myConexion.Open();

            return myConexion;

        }



        
    }
}

