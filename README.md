# StockFácil — Sistema de control de inventario

## Propósito

StockFácil es un sistema sencillo orientado al control de productos y ventas, organizado mediante diferentes componentes para separar las responsabilidades del proyecto.

## Módulos principales

- **Productos:** representa y gestiona la información de los productos.
- **Clientes:** representa la información de los clientes.
- **Ventas:** permite organizar la información relacionada con las ventas.
- **Controladores:** coordinan las solicitudes relacionadas con las operaciones del sistema.
- **Servicios:** contienen la lógica y reglas del negocio.
- **Acceso a datos:** permite gestionar el acceso a la información.
- **Vistas:** representan la interacción con el usuario.

## Estructura del proyecto

El proyecto está organizado en diferentes carpetas para separar responsabilidades:

- `Controllers/` — Contiene los controladores del sistema.
- `Models/` — Contiene las entidades `Cliente`, `Producto` y `Venta`.
- `Services/` — Contiene la lógica relacionada con las operaciones del sistema.
- `Data/` — Contiene el acceso a los datos mediante `VentaRepository`.
- `Views/` — Contiene las vistas del sistema.

Esta organización permite mantener el código separado por responsabilidades y facilita su mantenimiento y modificación.