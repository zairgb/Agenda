namespace Agenda
{
    public class Agenda
    {
        private readonly List<Contacto> Contactos = [];

        public void AgregarContacto(Contacto contacto)
        {
            Contactos.Add(contacto);
        }

        public List<Contacto> VerContactos()
        {
            return Contactos;
        }
    }
}