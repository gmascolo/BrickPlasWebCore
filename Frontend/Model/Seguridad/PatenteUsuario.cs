
using System.ComponentModel.DataAnnotations;

namespace BrickplasWebCore.Model
{
    public class PatenteUsuario
    {

        [Key]
        public int idPatUsr { get; set; }
        public Boolean esPermisivo { get; set; }
        public Patente patente { get; set; }
        public Usuario usuario { get; set; }

        public PatenteUsuario()
        {

        }

        public override bool Equals(object obj)
        {
            var item = obj as PatenteUsuario;

            if (item == null)
            {
                return false;
            }

            if (item.esPermisivo && !this.esPermisivo)
            {
                return false;
            }

            return item.patente.idPatente == patente.idPatente;
        }

        public override int GetHashCode()
        {
            return patente.idPatente;
        }


    }
}
