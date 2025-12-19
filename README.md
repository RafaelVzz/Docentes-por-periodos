# Sistema de Gestión Académica - WinForms 📊

Aplicación de escritorio desarrollada en C# bajo una arquitectura en capas, diseñada para la gestión, importación y exportación de datos académicos mediante archivos Excel y SQL Server.

## 📋 Requisitos del Sistema
* **Framework:** .NET Framework 4.8
* **Base de Datos:** SQL Server 2014 o superior.
* **Librerías:** ClosedXML (Instalada vía NuGet).

## 🗄️ Configuración de la Base de Datos
1. **Script:** Ejecuta el archivo `database_setup.sql` incluido en la raíz del repositorio para recrear la estructura de tablas necesaria.
2. **Arquitectura:** Soporta conexión local o remota (Cliente-Servidor). Las estaciones se conectan mediante la IP de la PC servidor.

## ⚙️ Configuración Dinámica (Config.ini)
El sistema utiliza un archivo de configuración externo gestionado por la clase `LectorIni` en la `CapaDatos` para desacoplar la infraestructura del código:
* **Plantilla:** Utiliza el archivo `Config.ini.example` como base.
* **Ubicación:** El archivo final `Config.ini` debe residir en la carpeta del ejecutable (`bin/Release` o carpeta de instalación).
* **Parámetros:** Permite configurar Servidor (IP), Base de Datos, Usuario y Clave sin recompilar la aplicación.

## 📄 Manejo de Excel (Reglas)
Para asegurar la integridad de la importación y el correcto funcionamiento de los filtros:
* Los archivos Excel deben mantener el número y nombre de encabezados institucional predefinido.
* La aplicación asume este formato fijo para procesar la información.

## 🚀 Instalación
1. Clonar el repositorio.
2. Restaurar paquetes NuGet en Visual Studio.
3. Crear el archivo `Config.ini` basándose en el ejemplo.
4. Compilar y ejecutar.