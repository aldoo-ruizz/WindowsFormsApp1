namespace WindowsFormsApp1
{
    partial class inicio
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
            this.dgdatos = new System.Windows.Forms.DataGridView();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbnombre = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnordenar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgdatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgdatos
            // 
            this.dgdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdatos.Location = new System.Drawing.Point(40, 181);
            this.dgdatos.Name = "dgdatos";
            this.dgdatos.Size = new System.Drawing.Size(177, 160);
            this.dgdatos.TabIndex = 0;
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(26, 140);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(75, 23);
            this.btnmostrar.TabIndex = 1;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // txbnombre
            // 
            this.txbnombre.Location = new System.Drawing.Point(84, 41);
            this.txbnombre.Name = "txbnombre";
            this.txbnombre.Size = new System.Drawing.Size(100, 20);
            this.txbnombre.TabIndex = 3;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(93, 67);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 4;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            // 
            // btnordenar
            // 
            this.btnordenar.Location = new System.Drawing.Point(142, 140);
            this.btnordenar.Name = "btnordenar";
            this.btnordenar.Size = new System.Drawing.Size(75, 23);
            this.btnordenar.TabIndex = 5;
            this.btnordenar.Text = "Ordenar";
            this.btnordenar.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(72, 347);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(124, 23);
            this.btnRegresar.TabIndex = 6;
            this.btnRegresar.Text = "Regresar a Loggin";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 382);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnordenar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txbnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.dgdatos);
            this.Name = "inicio";
            this.Text = "inicio";
            ((System.ComponentModel.ISupportInitialize)(this.dgdatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgdatos;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbnombre;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnordenar;
        private System.Windows.Forms.Button btnRegresar;
    }
}