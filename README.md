<h1 align="center"><img width="32" height="32" src="https://img.icons8.com/fluency/38/database--v1.png" alt="Safe Clothing"/><b>Formula Race - DbFirst</b></h1>

<p>Emplear el DbFirst de datos ya definidas, modificando la estructura de un proyecto de 3 capas y logrando una optima respuesta de migraciones habilitadas!</p>

## Tecnologias 🧑🏻‍💻
<p align="center">
<img src="https://user-images.githubusercontent.com/73097560/115834477-dbab4500-a447-11eb-908a-139a6edaec5c.gif"><br>

- **Back-End Development**: 
  ![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=flat&logo=c-sharp&logoColor=white) 
  ![.Net](https://img.shields.io/badge/.NET-5C2D91?style=flat&logo=.net&logoColor=white) 

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
🔰 Genere la entidad de TeamDriver que es generada como un diccionario en el contexto. ✔ <br>
🔰 Genere el archivo de configuracion de la entidad TeamDriver. ✔ <br>
🔰 Genere una nueva migracion. ✔ <br>
🔰 Genere repositorios y metodos crud. ❌ <br>

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