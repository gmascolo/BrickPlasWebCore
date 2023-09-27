using System.ComponentModel.DataAnnotations;

namespace BrickplasWebCore.Model
{
    public class Pedido
    {

        private int _IdPedido;
        private decimal _Cantidad;
        private decimal _Precio;
        private decimal _Subtotal;
        private Usuario _IdUsuario;
        private DateTime _Fecha;
        private DateTime _FechaEntrega;

        [Key]
        public int IdPedido
        {
            get { return _IdPedido; }
            set { _IdPedido = value; }
        }

        public decimal Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }

        public decimal Precio
        {
            get { return _Precio; }
            set { _Precio = value; }
        }

        public decimal Subtotal
        {
            get { return _Subtotal; }
            set { _Subtotal = value; }
        }

        public Usuario IdUsuario
        {
            get { return _IdUsuario; }
            set { _IdUsuario = value; }
        }

        public DateTime Fecha
        {
            get { return _Fecha; } 
            set { _Fecha = value; }
        }

        public DateTime FechaEntrega
        {
            get { return _FechaEntrega; }
            set { _FechaEntrega = value; }
        }
    }
}

