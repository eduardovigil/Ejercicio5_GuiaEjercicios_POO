using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5_GuiaEjercicios_POO
{
    class Cliente
    {
        string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        string telefono;
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        string Direccion;
        public string direccion
        {
            get { return Direccion; }
            set { Direccion = value; }
        }
        string Correo;
        public string correo
        {
            get { return Correo; }
            set { Correo = value; }
        }
        int edad;
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        string Metodo;
        public string metodo
        {
            get { return Metodo; }
            set { Metodo = value; }
        }
    }
}
