using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrácticaErrores
{
    public class Médico
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Médico(string nombre)
        {
            if(nombre.Trim().Length < 1)
            {
                throw new Exception("El nombre no puede estar vacío");
            }
            else if(nombre.Trim().Length > 50)
            {
                throw new Exception("El nombre no puede ser mayor a 50 caracteres");
            }
            Nombre = nombre;

        }
        
    }
}
