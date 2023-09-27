using NuGet.Versioning;
using System.ComponentModel.DataAnnotations;

namespace BrickplasWebCore.Model
{
    public class Producto
    {
        private int _idProducto;
        private String _Detalle;
        private Categoria _idCategoria;
        private float _Precio;
        private int _Cantidad;
        private String _Imagen;
        private int _Stock;
        private String _Tamaño;
        private float _Peso;


        public float Peso
        {
            get
            {
                return _Peso;
            }

            set
            {
                _Peso = value;
            }
        }
        public String Tamaño
        {
            get
            {
                return _Tamaño;
            }

            set
            {
               _Tamaño = value;
            }
        }

        public int Stock
        {
            get
            {
                return _Stock;
            }

            set
            {
                _Stock = value;
            }
        }

        [Key]
        public int IdProducto
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

        public String Detalle
        {
            get
            {
                return _Detalle;
            }

            set
            {
                _Detalle = value;
            }
        }

        public Categoria IdCategoria
        {
            get
            {
                return _idCategoria;
            }

            set
            {
                _idCategoria = value;
            }
        }

        public float Precio
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

        public int Cantidad
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

        public String Imagen
        {
            get
            {
                return _Imagen;
            }

            set
            {
                _Imagen = value;
            }
        }

        public Producto()
        {
        }

        public Producto(int ccodigo)
        {
            _idProducto = ccodigo;
        }

        public Producto(int ccodproducto, String cDetalle, Categoria ccodcategoria, float cPrecio, int cCantidad, String cImagen)
        {
            _idProducto = ccodproducto;
            _Detalle = cDetalle;
            _idCategoria = ccodcategoria;
            _Precio = cPrecio;
            _Cantidad = cCantidad;
            _Imagen = cImagen;
        }

    }
}
