# AppInmobiliaria
Aplicación que permite la administración y gestión de inmuebles.

## Configuración de la aplicación
- Inicializar la base de datos SQL con el query correspondiente: ```AppInmobiliaria/init.sql```
- Crear un container llamado **"estateimages"** en Azure Blob Storage
  - En caso de querer asignar otro nombre al contenedor, asegure especificar el mismo en la capa DataAccess:
  - ```public string container = "{nombre_contenedor}";```
- Abrir Visual Studio Community
- Clonar el repositorio: https://github.com/leorivass/AppInmobiliaria.git
- Ingresar los connection strings de la base de datos y del contenedor en App.config
- Ejecutar la aplicación


