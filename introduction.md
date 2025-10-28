## **Patrones de Diseño**

**Aprendiz:** Cristofer Lozano

---

##  **¿Qué son los patrones de diseño?**

Los patrones de diseño son como las formulas en las matematicas, no nos dan la respuesta al problema
pero se pueden usar como molde para resolverlos, un patron de diseño es una solucion o modelo que nos
ayuda a organizar de mejor manera nuestro codigo para hacerlo mas limpio y mas entendible, con esto, en lugar
de inventar una solucion desde 0 utilizamos estos patrones o guias para enfrentar los problemas en el mundo
del desarrollo

---

**Objetivos principales:**

- Mejorar la forma en la que desarrollamos software, creando programas mas organizados y faciles de
mantener
- Hacer el codigo mas flexible para que se pueda adaptar o extender sin tener que escribir desde cero
- Mejorar la comunicacion entre los desarrolladores ya que hay una manera de referirse a las soluciones
- Ayudar a aplicar los principios `SOLID` siendo estos la base para escribir buen codigo

---

## **3. Clasificación de los patrones de diseño**

> Los patrones se dividen en tres categorias, en la cual cada una tiene un proposito distinto

###  **A. Patrones Creacionales**
Se centran en cómo crear objetos de una forma controlada, flexible y asi no depender de mas clases (de manera directa)
esto ayuda a que no hayan `new` en todas partes, es decir la creacion de objetos sera mucho mas ordenada y facil de
modificar

**Cuándo usarlos:**
> Cuando queremos controlar la forma en la que se crean los objetos o evitar repetir código de construcción.

**Principales patrones:**
1. **Singleton** → Garantiza que solo exista una instancia de una clase.
2. **Factory Method** → Delega la creación de objetos a las subclases.
3. **Abstract Factory** → Crea familias de objetos relacionados sin especificar sus clases concretas.
4. **Builder** → Separa la construcción compleja de un objeto de su representación final.
5. **Prototype** → Crea nuevos objetos copiando instancias existentes.

---

### **B. Patrones Estructurales**
Estos patrones se centran en la organizacion y conexion entre clases u objetos para formar estructuras
más mucho mas grandes, mas reutilizables y mucho mas sencillas de mantener
se busca que las clases trabajen bien en conjunto sin depender tanto unas de otras

**Cuándo usarlos:**
>Cuando se necesita mejorar la organización del código, reutilizar clases existentes o agregar nuevas
>funciones sin cambiar el código original.

**Principales patrones:**
1. **Adapter** → Permite que clases incompatibles se adapten y trabajen juntas.
2. **Bridge** → Separa una abstracción de su implementación.
3. **Composite** → Permite tratar objetos individuales y compuestos de la misma manera.
4. **Decorator** → Agrega funcionalidades a un objeto dinámicamente.
5. **Facade** → Proporciona una interfaz simple para un sistema complejo.
6. **Flyweight** → Reduce el uso de memoria compartiendo objetos similares.
7. **Proxy** → Controla el acceso a un objeto mediante un intermediario.

---

### **C. Patrones Comportamentales**
Estos patrones se enfocan en cómo los objetos se comunican entre sí y cómo se reparten las responsabilidades dentro del sistema
estos sirven para manejar mejor el flujo de información y las decisiones que se toman en el programa.

**Cuándo usarlos:**
> Cuando necesitamos coordinar el comportamiento entre varios objetos o mantener el código ordenado al manejar acciones, eventos o estados.

**Principales patrones:**
1. **Chain of Responsibility** → Pasa peticiones a través de una cadena de manejadores.  
2. **Command** → Encapsula una acción en un objeto.  
3. **Interpreter** → Interpreta gramáticas o expresiones.  
4. **Iterator** → Permite recorrer una colección sin exponer su estructura interna.  
5. **Mediator** → Centraliza la comunicación entre objetos.  
6. **Memento** → Guarda y restaura el estado de un objeto.  
7. **Observer** → Notifica automáticamente a varios objetos sobre cambios en otro.  
8. **State** → Permite cambiar el comportamiento de un objeto según su estado.  
9. **Strategy** → Define una familia de algoritmos intercambiables.  
10. **Template Method** → Define el esqueleto de un algoritmo y permite modificar pasos específicos.  
11. **Visitor** → Separa un algoritmo de la estructura de objetos sobre la que opera.

---

## **4. Beneficios de usar patrones de diseño**

Usar patrones de diseño es como tener un mapa antes de construir un edificio:
no evita el trabajo, pero sí te guía para hacerlo de forma más segura, organizada y con menos errores.

- Promueven un código más limpio, mantenible y escalable, que crece sin volverse un caos.
- Fomentan la reutilización de soluciones probadas, evitando “reinventar la rueda”.
- Mejoran la legibilidad y comunicación entre desarrolladores, ya que todos entienden el mismo lenguaje de diseño.
- Facilitan la aplicación de buenas prácticas de programación orientada a objetos.
- Permiten extender o mejorar funcionalidades sin tener que modificar el código que ya funciona.

---

## **5. Cuándo no usarlos**

Aunque los patrones de diseño son muy útiles, no siempre son necesarios.
A veces, intentar usar uno puede ser como usar una grúa para mover una 
caja pequeña: terminas complicando más de lo que ayudas.

- Cuando el problema es demasiado simple y no requiere abstracción adicional.  
- Si el patrón añade más complejidad de la que resuelve.
- Cuando el patrón no encaja naturalmente con lo que estamos intentando solucionar.

Los patrones deben resolver problemas, no crearlos.
Si se usa un patrón solo “porque suena bien”, probablemente no sea la mejor opción.

---

## **6. Ejemplo general (sin código)**

imaginemos que tenemos una fabrica de vehiculos y tenemos que crear distintos tipos de vehiculos, se puede
hacer con if else, switch y demas entidades de control, pero el hecho de que se pueda hacer no significa
que sea lo que se deba hacer y esto (if else anidados) es un `antipatron`, es decir, malas practicas en la programacion

en cambio, si se usa un patron creacional, clases se encargaran de la creacion de estos objetos, es decir
clase `CreateCar` se encargara de crear carros y solamente de crearlos, lo mismo con las demas clases que tienen
su responsabilidad unica, haciendo el codigo mas escalable

---

## **7. Conclusión**
en conclusion, los patrones de diseño son guias que nos ayudan a resolver problemas en el desarrollo de software
no son "recetas exactas" sino moldes flexibles que se pueden usar en distintas situaciones y los cuales si se aplican
correctamente mejorarán la calidad del software, no se trata de aprenderselos todos, sino, saber como y cuando usarlos.

---

## **8. Referencias**
- *Design Patterns: Elements of Reusable Object-Oriented Software* — *Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides (GoF)*
- *Head First Design Patterns* — *Eric Freeman y Elisabeth Robson*
- *Refactoring Guru:* [https://refactoring.guru/design-patterns](https://refactoring.guru/design-patterns)