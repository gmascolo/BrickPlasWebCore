
namespace BrickplasWebCore.Model
{
    public class EntidadDuplicadaExcepcion : Exception
    {

        public String atributo { get; set; }

        public EntidadDuplicadaExcepcion(String atributo)

        {
            this.atributo = atributo;
        }


    }
}
