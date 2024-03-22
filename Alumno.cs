using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace alumno
{
    internal class Alumno
    {
        #region Atributos
        private bool activo;
        private int añoIngreso;
        private string nombre; private string apellido;
        private string ciudad;
        private string domicilio;
        private string email;
        private int legajo;
        private string provincia;
        private string telefono;
        private static int ultimoLegajo = 0;
        #endregion
        #region Propiedades
        public bool Activo { get => activo; set => activo = value; }
        public int AñoIngreso { get => añoIngreso; set => añoIngreso = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string Email { get => email; set => email = value; }
        public int Legajo { get => legajo; set => legajo = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        #endregion

        #region Constructores
        public Alumno()
        {
            AñoIngreso = DateTime.Now.Year;
            ultimoLegajo++;
            Legajo = ultimoLegajo + 1;
        }
        public Alumno(string pNombre, string pApellido):this()
        {
            nombre = pNombre;
            apellido = pApellido;
            ciudad = "San Francisco";
            provincia = "Cordoba";
            activo = true;


        }
        public Alumno(
            string pNombre, 
            string pApellido, 
            bool pActivo, 
            string pCiudad, 
            string pDomicilio, 
            string pEmail, 
            string pProvincia, 
            string pTelefono):this()
        {
            nombre = pNombre;
            apellido = pApellido;
            activo = pActivo;
            ciudad = pCiudad;
            domicilio = pDomicilio;
            email = pEmail;
            provincia = pProvincia;
            telefono = pTelefono;

        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            string activoMostrar;
            if (activo) { activoMostrar = "Si"; } else { activoMostrar = "No"; }
            string cadena = "Activo: " + activoMostrar + 
                "\nAño ingreso: " + añoIngreso + 
                "\nApellido: " + apellido +
                "\nNombre: " + nombre +
                "\nCiudad: " + ciudad + 
                "\nDomicilio: " + domicilio + 
                "\nEmail: " + email + 
                "\nLegajo: " + legajo + 
                "\nProvincia: " + provincia + 
                "\nTelefono: " + telefono;
            return cadena;

        }
        #endregion

    }
}