using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin.Clases
{
    public class Venta
    {
        // , , , , 
        private int _id;
        private DateTime _fechaVenta;
        private Cliente _cliente;
        private double _montoTotal;
        private int _userId;

        private List<DetalleVenta> _detalleVentas;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public DateTime FechaVenta
        {
            get { return _fechaVenta; }
            set { _fechaVenta = value; }
        }

        public Cliente Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }

        public double MontoTotal
        {
            get { return _montoTotal; }
            set { _montoTotal = value; }
        }

        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public List<DetalleVenta> DetalleVentas
        {
            get { return _detalleVentas; }
            set { _detalleVentas = value; }
        }

        public Venta()
        {
            _cliente= new Cliente();
            DetalleVentas= new List<DetalleVenta>();
        }
    }
}