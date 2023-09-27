

using System.ComponentModel.DataAnnotations;

namespace BrickplasWebCore.Model
{
    public class Familia
    {
        [Key]
        public int idFamilia { get; set; }
        public String nombre { get; set; }
        public List<Patente> patentesAsignadas { get; set; }
        public List<Usuario> usuariosAsignados { get; set; }

        public Familia()
        {
            patentesAsignadas = new List<Patente>();
            usuariosAsignados = new List<Usuario>();
        }


    }
}
