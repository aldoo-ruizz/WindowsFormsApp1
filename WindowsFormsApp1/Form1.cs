using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormLoggin : Form
    {
        public FormLoggin()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            string usuario = txbusuario.Text;
            string contraseña = txbcontra.Text; 
            //trim quita los espacios en blanco
            //to lower convierte a minusculas
            if (usuario.Trim().ToLower() == "aldo" && contraseña.Trim().ToLower() == "123")
            {
                inicio ventana = new inicio();
                ventana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de acceso");
                txbcontra.Clear();
                txbusuario.Focus();
            }
                
        }
    }
}
