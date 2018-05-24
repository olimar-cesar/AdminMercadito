using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin.Clases
{
    public class DetalleVenta
    {
        
        private int _id;
        private Producto _producto;
        private int _cantidadUnidades;
        private double _porcDescuento;
        private double _precioCosto;
        private double _precioVendido;
        private int _ventaId;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public Producto Producto
        {
            get { return _producto; }
            set { _producto = value; }
        }

        public int CantidadUnidades
        {
            get { return _cantidadUnidades; }
            set { _cantidadUnidades = value; }
        }

        public double PorcDescuento
        {
            get { return _porcDescuento; }
            set { _porcDescuento = value; }
        }

        public double PrecioCosto
        {
            get { return _precioCosto; }
            set { _precioCosto = value; }
        }

        public double PrecioVendido
        {
            get { return _precioVendido; }
            set { _precioVendido = value; }
        }

        public int VentaId
        {
            get { return _ventaId; }
            set { _ventaId = value; }
        }

        public DetalleVenta()
        {
            _producto=new Producto();
        }
    }
}