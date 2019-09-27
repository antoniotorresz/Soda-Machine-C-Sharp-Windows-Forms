using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendedora
{
    class Producto
    {
        private string nombre;
        private int cantidad;
        private string pathImagen;
        
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public int Cantidad
        {
            get => cantidad;
            set => cantidad = value;
        }

        public string PathImagen
        {
            get => pathImagen;
            set => pathImagen = value;
        }
    }
}
