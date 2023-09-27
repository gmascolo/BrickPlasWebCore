

using System.ComponentModel.DataAnnotations;

namespace BrickplasWebCore.Model
{
    public class Categoria
    {
        
        private string _idCategoria;
        private string _Detalle;


        [Key]
        public string Idcategoria
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

        public string Detalle
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
    }
}
