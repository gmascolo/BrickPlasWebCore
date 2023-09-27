

using System.ComponentModel.DataAnnotations;

namespace BrickplasWebCore.Model
{
    public class Bitacora
    {
        [Key]
        public int idBitacora {  get; set; }
        public int criticidad { get; set; }
        public string descripcion { get; set; }
        public DateTime fecha { get; set; }
        public string funcionalidad { get; set; }
        public Usuario IdUsuario { get; set; }
        public bool isAltaUsuario { get; set; }
        public Bitacora()
        {
        }


    }
}
