

using System.ComponentModel.DataAnnotations;

namespace BrickplasWebCore.Model
{
    public class DetallePedido
    {
        private int _IdDetallePedido;
        private decimal _Cantidad;
        private decimal _Precio;
        private decimal _Subtotal;
        private Producto _idProducto;

        [Key]
        public int IdDetallePedido
        {
            get
            {
                return _IdDetallePedido;
            }
            set
            {
                _IdDetallePedido = value;
            }
        }

        public decimal Cantidad
        {
            get
            {
                return _Cantidad;
            }

            set
            {
                _Cantidad = value;
            }
        }

        public decimal Precio
        {
            get
            {
                return _Precio;
            }

            set
            {
                _Precio = value;
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
