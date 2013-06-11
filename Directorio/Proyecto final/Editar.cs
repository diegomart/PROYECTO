using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyecto_final
{
    public partial class Editar : Form
    {
        public Editar()
        {
            InitializeComponent();
        }

        MySqlConnection myConexion = new MySqlConnection("Server=127.0.0.1;" +
                "Database=directorio;" +
                "User ID= JUAN2;" +
                "Password=;" +
                "pooling=false;");
        public string selecciondirectorio;


        private void Editar_Click(object sender, EventArgs e)
        {

            MySqlCommand Comando = new MySqlCommand("update prueba set ap=@ap, am=@am, nombre=@nom, domicilio=@dom, colonia=@col, cp=@cp, municipio=@mun, estado=@est, pais=@pai, mapa=@map, telefono=@tel, celular=@cel, radio=@rad, email=@ema, ob=@ob where num=@num", myConexion);
            Comando.Parameters.AddWithValue("num", selecciondirectorio);
            Comando.Parameters.AddWithValue("ap", apa.Text);
            Comando.Parameters.AddWithValue("am", ama.Text);
            Comando.Parameters.AddWithValue("nom",nom.Text);
            Comando.Parameters.AddWithValue("dom", domi.Text);
            Comando.Parameters.AddWithValue("col", COL.Text);
            Comando.Parameters.AddWithValue("cp", CP.Text);
            Comando.Parameters.AddWithValue("mun", MUNI.Text);
            Comando.Parameters.AddWithValue("est", ESTADO.Text);
            Comando.Parameters.AddWithValue("pai", PAIS.Text);
            Comando.Parameters.AddWithValue("map", MAPA.Text);
            Comando.Parameters.AddWithValue("tel", TEL.Text);
            Comando.Parameters.AddWithValue("cel", CEL.Text);
            Comando.Parameters.AddWithValue("rad", RAD.Text);
        
            Comando.Parameters.AddWithValue("ob", OB.Text);

            myConexion.Open();
           
            int resultado = Comando.ExecuteNonQuery();
            myConexion.Close();

            if (resultado > 0)
            {
                MessageBox.Show("Datos Guardados Correctamente", "Datos Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                MessageBox.Show("No se pudieron Guardar lo datos", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        
        
        
        
       
        private void button1_Click(object sender, EventArgs e)
        {

        
            MySqlCommand Comando = new MySqlCommand("select * from contacto where num=" + selecciondirectorio, myConexion);
            myConexion.Open();

            MySqlDataReader leer = Comando.ExecuteReader();

            if (leer.Read())
            {

                ID.Text = leer.GetString(0);
                apa.Text = leer.GetString(1);
                ama.Text = leer.GetString(2);
                nom.Text = leer.GetString(3);
                domi.Text = leer.GetString(4);
                COL.Text = leer.GetString(5);
                CP.Text = leer.GetString(6);
               MUNI.Text = leer.GetString(7);
               ESTADO.Text = leer.GetString(8);
                PAIS.Text = leer.GetString(9);
               MAPA.Text = leer.GetString(10);
                TEL.Text = leer.GetString(11);
                CEL.Text = leer.GetString(12);
                RAD.Text = leer.GetString(13);
               EMAIL.Text = leer.GetString(14);
                OB.Text = leer.GetString(15);
            }

            myConexion.Close();
            
        }






    }
}
