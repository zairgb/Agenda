public class Agenda
{
    private List<Contacto> Contactos = new();

    public void AgregarContacto(Contacto contacto)
    {
        Contactos.Add(contacto);
    }

    public List<Contacto> VerContactos()
    {
        return Contactos;
    }
}