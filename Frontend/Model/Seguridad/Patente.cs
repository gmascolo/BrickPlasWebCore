

using System.ComponentModel.DataAnnotations;

namespace BrickplasWebCore.Model
{
    public class Patente
    {
        [Key]
        public int idPatente { get; set; }
        public String nombre { get; set; }

        public Patente()
        {

        }

        public override bool Equals(object obj)
        {
            var item = obj as Patente;

            if (item == null)
            {
                return false;
            }

            return item.idPatente == idPatente;
        }

        public override int GetHashCode()
        {
            return idPatente;
        }


    }
}
