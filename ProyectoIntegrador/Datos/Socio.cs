using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoIntegrador.Datos
{
    public class Socio : Persona
    {
        private int nroSocio;


        public Socio(string nombre, string apellido, string genero, int edad, int dni, int nroSocio) : base(nombre, apellido, genero, edad, dni)
        {
            this.nroSocio = nroSocio;
        }

        public override string ToString() 
        {
            return base.ToString() + " Número de socio: " + nroSocio;
        }
    }
}
