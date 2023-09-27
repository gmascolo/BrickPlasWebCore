

using System.ComponentModel.DataAnnotations;

namespace BrickplasWebCore.Model
{
    public class Venta
    {
        private string _idVenta;
        private string _fecha;
        private decimal _subtotal;
        private decimal _igv;
        private decimal _total;
        private string _cliente;

        [Key]
        public string idVenta
        {
            get
            {
                return _idVenta;
            }

            set
            {
                _idVenta = value;
            }
        }

        public string Fecha
        {
            get
            {
                return _fecha;
            }

            set
            {
                _fecha = value;
            }
        }

        public decimal Subtotal
        {
            get
            {
                return _subtotal;
            }

            set
            {
                _subtotal = value;
            }
        }

        public decimal Igv
        {
            get
            {
                return _igv;
            }

            set
            {
                _igv = value;
            }
        }

        public decimal Total
        {
            get
            {
                return _total;
            }

            set
            {
                _total = value;
            }
        }

        public string Cliente
        {
            get
            {
                return _cliente;
            }

            set
            {
                _cliente = value;
            }
        }

        public Venta()
        {
        }

        public Venta(string ccodigo)
        {
            _idVenta = ccodigo;
        }

        public Venta(string ccodigo, string cfecha, decimal csubtotal, decimal cigv, decimal ctotal, string ccliente)
        {
            _idVenta = ccodigo;
            _fecha = cfecha;
            _subtotal = csubtotal;
            _igv = cigv;
            _total = ctotal;
            _cliente = ccliente;
        }
    }
}
