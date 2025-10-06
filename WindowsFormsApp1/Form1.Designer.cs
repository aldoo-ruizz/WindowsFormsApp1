namespace WindowsFormsApp1
{
    partial class FormLoggin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbusuario = new System.Windows.Forms.TextBox();
            this.txbcontra = new System.Windows.Forms.TextBox();
            this.btningresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // txbusuario
            // 
            this.txbusuario.Location = new System.Drawing.Point(158, 51);
            this.txbusuario.Name = "txbusuario";
            this.txbusuario.Size = new System.Drawing.Size(100, 20);
            this.txbusuario.TabIndex = 2;
            // 
            // txbcontra
            // 
            this.txbcontra.Location = new System.Drawing.Point(158, 96);
            this.txbcontra.Name = "txbcontra";
            this.txbcontra.Size = new System.Drawing.Size(100, 20);
            this.txbcontra.TabIndex = 3;
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(110, 137);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(131, 23);
            this.btningresar.TabIndex = 4;
            this.btningresar.Text = "ingresar";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // FormLoggin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 321);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.txbcontra);
            this.Controls.Add(this.txbusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLoggin";
            this.Text = "Loggin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbusuario;
        private System.Windows.Forms.TextBox txbcontra;
        private System.Windows.Forms.Button btningresar;
    }
}

