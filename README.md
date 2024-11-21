# Company Manager App

Este proyecto es una aplicación de escritorio para la gestión de empresas. Permite crear, editar y listar empresas en una base de datos SQL Server.

## Requisitos

- Visual Studio 2019 o superior.
- .NET Framework 4.8.
- SQL Server (local o remoto).
- Entity Framework 6.5.1.

## Instrucciones de reproducción

### 1. Clonar el repositorio

Para comenzar, clona este repositorio en tu máquina local:

```bash
git clone https://github.com/tu-usuario/CompanyManagerApp.git

### 2. Configurar la base de datos

Abre el archivo App.config en el proyecto.

Asegúrate de que la cadena de conexión sea correcta.

Ejemplo: <connectionStrings>
  <add name="AppDbContext" connectionString="Server=localhost\SQLEXPRESS;Database=CompanyManagerDb;Trusted_Connection=True;" providerName="System.Data.SqlClient" />
</connectionStrings>


Si aún no has creado la base de datos, puedes hacerlo ejecutando las migraciones de Entity Framework.

###3. Configurar el entorno de desarrollo
Abre el proyecto en Visual Studio.

Asegúrate de que la solución esté configurada para usar el framework .NET Framework 4.8.

Si no has instalado aún las dependencias, abre la consola del Administrador de paquetes NuGet e instala Entity Framework con el siguiente comando:

Install-Package EntityFramework
Aplica las migraciones para crear la base de datos:

Update-Database

Ejecutar la aplicación
Una vez que hayas configurado la base de datos y las dependencias, puedes ejecutar la aplicación
