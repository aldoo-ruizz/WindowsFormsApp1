using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
