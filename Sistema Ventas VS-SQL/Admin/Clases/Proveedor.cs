using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin.Clases
{
    public class Proveedor
    {
         private int _id;
        private string _nombre;
        private string _domicilio;
        private string _telefono;
        private string _email;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Domicilio
        {
            get { return _domicilio; }
            set { _domicilio = value; }
        }

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public Proveedor()
        {
        }

        public Proveedor(int id, string nombre, string domicilio, string telefono, string email)
        {
            _id = id;
            _nombre = nombre;
            _domicilio = domicilio;
            _telefono = telefono;
            _email = email;
        }
    }
}