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
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;


namespace Proyecto_final
{
    public partial class Acciones : Form
    {
        public Acciones()
        {
            InitializeComponent();
        }


        MySqlConnection myConexion = new MySqlConnection("Server=127.0.0.1;" +
                "Database=directorio;" +
                "User ID= JUAN2;" +
                "Password=;" +
                "pooling=false;");


        private void agregar_Click(object sender, EventArgs e)
        {

       
            agregar veragregar = new agregar();
            veragregar.Show();


        }

        private void Editar_Click_1(object sender, EventArgs e)
        {
            Editar veredicion = new Editar();

            veredicion.Show();



        }

        private void btnExportar_Click(object sender, EventArgs e)
     

        {
            Microsoft.Office.Interop.Excel.Application aplicacionexcel;
            Excel._Workbook hojatrabajo;
            Excel._Worksheet pestañatrabajo;
            //Excel.Range columnarango

            aplicacionexcel = new Microsoft.Office.Interop.Excel.Application();

            object misValue = System.Reflection.Missing.Value;
            hojatrabajo = aplicacionexcel.Workbooks.Add(misValue);
            pestañatrabajo = (Excel._Worksheet)hojatrabajo.ActiveSheet;

            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                pestañatrabajo.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
            {
                for (int j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dataGridView1[j, i];
                    pestañatrabajo.Cells[i + 2, j + 1] = cell.Value;
                }
            }

            string carpeta = @"C:\Users\Juan Diego\Desktop\";
            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }

            string archivo = carpeta + "ContactosExportados.xls";
            try
            {
                hojatrabajo.SaveAs(archivo, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                System.Diagnostics.Process.Start(carpeta);
            }
            catch { }
            aplicacionexcel.Quit();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Esta seguro que desea eliminar contacto", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }

            MySqlCommand consulta = new MySqlCommand("Delete from contacto Where num=@num", myConexion);
            consulta.Parameters.AddWithValue("num", dataGridView1.CurrentRow.Cells["num"].Value);

            myConexion.Open();
            consulta.ExecuteNonQuery();
            myConexion.Close();

            MessageBox.Show("El contacto se ha eliminado correctamente");
        
        }

      

        private void ver_Click(object sender, EventArgs e)
        {

            MySqlCommand Comando = new MySqlCommand("select * from contacto", myConexion);
            myConexion.Open();

            MySqlDataReader leer = Comando.ExecuteReader();
            dataGridView1.Rows.Clear();
            int renglon = 0;
            while (leer.Read())
            {

                renglon = dataGridView1.Rows.Add();
                dataGridView1.Rows[renglon].Cells["num"].Value = leer.GetString(0);
                dataGridView1.Rows[renglon].Cells["ap"].Value = leer.GetString(1);
                dataGridView1.Rows[renglon].Cells["am"].Value = leer.GetString(2);
                dataGridView1.Rows[renglon].Cells["nombre"].Value = leer.GetString(3);
                dataGridView1.Rows[renglon].Cells["domicilio"].Value = leer.GetString(4);
                dataGridView1.Rows[renglon].Cells["colonia"].Value = leer.GetString(5);
                dataGridView1.Rows[renglon].Cells["cp"].Value = leer.GetString(6);
                dataGridView1.Rows[renglon].Cells["municipio"].Value = leer.GetString(7);
                dataGridView1.Rows[renglon].Cells["estado"].Value = leer.GetString(8);
                dataGridView1.Rows[renglon].Cells["pais"].Value = leer.GetString(9);
                dataGridView1.Rows[renglon].Cells["mapa"].Value = leer.GetString(10);
                dataGridView1.Rows[renglon].Cells["telefono"].Value = leer.GetString(11);
                dataGridView1.Rows[renglon].Cells["celular"].Value = leer.GetString(12);
                dataGridView1.Rows[renglon].Cells["radio"].Value = leer.GetString(13);
                dataGridView1.Rows[renglon].Cells["email"].Value = leer.GetString(14);
                dataGridView1.Rows[renglon].Cells["ob"].Value = leer.GetString(15);
            }

            myConexion.Close();
           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar vereditar = new Editar();
            vereditar.Show();
        }
       
   


        
        

        
    }
}
