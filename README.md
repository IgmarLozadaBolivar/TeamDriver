<h1 align="center"><img width="32" height="32" src="https://img.icons8.com/3d-fluency/38/jumper.png" alt="Safe Clothing"/><b>Safe Clothing</b></h1>

<p>La empresa safe clothing desea realizar un backend que le permita llevar el control, registro y seguimiento de la producción de prendas de seguridad industrial, la empresa cuenta con diferentes tipos de prendas entre las cuales están las prendas resistentes al fuego (Ignifugas), resistentes a altos voltajes (Arco eléctrico)!</p>

## Tecnologias 🧑🏻‍💻
<p align="center">
<img src="https://user-images.githubusercontent.com/73097560/115834477-dbab4500-a447-11eb-908a-139a6edaec5c.gif"><br>

- **Back-End Development**: 
  ![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=flat&logo=c-sharp&logoColor=white) 
  ![.Net](https://img.shields.io/badge/.NET-5C2D91?style=flat&logo=.net&logoColor=white) 

- **Frameworks, platforms & libraries**:
  ![JWT](https://img.shields.io/badge/JWT-black?style=flat&logo=JSON%20web%20tokens)

- **Softwares & Tools**: 
  ![Visual Studio Code](https://img.shields.io/badge/Visual%20Studio%20Code-0078d7.svg?style=flat&logo=visual-studio-code&logoColor=white) 
  ![Postman](https://img.shields.io/badge/Postman-FF6C37?style=flat&logo=postman&logoColor=white) 
  ![Swagger](https://img.shields.io/badge/-Swagger-%23Clojure?style=flat&logo=swagger&logoColor=white) 
  ![Insomnia](https://img.shields.io/badge/Insomnia-black?style=flat&logo=insomnia&logoColor=5849BE) 
  ![GIT](https://img.shields.io/badge/Git-fc6d26?style=flat&logo=git&logoColor=white)

- **Database**:
  ![MySQL](https://img.shields.io/badge/mysql-%2300f.svg?style=flat&logo=mysql&logoColor=white)

</p>

<img src="https://user-images.githubusercontent.com/73097560/115834477-dbab4500-a447-11eb-908a-139a6edaec5c.gif"><br>

## Requerimientos funcionales 👻<br>
🔰 Implementar restricción de peticiones haciendo uso de limitaciones de peticiones por IP. ✔ <br>
🔰 Implementar protección a los endPoints haciendo uso de JWT y roles de usuario. ✔ <br>
🔰 Implementar esquema de versionado de Api que facilite el proceso de implementación de nuevos endpoints sin afectar el funcionamiento de las aplicaciones externas que consumen los servicios del Api. ✔ <br>
🔰 Se debe permitir realizar procesos de creacion, edicion, eliminacion y listado de informacion de cada una de las tablas. ✔ <br>
🔰 Implementar endpoints que permitan realizar el proceso de CRUD en cada uno de los controladores del backend. ✔ <br>
🔰 Debido al gran volumen de información que la empresa procesa diariamente se requiere que los endpoints encargados de consultar el contenido de las tablas implementen sistema de paginación. ❌ <br>

## Realizar las siguientes consultas: 👨‍💻
<h4>Grupo A:</h4>
🔹 Listar los insumos que pertenecen a una prenda especifica. El usuario debe ingresar el código de la prenda. ❌ <br>
🔹 Listar los Insumos que son vendidos por un determinado proveedor cuyo tipo de persona sea Persona Jurídica. El usuario debe ingresar el Nit de proveedor. ❌ <br>
🔹 Listar todas las ordenes de producción cuyo estado se en proceso. ❌ <br>
🔹 Listar los empleados por un cargo especifico. Los cargos que se encuentran en la empresa son: Auxiliar de Bodega, Jefe de Producción, Corte, Jefe de bodega, Secretaria, Jefe de IT. ❌ <br>
🔹 Listar las ordenes de producción que pertenecen a un cliente especifico. El usuario debe ingresar el IdCliente y debe obtener la siguiente información: ❌<br>
🔸 IdCliente, Nombre, Municipio donde se encuentra ubicado. <br>
🔸 Nro de orden de producción, fecha y el estado de la orden de producción, se debe mostrar la descripción del estado, código del estado, valor total de la orden de producción. <br>
🔸 Detalle de orden: Nombre de la prenda, Código de la prenda, Cantidad, Valor total en pesos y en dólares. <br>
🔹 Listar las ventas realizadas por un empleado especifico. El usuario debe ingresar el Id del empleado y mostrar la siguiente información ❌ <br>
🔸 Id Empleado <br>
🔸 Nombre del empleado <br>
🔸 Fecturas : Nro Factura, fecha y total de la factura. <br>
🔹 Listar los productos y tallas del inventario. La consulta debe mostrar el id del inventario, nombre del producto, tallas y cantidad de cada talla. ❌ <br>

## Default user data
- ByBolivar - 123 (Rol = administrador) <br>
- Admin - admin (Rol = administrador) <br>
- Empleado - empleado (Rol = empleado)


## Steps to follow 👣
### 1. Generate token:

**Endpoint** `http://localhost:5021/User/token`

**Method**: `POST`

**Payload**: 
`{ "Nombre": "ByBolivar", "Contraseña": "123" }`

`{ "Nombre": "Admin", "Contraseña": "admin" }`

`{ "Nombre": "Empleado", "Contraseña": "empleado" }`

### 2. User registration ✍:
**Endpoint**: `http://localhost:5272/User/register`

**Method**: `POST`

**Payload**:
`{ "Usuario": "<YourUsername>", "Contraseña": "<YourPassword>", "CorreoElectronico": "<YourMail>" }`

<p>Esta EndPoint permite a los usuarios registrarse. Es necesario que para usuar los controladores como Empleado, Cliente u otro es necesario generar un token.</p>

### 3. Refresh Token 🔄:
**Endpoint**: `http://localhost:5272/User/refresh-token`

**Method**: `POST`

**Payload**:
`{ "Nombre": "<YourUsername>", "Contraseña": "<YourPassword>" }`

<p>Es necesario que el token generado lo valides por medio de la autenticacion de Bearer Token, para poder tener acceso.</p>

### 4. Other queries 🔄:
**Methods**: `GET`

**Obtener todos los usuarios**: `http://localhost:5272/User`

**Obtener usuario por ID**: `http://localhost:5272/User/{id}`

**Method**: `PUT`

**Actualizar usuario**: `http://localhost:5272/User/{id}`

**Method**: `DELETE`

**Eliminar usuario**: `http://localhost:5272/User/{id}`

## You can help me by Donating 💰
  [![PayPal](https://img.shields.io/badge/PayPal-00457C?style=flat&logo=paypal&logoColor=white)](https://paypal.me/losadabolivar@gmail.com) 

## Autores:
- <a href="https://github.com/IgmarLozadaBolivar">Powered by Igmar</a><br>