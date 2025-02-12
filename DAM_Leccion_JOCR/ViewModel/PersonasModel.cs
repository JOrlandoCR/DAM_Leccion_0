using DAM_Leccion_JOCR.Model;

namespace DAM_Leccion_JOCR.ViewModel
{
    public class PersonasModel
    {
        public string Edad { get; internal set; }
        public string Apellido { get; internal set; }
        public string Nombre { get; internal set; }

        public static implicit operator personasModel(PersonaModel v)
        {
            throw new NotImplementedException();
        }
    }
}