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
using System.Collections;

namespace Proyecto_final
{
    public partial class agregar : Form
    {
        public agregar()
        {
            InitializeComponent();
        }

         private void button1_Click_1(object sender, EventArgs e)
        {

            datos Datos = new datos();

            Datos.Id = int.Parse(ID.Text);
            Datos.amaterno = ama.Text;
            Datos.apaterno = apa.Text;
            Datos.nombre = nom.Text;
            Datos.colonia = COL.Text;
            Datos.domicilio = TEL.Text;
            Datos.municipio = MUNI.Text;
            Datos.pais = PAIS.Text;
            Datos.estado = ESTADO.Text;
            Datos.copostal = CP.Text;
            Datos.mapa = MAPA.Text;
            Datos.observaciones = OB.Text;
            Datos.celular = CEL.Text;
            Datos.telefono = domi.Text;
            Datos.radio = RAD.Text;
            Datos.email = EMAIL.Text;
            

            int resultado = querys.Agregar(Datos);

            if (resultado > 0)
            {
                MessageBox.Show("Datos Guardados Corerectamente", "Datos Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

            else
            {
                MessageBox.Show("No se pudieron Guardar lo datos", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
           
           
    }

 }


