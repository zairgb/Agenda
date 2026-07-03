using System.IO;
using System.Text.Json;
using Agenda;

Console.Title = "Agenda";

Agenda.Agenda agenda = new();
string archivoContactos = "contactos.json";

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
    bool esNumero = !string.IsNullOrEmpty(opcionInput);
    foreach (char c in opcionInput)
    {
        if (!char.IsDigit(c))
        {
            esNumero = false;
            break;
        }
    }
    if (esNumero && int.TryParse(opcionInput, out int opcionParsed))
    {
        opcion = opcionParsed;
    }
    else
    {
        opcion = 0;
        Console.WriteLine("Ingrese solo números.");
    }

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingrese el nombre del contacto:");
            string nombre = Console.ReadLine() ?? string.Empty;

            string telefono = string.Empty;
            bool telefonoValido = false;
            while (!telefonoValido)
            {
                Console.WriteLine("Ingrese el teléfono del contacto (solo números):");
                telefono = Console.ReadLine() ?? string.Empty;
                if (!string.IsNullOrEmpty(telefono))
                {
                    telefonoValido = true;
                    foreach (char c in telefono)
                    {
                        if (!char.IsDigit(c))
                        {
                            telefonoValido = false;
                            break;
                        }
                    }
                }
                if (!telefonoValido)
                {
                    Console.WriteLine("El teléfono debe contener únicamente números.");
                }
            }

            Console.WriteLine("Ingrese el correo electrónico del contacto:");
            string correoElectronico = string.Empty;
            bool correoValido = false;
            while (!correoValido)
            {
                correoElectronico = Console.ReadLine() ?? string.Empty;
                if (!string.IsNullOrEmpty(correoElectronico) && correoElectronico.Contains("@"))
                {
                    correoValido = true;
                }
                else
                {
                    Console.WriteLine("Ingrese un correo electrónico válido.");
                }
            }

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

        case 4:
            Console.WriteLine("Ingrese el ID del contacto a editar:");
            if (int.TryParse(Console.ReadLine(), out int idEditar))
            {
                var contacto = agenda.VerContactos().FirstOrDefault(c => c.ID == idEditar);
                if (contacto != null)
                {
                    Console.WriteLine("Ingrese el nuevo nombre (o presione ENTER para mantener el actual):");
                    string nuevoNombre = Console.ReadLine() ?? string.Empty;
                    if (!string.IsNullOrEmpty(nuevoNombre))
                    {
                        contacto.Nombre = nuevoNombre;
                    }

                    Console.WriteLine("Ingrese el nuevo teléfono (o presione ENTER para mantener el actual):");
                    string nuevoTelefono = Console.ReadLine() ?? string.Empty;
                    if (!string.IsNullOrEmpty(nuevoTelefono))
                    {
                        contacto.Telefono = nuevoTelefono;
                    }

                    Console.WriteLine("Ingrese el nuevo correo electrónico (o presione ENTER para mantener el actual):");
                    string nuevoCorreo = Console.ReadLine() ?? string.Empty;
                    if (!string.IsNullOrEmpty(nuevoCorreo))
                    {
                        contacto.CorreoElectronico = nuevoCorreo;
                    }

                    Console.WriteLine("Contacto editado correctamente.");
                }
                else
                {
                    Console.WriteLine("No se encontró un contacto con ese ID.");
                }
            }
            else
            {
                Console.WriteLine("ID inválido.");
            }

            Console.WriteLine("\nPresiona ENTER para continuar...");
            Console.ReadLine();
            break;

        case 5:
            Console.WriteLine("Ingrese el ID del contacto a eliminar:");
            if (int.TryParse(Console.ReadLine(), out int idEliminar))
            {
                var contacto = agenda.VerContactos().FirstOrDefault(c => c.ID == idEliminar);
                if (contacto != null)
                {
                    agenda.VerContactos().Remove(contacto);
                    Console.WriteLine("Contacto eliminado correctamente.");
                }
                else
                {
                    Console.WriteLine("No se encontró un contacto con ese ID.");
                }
            }
            else
            {
                Console.WriteLine("ID inválido.");
            }

            Console.WriteLine("\nPresiona ENTER para continuar...");
            Console.ReadLine();
            break;

        case 6:
            try
            {
                var contactos = agenda.VerContactos();
                var json = JsonSerializer.Serialize(contactos, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(archivoContactos, json);
                Console.WriteLine("Contactos guardados correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar: {ex.Message}");
            }

            Console.WriteLine("\nPresiona ENTER para continuar...");
            Console.ReadLine();
            break;

        case 7:
            try
            {
                if (File.Exists(archivoContactos))
                {
                    var json = File.ReadAllText(archivoContactos);
                    var contactos = JsonSerializer.Deserialize<List<Contacto>>(json) ?? new List<Contacto>();
                    // Reemplazar la agenda actual por los contactos cargados
                    agenda = new Agenda.Agenda();
                    foreach (var c in contactos)
                    {
                        agenda.AgregarContacto(c);
                    }
                    Console.WriteLine("Contactos cargados correctamente.");
                }
                else
                {
                    Console.WriteLine("No se encontró el archivo de contactos.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar: {ex.Message}");
            }

            Console.WriteLine("\nPresiona ENTER para continuar...");
            Console.ReadLine();
            break;
        
        case 8:
            Console.WriteLine("Saliendo del programa...");
            break;
    }
} while (opcion != 8);