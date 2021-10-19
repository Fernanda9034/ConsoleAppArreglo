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
        private string apellidos;
        private string carrera;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
 
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
        public Datos()
        {
            nombre = "";
            apellidos = "";
            carrera = "";
        }
        public Datos(string nombre, string apellidos, string carrera)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.carrera = carrera;
        }
        public override string ToString()
        {
            return nombre + " " + apellidos + " " + carrera + " ";
        }

    }
}
