namespace Proyecto_final
{
    partial class Directorio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Directorio));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.correo = new System.Windows.Forms.Button();
            this.acciones = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(409, 425);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // correo
            // 
            this.correo.Location = new System.Drawing.Point(427, 83);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(170, 95);
            this.correo.TabIndex = 7;
            this.correo.Text = "Correo";
            this.correo.UseVisualStyleBackColor = true;
            this.correo.Click += new System.EventHandler(this.correo_Click);
            // 
            // acciones
            // 
            this.acciones.Location = new System.Drawing.Point(427, 226);
            this.acciones.Name = "acciones";
            this.acciones.Size = new System.Drawing.Size(170, 115);
            this.acciones.TabIndex = 8;
            this.acciones.Text = "Acciones del directorio";
            this.acciones.UseVisualStyleBackColor = true;
            this.acciones.Click += new System.EventHandler(this.acciones_Click);
            // 
            // Directorio
            // 
            this.ClientSize = new System.Drawing.Size(609, 460);
            this.Controls.Add(this.acciones);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(320, 250);
            this.Name = "Directorio";
            this.Text = "Directorio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button correo;
        private System.Windows.Forms.Button acciones;
    }
}

