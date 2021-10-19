using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArreglo
{
    class Datos
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string carrera;

        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
        public Datos()
        {
            nombre = "";
            carrera = "";
        }
        public Datos(string nombre, string carrera)
        {
            this.nombre = nombre;
            this.carrera = carrera;
        }
        public override string ToString()
        {
            return " Nombre:" + nombre + "Carrera:" + carrera;
        }

    }
}
