

using System.ComponentModel.DataAnnotations;

namespace BrickplasWebCore.Model
{
    public class DetalleVenta
    {
        private int _idDetalleVenta;
        private String _Domicilio;
        private decimal _FechaEntrega;
        private decimal _Subtotal;
        private Producto _idProducto;
        private Venta _idFactura;

        [Key]
        public int IdDetalleVenta
        {
            get
            {
                return _idDetalleVenta;
            }
            set
            {
                _idDetalleVenta = value;
            }
        }

        public Venta idFactura
        {
            get
            {
                return _idFactura;
            }
            set
            {
                _idFactura = value;
            }
        }

        public String Domicilio
        {
            get
            {
                return _Domicilio;
            }

            set
            {
                _Domicilio = value;
            }
        }

        public decimal FechaEntrega
        {
            get
            {
                return _FechaEntrega;
            }

            set
            {
                _FechaEntrega = value;
            }
        }

        public decimal Subtotal
        {
            get
            {
                return _Subtotal;
            }

            set
            {
                _Subtotal = value;
            }
        }

        public Producto IdProducto
        {
            get
            {
                return _idProducto;
            }

            set
            {
                _idProducto = value;
            }
        }
    }
}