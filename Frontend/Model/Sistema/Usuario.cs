

using System.ComponentModel.DataAnnotations;

namespace BrickplasWebCore.Model
{
    public class Usuario
    {

        public String apellido { get; set; }
        public String contrasena { get; set; }
        public String email { get; set; }
        [Key]
        public int idUsuario { get; set; }
        public String nombre { get; set; }
        public String nombreUsuario { get; set; }
        //SDC nuevo parametro si esta habilitado
        public Boolean habilitado { get; set; }
        public int cantidadDeIntentos { get; set; }
        public List<PatenteUsuario> PatentesAsignadas { get; set; }
        public List<Familia> Familia { get; set; }

        public Usuario()
        {

        }

        public override bool Equals(object obj)
        {
            var item = obj as Usuario;

            if (item == null)
            {
                return false;
            }

            return item.idUsuario == idUsuario;
        }

        public override int GetHashCode()
        {
            return idUsuario;
        }


    }
}
