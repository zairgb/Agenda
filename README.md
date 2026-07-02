# 📒 Agenda de Contactos

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
