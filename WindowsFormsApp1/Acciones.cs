using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using System.IO;

namespace WindowsFormsApp1
{
    internal class Acciones
    {

        private List<string> Listanom = new List<string>();

        public List<string> obtenernom ()
        {
            return Listanom;
        }
        public bool Agregarnom(string nombre)
        {
            try
            {
                Listanom.Add(nombre);
                return true;
            }
            catch (Exception)
            {

                return false;
            }        
        }
        public bool Eliminarnom(string nombre)
        {
            try
            {
                if (Listanom.Contains(nombre))
                {
                    Listanom.Remove(nombre);
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception)
            {
                return false;
            }
        }

        // Método para exportar la lista a Excel usando ClosedXML
        public bool ExportarNombresAExcel(string rutaArchivo)
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Nombres");
                    worksheet.Cell(1, 1).Value = "Nombre";
                    for (int i = 0; i < Listanom.Count; i++)
                    {
                        worksheet.Cell(i + 2, 1).Value = Listanom[i];
                    }
                    workbook.SaveAs(rutaArchivo);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
