# **Abstract Factory**

## 1. Introducción

El Abstract Factory es un patrón de diseño **creacional** que permite crear **familias de objetos relacionados** sin especificar sus clases concretas.  
A diferencia del **Factory Method**, que se enfoca en un solo tipo de objeto, el Abstract Factory puede producir múltiples tipos de productos que están diseñados para trabajar juntos.

Su objetivo principal es ofrecer una interfaz común para la creación de grupos de objetos que comparten un mismo contexto o tema, manteniendo la consistencia entre ellos.

---

## 2. Objetivo

> **Proporcionar una interfaz para crear familias de objetos relacionados o dependientes sin especificar sus clases concretas.**

De esta forma:
- Se asegura que los objetos creados sean **compatibles entre sí**.  
- Se favorece la **extensión** del sistema sin alterar el código existente.  
- Se respeta el principio **abierto/cerrado** del paradigma SOLID.

---

## 3. Problema que resuelve

Imaginemos que tenemos una **fábrica de vehículos** que debe crear distintos tipos de transporte, como **Autos** y **Motos**, pero cada tipo puede tener **versiones diferentes** (por ejemplo, Eléctrico y Gasolina).

Podríamos hacer algo así:

```csharp
if (tipo == "AutoGasolina")
    return new AutoGasolina();
else if (tipo == "AutoElectrico")
    return new AutoElectrico();
else if (tipo == "MotoGasolina")
    return new MotoGasolina();
```
---

Sin embargo, este enfoque tiene varios problemas:

- Cada vez que se agregue una nueva versión o tipo de vehículo, habrá que modificar el código.

- Se repiten condicionales y se pierde cohesión.

- Se viola el principio abierto/cerrado (OCP).

- Se mezclan responsabilidades de creación y uso.

---

## 4. Solución con Abstract Factory

Con el Abstract Factory, creamos una interfaz de fábrica abstracta que define los métodos para crear los productos relacionados (por ejemplo, autos y motos).
Luego, cada fábrica concreta implementa esos métodos para producir objetos específicos (eléctricos o de gasolina).

De esta manera:

- El código cliente no necesita conocer las clases concretas.

- Se garantiza la consistencia entre los productos creados por una misma fábrica.

- El sistema se puede extender fácilmente agregando nuevas fábricas.

## 5. Estructura del patrón

Abstract Factory:

- Declara métodos para crear cada tipo de producto.

- Ejemplo: `ICreatorVehiculos` con `CrearAuto()` y `CrearMoto()`.

Concrete Factories:

- Implementan los métodos de la fábrica abstracta para crear productos específicos.

- Ejemplo: `FabricaGasolina` y `FabricaElectrica`.

Abstract Product:

- Define la interfaz común para los productos.

- Ejemplo: `IAuto`, `IMoto`.

Concrete Product:

- Implementa las interfaces de producto con comportamientos concretos.

- Ejemplo: `AutoGasolina`, `MotoGasolina`, `AutoElectrico`, `MotoElectrica`.

Cliente:

- Usa la fábrica abstracta para crear los objetos sin conocer sus clases concretas.

## 6. Ventajas

- Garantiza la compatibilidad entre productos de una misma familia.

- Facilita el cambio de familias completas de productos sin modificar el código cliente.

- Promueve el desacoplamiento entre creación y uso.

- Permite cumplir con principios SOLID (OCP, SRP, DIP).

## 7. Desventajas

- Puede aumentar la complejidad del código y la cantidad de clases.

- Es más difícil agregar nuevos productos a las familias existentes.

- Puede ser innecesario para sistemas pequeños o simples.

## 8. Cuándo usarlo

Usa Abstract Factory cuando:

- Tu sistema debe trabajar con familias de productos relacionados.

- Quieres garantizar la compatibilidad entre los objetos creados.

- Deseas cambiar fácilmente de una familia de productos a otra (por ejemplo, pasar de Gasolina a Eléctrico).

- Buscas desacoplar la lógica de creación de la lógica de negocio.