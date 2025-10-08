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

    public partial class inicio : Form
    {
        Acciones acciones = new Acciones();

        public inicio()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FormLoggin formloggin = new FormLoggin();
            this.Hide();
            formloggin.Show();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (acciones.Agregarnom(txbnombre.Text))
            {
                MessageBox.Show("Nombre agregado correctamente");
                txbnombre.Clear();
            }
            else
            {
                MessageBox.Show("Error al agregar nombre");
            }
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            dgvNombres.DataSource = null;
            var nombres = acciones.obtenernom();
            if (nombres.Count > 0)
            {
                dgvNombres.DataSource = nombres.Select(n => new { Nombre = n }).ToList();
            }
            else
            {
                MessageBox.Show("No hay nombres para mostrar");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (acciones.Eliminarnom(txbEliminarnom.Text))
            {
                MessageBox.Show("Nombre eliminado correctamente");

            }
            else
            {
                MessageBox.Show("Error al eliminar nombre");
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            // Puedes usar un SaveFileDialog para que el usuario elija la ruta
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivo Excel (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Exportar nombres a Excel";
                saveFileDialog.FileName = "Nombres.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    bool resultado = acciones.ExportarNombresAExcel(saveFileDialog.FileName);
                    if (resultado)
                    {
                        MessageBox.Show("Nombres exportados correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al exportar los nombres");
                    }
                }
            }
        }
    }
}
