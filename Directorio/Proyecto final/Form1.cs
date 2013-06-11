using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Collections;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace Proyecto_final
{
    public partial class Directorio : Form
    {
      
          public Directorio()
        {
            InitializeComponent();
        }


          private void correo_Click(object sender, EventArgs e)
          {
              Correo enviar = new Correo();
              enviar.Show();
          }

         


        
        private void acciones_Click(object sender, EventArgs e)
        {
            Acciones hacer = new Acciones();
                hacer.Show();
        }

      
     

        

        
    }
}
