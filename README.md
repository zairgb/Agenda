# 📒 Agenda Electrónica

![.NET](https://img.shields.io/badge/.NET-9.0-purple)
![C#](https://img.shields.io/badge/C%23-Language-blue)
![Estado](https://img.shields.io/badge/Estado-En%20desarrollo-orange)
![Licencia](https://img.shields.io/badge/Licencia-MIT-green)

Una aplicación de consola desarrollada en **C#** y **.NET** para administrar una agenda de contactos. Este proyecto forma parte de mi ruta de aprendizaje en el ecosistema .NET y tiene como objetivo reforzar los fundamentos del lenguaje mediante la implementación de un sistema CRUD.

---

# 📖 Descripción

La Agenda Electrónica permite gestionar una lista de contactos desde una aplicación de consola.

Actualmente es posible:

- ➕ Agregar contactos.
- 📋 Visualizar todos los contactos registrados.
- 🔍 Buscar contactos por nombre utilizando LINQ.

En futuras versiones se agregarán funcionalidades como edición, eliminación y persistencia de datos mediante archivos JSON.

---

# 🎯 Objetivos del proyecto

Este proyecto fue desarrollado para practicar los conceptos fundamentales de C# y .NET, entre ellos:

- Programación Orientada a Objetos.
- Organización del código en múltiples archivos.
- Colecciones (`List<T>`).
- LINQ.
- Métodos.
- Menús interactivos.
- Validación de datos.
- Buenas prácticas de programación.

---

# ✨ Funcionalidades

- ✅ Agregar contactos.
- ✅ Mostrar todos los contactos.
- ✅ Buscar contactos por nombre.
- 🚧 Editar contactos.
- 🚧 Eliminar contactos.
- ⏳ Guardar contactos en JSON.
- ⏳ Cargar contactos desde JSON.

---

# 🛠️ Tecnologías utilizadas

- C#
- .NET
- Programación Orientada a Objetos (POO)
- LINQ
- Colecciones (`List<T>`)
- System.Text.Json *(próximamente)*
- Manejo de archivos *(próximamente)*

---

# 📁 Estructura del proyecto

```text
Agenda/
│
├── Program.cs
├── Agenda.cs
├── Contacto.cs
├── README.md
└── contactos.json (próximamente)
```

---

# ▶️ Cómo ejecutar el proyecto

## Clonar el repositorio

```bash
git clone https://github.com/tu-usuario/Agenda.git
```

## Entrar al proyecto

```bash
cd Agenda
```

## Ejecutar

```bash
dotnet run
```

---

# 💻 Menú principal

```text
==================================
        AGENDA ELECTRÓNICA
==================================

1. Agregar contacto
2. Ver contactos
3. Buscar contacto
4. Editar contacto
5. Eliminar contacto
6. Guardar
7. Cargar
8. Salir
```

---

# 💻 Ejemplo de uso

```text
==================================
        AGENDA ELECTRÓNICA
==================================

Seleccione una opción:
1. Agregar contacto

Ingrese el nombre del contacto:
Jair

Ingrese el teléfono:
3312345678

Ingrese el correo electrónico:
jair@email.com
```

Resultado:

```text
Contacto agregado correctamente.
```

---

# 🧠 Conceptos aplicados

Durante el desarrollo de este proyecto se utilizan los siguientes conceptos:

- Variables
- Métodos
- Clases
- Objetos
- Encapsulamiento
- Programación Orientada a Objetos
- List<T>
- foreach
- switch
- while
- LINQ (`Where`)
- Validación mediante `TryParse`
- Manejo de cadenas
- Organización del código

---

# 📊 Estado del proyecto

| Funcionalidad | Estado |
|---------------|--------|
| Agregar contacto | ✅ |
| Mostrar contactos | ✅ |
| Buscar contacto | ✅ |
| Editar contacto | ✅ |
| Eliminar contacto | ✅ |
| Guardar en JSON | ✅ |
| Cargar desde JSON | ✅ |
| Validaciones | 🚧 |

**Leyenda**

- ✅ Completado
- 🚧 En desarrollo
- ⏳ Pendiente

---

# 📖 Lo aprendido

Con este proyecto reforcé conocimientos sobre:

- Creación de clases y objetos.
- Uso de listas genéricas (`List<T>`).
- Diseño de menús interactivos.
- Separación del código en diferentes archivos.
- Implementación de búsquedas mediante LINQ.
- Validación de datos ingresados por el usuario.
- Uso de estructuras de control (`switch`, `while`, `foreach`).

---

# 🚀 Próximas mejoras

- Implementar edición de contactos.
- Implementar eliminación de contactos.
- Guardar información en archivos JSON.
- Cargar automáticamente los contactos al iniciar la aplicación.
- Validar formato de correo electrónico.
- Validar longitud del número telefónico.
- Evitar contactos duplicados.
- Ordenar contactos alfabéticamente.
- Exportar la agenda a Excel.
- Exportar la agenda a PDF.
- Migrar el almacenamiento a SQLite.
- Implementar Entity Framework Core.
- Crear una API REST utilizando ASP.NET Core.

---

# 📸 Capturas

Puedes agregar imágenes cuando el proyecto esté terminado.

```text
images/
│
├── menu.png
├── agregar-contacto.png
├── lista-contactos.png
└── buscar-contacto.png
```

Y mostrarlas así:

```markdown
## Menú principal

![Menú](./images/menu.png)

## Lista de contactos

![Lista](./images/lista-contactos.png)

## Búsqueda

![Buscar](./images/busqueda.png)
```

---

# 🎓 Ruta de aprendizaje

Este proyecto forma parte de una serie de aplicaciones desarrolladas para aprender .NET.

| Proyecto | Estado |
|----------|--------|
| ✅ 01 - Calculadora | Finalizado |
| 🚧 02 - Agenda Electrónica | En desarrollo |
| ⏳ 03 - Sistema de Inventario | Pendiente |
| ⏳ 04 - Cajero Automático | Pendiente |
| ⏳ 05 - API REST | Pendiente |
| ⏳ 06 - Sistema de Ventas | Pendiente |

---

# 🤝 Contribuciones

Las sugerencias y mejoras son bienvenidas.

Si deseas contribuir:

1. Haz un **Fork** del proyecto.
2. Crea una nueva rama.
3. Realiza tus cambios.
4. Envía un **Pull Request**.

---

# 👨‍💻 Autor

**Jair**

Proyecto desarrollado como parte de mi aprendizaje de **C#**, **.NET** y desarrollo de aplicaciones de consola.

---

# ⭐ Apoya el proyecto

Si este proyecto te resultó útil o te ayudó a aprender, considera darle una ⭐ en GitHub.

¡Gracias por visitar este repositorio!# 📒 Agenda de Contactos

Una aplicación de consola desarrollada en **C#** y **.NET** para administrar una agenda de contactos. Este proyecto forma parte de una serie de ejercicios prácticos para aprender desarrollo con .NET.

## ✨ Características

- ➕ Agregar contactos.
- 📋 Mostrar todos los contactos.
- 🔍 Buscar contactos.
- ✏️ Editar información.
- ❌ Eliminar contactos.
- 💾 Guardar información en un archivo JSON.
- 📂 Cargar contactos al iniciar la aplicación.

## 🛠️ Tecnologías utilizadas

- C#
- .NET
- Programación Orientada a Objetos (POO)
- Colecciones (`List<T>`)
- Serialización JSON (`System.Text.Json`)
- Manejo de archivos

## 📁 Estructura del proyecto

```text
AgendaContactos/
│
├── Program.cs        # Punto de entrada de la aplicación
├── Contacto.cs       # Modelo de datos
├── Agenda.cs         # Lógica de negocio
├── contactos.json    # Archivo donde se almacenan los contactos
└── README.md
```

## ▶️ Cómo ejecutar el proyecto

### 1. Clonar el repositorio

```bash
git clone https://github.com/tu-usuario/AgendaContactos.git
```

### 2. Entrar al proyecto

```bash
cd AgendaContactos
```

### 3. Ejecutar la aplicación

```bash
dotnet run
```

## 📋 Menú principal

```text
==========================
     AGENDA DE CONTACTOS
==========================

1. Agregar contacto
2. Mostrar contactos
3. Buscar contacto
4. Editar contacto
5. Eliminar contacto
6. Guardar contactos
7. Cargar contactos
0. Salir
```

## 📚 Conceptos aprendidos

Durante el desarrollo de este proyecto se practican los siguientes temas:

- Variables y tipos de datos
- Métodos
- Clases y objetos
- Encapsulamiento
- Listas (`List<T>`)
- Bucles (`while`, `foreach`)
- Condicionales (`if`, `switch`)
- Serialización y deserialización JSON
- Manejo de archivos
- Organización del código en múltiples archivos

## 🚀 Mejoras futuras

- Validación de datos de entrada.
- Evitar contactos duplicados.
- Ordenar contactos alfabéticamente.
- Buscar por teléfono o correo.
- Exportar la agenda a Excel o PDF.
- Migrar el almacenamiento a SQLite o SQL Server.
- Crear una interfaz gráfica con Windows Forms o WPF.
- Desarrollar una API REST con ASP.NET Core.

## 👨‍💻 Autor

Desarrollado por **Jair** como parte de su aprendizaje en el ecosistema .NET.

---

⭐ Si este proyecto te resultó útil o interesante, considera darle una estrella al repositorio.
