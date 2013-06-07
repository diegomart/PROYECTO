using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Proyecto_final
{
    class querys
    {

        public static int Agregar(datos Dpersona)
        {
            int retorno = 0;
            using (MySqlConnection myConexion = conexion.abrirConexion() )
            {
                MySqlCommand Comando = new MySqlCommand(string.Format("INSERT INTO contacto "+
                    "(id, ap, am, nombre, domicilio,"+
                    " colonia,cp, municipio, estado, pais,"+
                    "mapa, telefono,celular, radio, email, observaciones)"+
                    " VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}')",
                    Dpersona.Id,Dpersona.apaterno,Dpersona.amaterno,Dpersona.nombre,Dpersona.domicilio,Dpersona.colonia,
                   Dpersona.copostal,Dpersona.municipio,Dpersona.estado,Dpersona.pais,Dpersona.mapa,
                   Dpersona.telefono,Dpersona.celular,Dpersona.radio,Dpersona.email,Dpersona.observaciones), myConexion);
            

                retorno = Comando.ExecuteNonQuery();
                myConexion.Close();

            }
            return retorno;
        }
      
    }
}




