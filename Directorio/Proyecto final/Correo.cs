using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;//
using System.Net;

namespace Proyecto_final
{
    public partial class Correo : Form
    {
        public Correo()
        {
            InitializeComponent();
        }
        private bool Adj = false;
        private string Archivo;

        private void adjuntar_Click(object sender, EventArgs e)
        {

            Adj = true;
            OpenFileDialog _file = new OpenFileDialog();
            _file.Title = "Seleccione Archivo";
            _file.InitialDirectory = @"c:@\";
            _file.Filter = "All Files (*.*)|*.*";
            _file.FilterIndex = 1;
            _file.RestoreDirectory = true;
            _file.ShowDialog();
            Archivo = _file.FileName;
        }

        private void enviar_Click(object sender, EventArgs e)
        {
            /*Lo segundo que hay que hacer es darle el correo de donde
            se enviara el mensaje ósea el de Gmail que es el que ocupare.*/

            MailMessage _Correo = new MailMessage();
            _Correo.From = new MailAddress(para.Text);

            //Ahora hay que decirle a que coreo tendrá que enviarle el correo que estoy creando.
            _Correo.To.Add(para.Text);
            _Correo.Subject = asunto.Text;
            _Correo.Body = ms.Text;
            _Correo.IsBodyHtml = false;
            _Correo.Priority = MailPriority.Normal;

            if (Adj == true)
            {
                Attachment _attachment = new Attachment(@Archivo);
                _Correo.Attachments.Add(_attachment);
                Adj = false;
            }

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential(textcorreo.Text, contraseña.Text);

            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;

            try
            {
                smtp.Send(_Correo);
                MessageBox.Show("Su correo ha sido enviado exitosa mente");
            }
            catch
            {
                MessageBox.Show("Error no se pudo enviar su correo");
            }
            _Correo.Dispose();
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            this.textcorreo.Text = "";
            this.para.Text = "";
            this.asunto.Text = "";
            this.contraseña.Text = "";

        }

        
    }
}
