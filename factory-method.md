# Factory Method

## 1. Introducción

El Factory Method es un patrón de diseño **creacional** que permite crear objetos sin especificar su clase exacta.
Su idea principal es delegar la creación de objetos a las subclases o clases dedicadas a la creacion de objetos especificos.
En lugar de crear objetos directamente con `new`, el Factory Method define una interfaz para la creación y deja que las subclases decidan qué clase instanciar.

---

## 2. Objetivo

> **Definir una interfaz para crear un objeto, pero permitir que las subclases decidan qué clase concreta instanciar.**

De esta forma:
- El código principal no depende de las clases concretas.  
- Se facilita la **extensión del sistema** sin modificar el código existente.  
- Se aplica el **principio abierto/cerrado (Open/Closed Principle)** del paradigma SOLID.

---

## 3. Problema que resuelve

Imaginemos una **fábrica de vehículos** que debe crear distintos tipos (Auto, Moto, Camión).

Podríamos usar algo como esto:

```csharp
if (tipo == "Auto")
    return new Auto();
else if (tipo == "Moto")
    return new Moto();
```

---

Pero este enfoque es malo a largo plazo, porque:

- Cada vez que se agregue un nuevo tipo de vehículo hay que modificar el código existente.

- Se violan principios de diseño como abierto/cerrado.

- Los condicionales anidados (if-else, switch) son considerados antipatrones.

---

## 4. Solución con Factory Method

Con el Factory Method, en lugar de usar condicionales, creamos una clase abstracta o interfaz
que declara un método fábrica, y dejamos que las subclases implementen qué tipo de objeto crear.

Esto desacopla la lógica de creación del uso del objeto.

## 5. Estructura del patron

- tiene una clase abstracta `Creator` con el `FactoryMethod()`
- tiene un creador concreto `CarCreator` que implementa el `FactoryMethod()`
- tiene un `Product` que puede ser una interfaz o una clase con una `Operacion()`
- tiene una clase concreta `CarProduct`

## 6. Ventajas

- Promueve un código más limpio, escalable y mantenible.

- Permite agregar nuevos tipos de productos sin modificar el código existente.

- Cumple con los principios SOLID.

- Favorece el desacoplamiento entre clases.

## 7. Desventajas

- Puede aumentar la cantidad de clases en el proyecto.

- Su estructura es más compleja que una simple creación directa (new).

- No siempre es necesario para problemas pequeños.

## 8. Cuando usarlo

Usa el Factory Method cuando:

- No sabes qué tipo exacto de objeto se necesita.

- Quieres aislar la lógica de creación del resto del sistema.

- Necesitas una forma flexible y extensible de crear objetos.

Ejemplos comunes:

- Creación de conexiones (ConnectionFactory).

- Creación de interfaces gráficas (WindowsButton, MacButton).

- Creación de documentos o reportes.
