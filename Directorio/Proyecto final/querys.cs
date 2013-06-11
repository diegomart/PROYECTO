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
                    "( ap, am, nombre, domicilio,"+
                    " colonia,cp, municipio, estado, pais,"+
                    "mapa, telefono,celular, radio, email, observaciones)"+
                    " VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}')",
                    Dpersona.apaterno,Dpersona.amaterno,Dpersona.nombre,Dpersona.domicilio,Dpersona.colonia,
                   Dpersona.copostal,Dpersona.municipio,Dpersona.estado,Dpersona.pais,Dpersona.mapa,
                   Dpersona.telefono,Dpersona.celular,Dpersona.radio,Dpersona.email,Dpersona.observaciones), myConexion);
            

                retorno = Comando.ExecuteNonQuery();
                myConexion.Close();

            }
            return retorno;
        }



      


        public static datos DARPERSONA(Int64 vId)
        {

            using (MySqlConnection nwconexion = conexion.abrirConexion())
            {

                datos ddirectorio = new datos();
                MySqlCommand comando = new MySqlCommand(string.Format(
                    "Select id, ap, am, nombre, domicilio, colonia, cp,"+
                    " municipio, estado, pais, mapa, telefono, celular,"+
                    " radio, email, observaciones from contacto where id = {0}", vId), nwconexion);

                MySqlDataReader leer = comando.ExecuteReader();

                leer.Read();

                ddirectorio.Id = leer.GetInt64(0);
                ddirectorio.apaterno = leer.GetString(1);
                ddirectorio.amaterno = leer.GetString(2);
                ddirectorio.nombre = leer.GetString(3);
                ddirectorio.domicilio = leer.GetString(4);
                ddirectorio.colonia = leer.GetString(5);
                ddirectorio.copostal = leer.GetString(6);
                ddirectorio.municipio = leer.GetString(7);
                ddirectorio.estado = leer.GetString(8);
                ddirectorio.pais = leer.GetString(9);
                ddirectorio.mapa = leer.GetString(10);
                ddirectorio.telefono = leer.GetString(11);
                ddirectorio.celular = leer.GetString(12);
                ddirectorio.radio = leer.GetString(13);
                ddirectorio.email = leer.GetString(14);
                ddirectorio.observaciones = leer.GetString(15);


                nwconexion.Close();
                return ddirectorio;

            }

        }




        public static int Modificar(datos Dpersona)
        {
            int retorno = 0;
            using (MySqlConnection nwconexion = conexion.abrirConexion())
            {
                MySqlCommand comando = new MySqlCommand(string.Format("Update contacto set ap='{0}', am='{1}', "+
                    "nombre='{2}', domicilio='{3}', colonia='{4}', cp='{5}',"+
                    " municipio='{6}', estado='{7}' , pais='{8}', mapa='{9}', telefono='{10}',"+
                    " celular='{11}', radio='{12}', email='{13}', observaciones='{14}'where id={15}",
                    Dpersona.apaterno, Dpersona.amaterno, Dpersona.nombre, Dpersona.domicilio, Dpersona.colonia,
                   Dpersona.copostal, Dpersona.municipio, Dpersona.estado, Dpersona.pais, Dpersona.mapa,
                   Dpersona.telefono, Dpersona.celular, Dpersona.radio, Dpersona.email, Dpersona.observaciones,Dpersona.Id), nwconexion);

                retorno = comando.ExecuteNonQuery();
                nwconexion.Close();
            }
            return retorno;

        }


        public static int Eliminar(Int64 pId)
        {
            int retorno = 0;
            using (MySqlConnection nwconexion = conexion.abrirConexion())
            {

                MySqlCommand comando = new MySqlCommand(string.Format("Delete from Alumnos where Id={0}", pId), nwconexion);
                retorno = comando.ExecuteNonQuery();
                nwconexion.Close();
            }
            return retorno;

        }








    }
}



