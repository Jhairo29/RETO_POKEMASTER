# RETO POKEMASTER
<img src="https://play-lh.googleusercontent.com/uGqP7F-E_eaEwTb3hMz63MWf0YKRSK6n9INBwibBSOrGDg6B3sd-ACuqNrR312ohdQ" height="40"/> <img src="https://maychusaigon.vn/wp-content/uploads/2023/07/dinh-nghia-asp-net-la-gi-maychusaigon.jpg" height="40"/><img src="https://i2.wp.com/www.dotnetforall.com/wp-content/uploads/2017/02/Web-API-CORS.png?fit=560%2C315&ssl=1" height="40"/><img src="https://www.itsitio.com/wp-content/uploads/2014/06/sqlserver_0.jpg" height="40"/><img src="https://i.morioh.com/2021/08/10/7a18d28a.webp" height="40"/><img src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSrPmNWAtnroI424NFmJBwNtUs6YIL_eVXHjA&usqp=CAU" height="40"/> <img src="https://pbs.twimg.com/media/F7xgJi7XgAAT6eA.jpg:large" height="40"/>

Solicitamos crear un proyecto backend de API REST que muestre información emulando la Pokedex. La información deberá ser almacenada en una base de datos.

### Requisitos
Antes de comenzar con el desarrollo de la API, asegúrate de tener instalado lo siguiente:
- SQL Server 2022 o superior: Asegúrate de tener SQL Server instalado y configurado en tu sistema. Este será utilizado como el sistema de gestión de base de datos para la API.
- Visual Studio con C#: Se requiere Visual Studio con el entorno de desarrollo de C# instalado. Además, asegúrate de haber descargado la plantilla de aplicación web ASP.NET (.NET Framework) en tu entorno de desarrollo para la creación de la API.
- Postman: Postman es una herramienta útil para probar y realizar solicitudes a la API. Asegúrate de tenerlo instalado para facilitar el proceso de prueba y desarrollo de la API.

Con estos requisitos instalados y configurados correctamente, estarás listo para comenzar con el desarrollo de la API y realizar pruebas utilizando Postman.
### Instrucciones para Clonar el Repositorio en Visual Studio
1. Abre Visual Studio.
2. Ve al menú superior y selecciona "Git" > "Clonar repositorio".
3. En la ventana que aparece, copia y pega la URL del repositorio:
```
https://github.com/Jhairo29/RETO_POKEMASTER.git
```
4. Selecciona la ubicación donde deseas clonar el repositorio en tu sistema.
5. Haz clic en "Clonar" para iniciar el proceso de clonación.
6. Espero que estas instrucciones te ayuden a clonar el repositorio en Visual Studio. Si necesitas más ayuda, no dudes en preguntar.

### Configuración de la Base de Datos
Este proyecto utiliza una base de datos SQL Server local. Es necesario configurar las variables de entorno para establecer la conexión adecuada con la base de datos.
- Crear base de datos y tabla ejecutando el script
```sql
CREATE DATABASE DBPRUEBAS
GO 
USE DBPRUEBAS
GO
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'POKEMON')
CREATE TABLE POKEMON (
    IdPokemon int PRIMARY KEY IDENTITY(1,1),
    Nombre varchar(60),
    Tipo varchar(60),
    Alimentacion varchar(60),
    Tamaño varchar(60),
    Peso varchar(60),
    Rareza varchar(60),
    DatoCurioso varchar(100),
    FechaRegistro datetime DEFAULT GETDATE()
)
GO
```
- Insertar los datos del pokemon ejecutando el script
```sql
USE [DBPRUEBAS]
GO
SET IDENTITY_INSERT [dbo].[POKEMON] ON 
-- Pikachu
INSERT [dbo].[POKEMON] ([IdPokemon], [Nombre], [Tipo], [Alimentacion], [Tamaño], [Peso], [Rareza], [DatoCurioso]) VALUES 
(1, N'Pikachu', N'Eléctrico', N'Omnívoro', N'Pequeño', N'6.0 kg', N'Común', N'Siempre tiene energía estática en su cuerpo.')
-- Bulbasaur
INSERT [dbo].[POKEMON] ([IdPokemon], [Nombre], [Tipo], [Alimentacion], [Tamaño], [Peso], [Rareza], [DatoCurioso]) VALUES 
(2, N'Bulbasaur', N'Planta/Veneno', N'Herbívoro', N'Pequeño', N'6.9 kg', N'Común', N'El bulbo en su espalda puede absorber nutrientes del sol.')
-- Charmander
INSERT [dbo].[POKEMON] ([IdPokemon], [Nombre], [Tipo], [Alimentacion], [Tamaño], [Peso], [Rareza], [DatoCurioso]) VALUES 
(3, N'Charmander', N'Fuego', N'Carnívoro', N'Pequeño', N'8.5 kg', N'Común', N'La llama en su cola indica su estado emocional.')
-- Squirtle
INSERT [dbo].[POKEMON] ([IdPokemon], [Nombre], [Tipo], [Alimentacion], [Tamaño], [Peso], [Rareza], [DatoCurioso]) VALUES 
(4, N'Squirtle', N'Agua', N'Carnívoro', N'Pequeño', N'9.0 kg', N'Común', N'Puede disparar agua a alta presión desde su boca.')
-- Jigglypuff
INSERT [dbo].[POKEMON] ([IdPokemon], [Nombre], [Tipo], [Alimentacion], [Tamaño], [Peso], [Rareza], [DatoCurioso]) VALUES 
(5, N'Jigglypuff', N'Normal/Hada', N'Herbívoro', N'Pequeño', N'5.5 kg', N'Común', N'Canta una canción de cuna que hace dormir a quien la escucha.')
-- Meowth
INSERT [dbo].[POKEMON] ([IdPokemon], [Nombre], [Tipo], [Alimentacion], [Tamaño], [Peso], [Rareza], [DatoCurioso]) VALUES 
(6, N'Meowth', N'Normal', N'Carnívoro', N'Pequeño', N'4.2 kg', N'Común', N'Le encantan las monedas brillantes.')
-- Psyduck
INSERT [dbo].[POKEMON] ([IdPokemon], [Nombre], [Tipo], [Alimentacion], [Tamaño], [Peso], [Rareza], [DatoCurioso]) VALUES 
(7, N'Psyduck', N'Agua', N'Omnívoro', N'Pequeño', N'19.6 kg', N'Común', N'Siempre tiene dolor de cabeza.')
-- Machop
INSERT [dbo].[POKEMON] ([IdPokemon], [Nombre], [Tipo], [Alimentacion], [Tamaño], [Peso], [Rareza], [DatoCurioso]) VALUES 
(8, N'Machop', N'Lucha', N'Carnívoro', N'Mediano', N'19.5 kg', N'Poco Común', N'Entrena levantando rocas.');
-- Abra
INSERT [dbo].[POKEMON] ([IdPokemon], [Nombre], [Tipo], [Alimentacion], [Tamaño], [Peso], [Rareza], [DatoCurioso]) VALUES 
(9, N'Abra', N'Psíquico', N'Carnívoro', N'Pequeño', N'19.5 kg', N'Poco Común', N'Puede leer la mente de otros.');
-- Gastly
INSERT [dbo].[POKEMON] ([IdPokemon], [Nombre], [Tipo], [Alimentacion], [Tamaño], [Peso], [Rareza], [DatoCurioso]) VALUES 
(10, N'Gastly', N'Fantasma/Veneno', N'Carnívoro', N'Pequeño', N'0.1 kg', N'Poco Común', N'Está compuesto por gases venenosos.');
-- Onix
INSERT [dbo].[POKEMON] ([IdPokemon], [Nombre], [Tipo], [Alimentacion], [Tamaño], [Peso], [Rareza], [DatoCurioso]) VALUES 
(11, N'Onix', N'Roca/Tierra', N'Herbívoro', N'Grande', N'210.0 kg', N'Poco Común', N'Vive en cuevas subterráneas.');
-- Drowzee
INSERT [dbo].[POKEMON] ([IdPokemon], [Nombre], [Tipo], [Alimentacion], [Tamaño], [Peso], [Rareza], [DatoCurioso]) VALUES 
(12, N'Drowzee', N'Psíquico', N'Omnívoro', N'Mediano', N'32.4 kg', N'Poco Común', N'Se alimenta de los sueños de las personas.');
-- Exeggcute
INSERT [dbo].[POKEMON] ([IdPokemon], [Nombre], [Tipo], [Alimentacion], [Tamaño], [Peso], [Rareza], [DatoCurioso]) VALUES 
(13, N'Exeggcute', N'Planta/Psíquico', N'Herbívoro', N'Pequeño', N'2.5 kg', N'Poco Común', N'Consiste en seis huevos de semillas.');
-- Koffing
INSERT [dbo].[POKEMON] ([IdPokemon], [Nombre], [Tipo], [Alimentacion], [Tamaño], [Peso], [Rareza], [DatoCurioso]) VALUES 
(14, N'Koffing', N'Veneno', N'Carnívoro', N'Pequeño', N'1.0 kg', N'Poco Común', N'Se infla para aumentar su tamaño.');
-- Cubone
INSERT [dbo].[POKEMON] ([IdPokemon], [Nombre], [Tipo], [Alimentacion], [Tamaño], [Peso], [Rareza], [DatoCurioso]) VALUES 
(15, N'Cubone', N'Tierra', N'Carnívoro', N'Pequeño', N'6.5 kg', N'Poco Común', N'Lleva una calavera de su madre fallecida.');
-- Snorlax
INSERT [dbo].[POKEMON] ([IdPokemon], [Nombre], [Tipo], [Alimentacion], [Tamaño], [Peso], [Rareza], [DatoCurioso]) VALUES 
(16, N'Snorlax', N'Normal', N'Herbívoro', N'Grande', N'460.0 kg', N'Raro', N'Puede dormir durante días seguidos.');
-- Jynx
INSERT [dbo].[POKEMON] ([IdPokemon], [Nombre], [Tipo], [Alimentacion], [Tamaño], [Peso], [Rareza], [DatoCurioso]) VALUES 
(17, N'Jynx', N'Hielo/Psíquico', N'Carnívoro', N'Mediano', N'40.6 kg', N'Raro', N'Su baile hipnotiza a sus oponentes.');
-- Lapras
INSERT [dbo].[POKEMON] ([IdPokemon], [Nombre], [Tipo], [Alimentacion], [Tamaño], [Peso], [Rareza], [DatoCurioso]) VALUES 
(18, N'Lapras', N'Agua/Hielo', N'Herbívoro', N'Grande', N'220.0 kg', N'Raro', N'Es conocido por su dulce canto.');
-- Dragonite
INSERT [dbo].[POKEMON] ([IdPokemon], [Nombre], [Tipo], [Alimentacion], [Tamaño], [Peso], [Rareza], [DatoCurioso]) VALUES 
(19, N'Dragonite', N'Dragón/Volador', N'Carnívoro', N'Grande', N'210.0 kg', N'Raro', N'Puede volar a grandes velocidades.');
-- Mewtwo
INSERT [dbo].[POKEMON] ([IdPokemon], [Nombre], [Tipo], [Alimentacion], [Tamaño], [Peso], [Rareza], [DatoCurioso]) VALUES 
(20, N'Mewtwo', N'Psíquico', N'Carnívoro', N'Mediano', N'122.0 kg', N'Legendario', N'Fue creado artificialmente en un laboratorio.');
-- Mew
INSERT [dbo].[POKEMON] ([IdPokemon], [Nombre], [Tipo], [Alimentacion], [Tamaño], [Peso], [Rareza], [DatoCurioso]) VALUES 
(21, N'Mew', N'Psíquico', N'Omnívoro', N'Pequeño', N'4.0 kg', N'Legendario', N'Contiene el ADN de todos los Pokémon.');
-- Zapdos
INSERT [dbo].[POKEMON] ([IdPokemon], [Nombre], [Tipo], [Alimentacion], [Tamaño], [Peso], [Rareza], [DatoCurioso]) VALUES 
(22, N'Zapdos', N'Eléctrico/Volador', N'Carnívoro', N'Grande', N'52.6 kg', N'Legendario', N'Su cuerpo genera electricidad estática.');
-- Moltres
INSERT [dbo].[POKEMON] ([IdPokemon], [Nombre], [Tipo], [Alimentacion], [Tamaño], [Peso], [Rareza], [DatoCurioso]) VALUES 
(23, N'Moltres', N'Fuego/Volador', N'Carnívoro', N'Grande', N'60.0 kg', N'Legendario', N'Tiene la habilidad de controlar el fuego.');
-- Articuno
INSERT [dbo].[POKEMON] ([IdPokemon], [Nombre], [Tipo], [Alimentacion], [Tamaño], [Peso], [Rareza], [DatoCurioso]) VALUES 
(24, N'Articuno', N'Hielo/Volador', N'Carnívoro', N'Grande', N'55.4 kg', N'Legendario', N'Puede congelar el aire a su alrededor.');
SET IDENTITY_INSERT [dbo].[POKEMON] OFF 
```
- Crear procedimiento ejecutando el script
```sql
USE DBPRUEBAS
GO
--************************ VALIDAMOS SI EXISTE EL PROCEDIMIENTO ************************--
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'usp_registrar')
DROP PROCEDURE usp_registrar
GO
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'usp_modificar')
DROP PROCEDURE usp_modificar
GO
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'usp_obtener')
DROP PROCEDURE usp_obtener
GO
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'usp_listar')
DROP PROCEDURE usp_listar
GO
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'usp_eliminar')
DROP PROCEDURE usp_eliminar
GO
--************************ PROCEDIMIENTOS PARA CREAR ************************--
CREATE PROCEDURE usp_registrar (
    @nombre varchar(60),
    @tipo varchar(60),
    @alimentacion varchar(60),
    @tamaño varchar(60),
    @peso varchar(60),
    @rareza varchar(60),
    @dato_curioso varchar(100)
)
AS
BEGIN
    INSERT INTO POKEMON (Nombre, Tipo, Alimentacion, Tamaño, Peso, Rareza, [DatoCurioso])
    VALUES (@nombre, @tipo, @alimentacion, @tamaño, @peso, @rareza, @dato_curioso)
END
GO
CREATE PROCEDURE usp_modificar (
    @idpokemon int,
    @nombre varchar(60),
    @tipo varchar(60),
    @alimentacion varchar(60),
    @tamaño varchar(60),
    @peso varchar(60),
    @rareza varchar(60),
    @dato_curioso varchar(100)
)
AS
BEGIN
    UPDATE POKEMON
    SET Nombre = @nombre,
        Tipo = @tipo,
        Alimentacion = @alimentacion,
        Tamaño = @tamaño,
        Peso = @peso,
        Rareza = @rareza,
        [DatoCurioso] = @dato_curioso
    WHERE IdPokemon = @idpokemon
END
GO
CREATE PROCEDURE usp_obtener (@idpokemon int)
AS
BEGIN
    SELECT * FROM POKEMON WHERE IdPokemon = @idpokemon
END
GO
CREATE PROCEDURE usp_listar
AS
BEGIN
    SELECT * FROM POKEMON
END
GO
CREATE PROCEDURE usp_eliminar (@idpokemon int)
AS
BEGIN
    DELETE FROM POKEMON WHERE IdPokemon = @idpokemon
END
GO
```
### Ejecución y despliegue
- Actualiza la clase Conexion para reflejar la configuración de tu base de datos SQL Server local.
- Descarga e instala el siguiente paquete para admitir la política de intercambio de recursos de origen cruzado (CORS) en la aplicación web API.
```
Microsoft.AspNet.WebApi.Cors
```
Una vez completadas estas acciones, el proyecto estaría listo para ejecutarse y estaría desplegado con éxito.
