using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin.Clases
{
    public class Compra
    {
        private int _id;
        private string _descripcion;
        private DateTime _fechaCompra;
        private double _monto;
        private string _numeroTicket;
        private Proveedor _proveedor;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public DateTime FechaCompra
        {
            get { return _fechaCompra; }
            set { _fechaCompra = value; }
        }

        public double Monto
        {
            get { return _monto; }
            set { _monto = value; }
        }

        public string NumeroTicket
        {
            get { return _numeroTicket; }
            set { _numeroTicket = value; }
        }

        public Proveedor Proveedor
        {
            get { return _proveedor; }
            set { _proveedor = value; }
        }

        public Compra()
        {
            Proveedor= new Proveedor();
        }

        public Compra(int id, string descripcion, DateTime fechaCompra, Proveedor proveedor, string numeroTicket,double monto)
        {
            _id = id;
            _descripcion = descripcion;
            _fechaCompra = fechaCompra;
            _proveedor = proveedor;
            _numeroTicket = numeroTicket;
            _monto = monto;
        }
    }
}