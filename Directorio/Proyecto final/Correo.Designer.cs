namespace Proyecto_final
{
    partial class Correo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.enviar = new System.Windows.Forms.Button();
            this.adjuntar = new System.Windows.Forms.Button();
            this.ms = new System.Windows.Forms.TextBox();
            this.asunto = new System.Windows.Forms.TextBox();
            this.para = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.textcorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.limpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enviar
            // 
            this.enviar.Location = new System.Drawing.Point(384, 284);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(111, 42);
            this.enviar.TabIndex = 23;
            this.enviar.Text = "Enviar";
            this.enviar.UseVisualStyleBackColor = true;
            this.enviar.Click += new System.EventHandler(this.enviar_Click);
            // 
            // adjuntar
            // 
            this.adjuntar.Location = new System.Drawing.Point(264, 284);
            this.adjuntar.Name = "adjuntar";
            this.adjuntar.Size = new System.Drawing.Size(114, 42);
            this.adjuntar.TabIndex = 22;
            this.adjuntar.Text = "Adjuntar";
            this.adjuntar.UseVisualStyleBackColor = true;
            this.adjuntar.Click += new System.EventHandler(this.adjuntar_Click);
            // 
            // ms
            // 
            this.ms.Location = new System.Drawing.Point(116, 186);
            this.ms.Multiline = true;
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(379, 80);
            this.ms.TabIndex = 21;
            // 
            // asunto
            // 
            this.asunto.Location = new System.Drawing.Point(116, 145);
            this.asunto.Name = "asunto";
            this.asunto.Size = new System.Drawing.Size(198, 20);
            this.asunto.TabIndex = 20;
            // 
            // para
            // 
            this.para.Location = new System.Drawing.Point(116, 94);
            this.para.Name = "para";
            this.para.Size = new System.Drawing.Size(384, 20);
            this.para.TabIndex = 19;
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(116, 42);
            this.contraseña.Name = "contraseña";
            this.contraseña.PasswordChar = '*';
            this.contraseña.Size = new System.Drawing.Size(244, 20);
            this.contraseña.TabIndex = 18;
            // 
            // textcorreo
            // 
            this.textcorreo.Location = new System.Drawing.Point(116, 12);
            this.textcorreo.Name = "textcorreo";
            this.textcorreo.Size = new System.Drawing.Size(374, 20);
            this.textcorreo.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Mensaje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Asunto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Para:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "De:";
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(159, 284);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(99, 42);
            this.limpiar.TabIndex = 24;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // Correo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 338);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.enviar);
            this.Controls.Add(this.adjuntar);
            this.Controls.Add(this.ms);
            this.Controls.Add(this.asunto);
            this.Controls.Add(this.para);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.textcorreo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Correo";
            this.Text = "Correo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enviar;
        private System.Windows.Forms.Button adjuntar;
        private System.Windows.Forms.TextBox ms;
        private System.Windows.Forms.TextBox asunto;
        private System.Windows.Forms.TextBox para;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.TextBox textcorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button limpiar;
    }
}