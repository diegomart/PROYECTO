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
                "Data source=localhost;"+
                "Initial Catalog=directorio;"+
                "User Id=PORTERYYTHO;"+
                "Password=1993");
                
            myConexion.Open();

            return myConexion;

        }

     
    }
}

