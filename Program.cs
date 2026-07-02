Console.Title = "Agenda";

Agenda agenda = new();

int opcion;

do
{
    //Console.Clear();

    Console.WriteLine("==================================");
    Console.WriteLine("         AGENDA ELECTRÓNICA       ");
    Console.WriteLine("==================================");

    Console.WriteLine("Seleccione una opción:");
    Console.WriteLine("1. Agregar contacto");
    Console.WriteLine("2. Ver contactos");
    Console.WriteLine("3. Buscar contacto");
    Console.WriteLine("4. Editar contacto");
    Console.WriteLine("5. Eliminar contacto");
    Console.WriteLine("6. Guardar");
    Console.WriteLine("7. Cargar");
    Console.WriteLine("8. Salir");

    Console.Write("Opción: ");
    string opcionInput = Console.ReadLine() ?? string.Empty;
    opcion = int.TryParse(opcionInput, out int opcionParsed) ? opcionParsed : 0;

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingrese el nombre del contacto:");
            string nombre = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Ingrese el teléfono del contacto:");
            string telefono = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Ingrese el correo electrónico del contacto:");
            string correoElectronico = Console.ReadLine() ?? string.Empty;

            agenda.AgregarContacto(new Contacto
            {
                ID = agenda.VerContactos().Count + 1,
                Nombre = nombre,
                Telefono = telefono,
                CorreoElectronico = correoElectronico
            });
            break;
        default:
            Console.WriteLine("Opción no válida.");
            break;

        case 2:
            foreach (var contacto in agenda.VerContactos())
            {
                Console.WriteLine("==================================");
                Console.WriteLine($"ID: {contacto.ID}");
                Console.WriteLine($"Nombre: {contacto.Nombre}");
                Console.WriteLine($"Teléfono: {contacto.Telefono}");
                Console.WriteLine($"Correo electrónico: {contacto.CorreoElectronico}");
                Console.WriteLine();
            }
            
            Console.WriteLine("\nPresiona ENTER para continuar...");
            Console.ReadLine();
            break;

        case 3:
            Console.WriteLine("Ingrese el nombre del contacto a buscar:");
            string nombreBusqueda = Console.ReadLine() ?? string.Empty;

            var contactosEncontrados = agenda.VerContactos().Where(c => c.Nombre.Contains(nombreBusqueda)).ToList();

            if (contactosEncontrados.Count > 0)
            {
                foreach (var contacto in contactosEncontrados)
                {
                    Console.WriteLine("==================================");
                    Console.WriteLine($"ID: {contacto.ID}");
                    Console.WriteLine($"Nombre: {contacto.Nombre}");
                    Console.WriteLine($"Teléfono: {contacto.Telefono}");
                    Console.WriteLine($"Correo electrónico: {contacto.CorreoElectronico}");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No se encontraron contactos con ese nombre.");
            }

            Console.WriteLine("\nPresiona ENTER para continuar...");
            Console.ReadLine();
            break;
        
        case 8:
            Console.WriteLine("Saliendo del programa...");
            break;
    }
} while (opcion != 8);