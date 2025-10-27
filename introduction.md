# **Patrones de Diseño**

---

**Aprendiz:** Cristofer Lozano 

---

##  **¿Qué son los patrones de diseño?**

    Los patrones de diseño son como las formulas en las matematicas, no nos dan la respuesta al problema
    pero se pueden usar como molde para resolverlos, un patron de diseño es una solucion o modelo que nos
    ayuda a organizar de mejor manera nuestro codigo para hacerlo mas limpio y mas entendible, con esto, en lugar
    de inventar una solucion desde 0 utilizamos estos patrones o guias para enfrentar los problemas en el mundo
    del desarrollo

**Objetivos principales:**
    - Mejorar la forma en la que desarrollamos software, creando programas mas organizados y faciles de 
    mantener  
    - Hacer el codigo mas flexible para que se pueda adaptar o extender sin tener que escribir desde cero
    - Mejorar la comunicacion entre los desarrolladores ya que hay una manera de referirse a las soluciones
    - Ayudar a aplicar los principios SOLID siendo estos la base para escribir buen codigo

---

## **3. Clasificación de los patrones de diseño**

Los patrones se dividen en tres grandes categorías:

---

### 🔹 **A. Patrones Creacionales**
> Se centran en cómo **crear objetos** de manera flexible y desacoplada.

**Cuándo usarlos:**  
Cuando necesitas **controlar la forma en que se crean los objetos** para evitar dependencias directas o código repetitivo.

**Principales patrones:**
1. **Singleton** → Garantiza que solo exista una instancia de una clase.  
2. **Factory Method** → Delega la creación de objetos a las subclases.  
3. **Abstract Factory** → Crea familias de objetos relacionados sin especificar sus clases concretas.  
4. **Builder** → Separa la construcción compleja de un objeto de su representación final.  
5. **Prototype** → Crea nuevos objetos copiando instancias existentes.

---

### 🔹 **B. Patrones Estructurales**
> Se enfocan en cómo **organizar y relacionar clases y objetos** para formar estructuras más grandes y flexibles.

**Cuándo usarlos:**  
Cuando se busca **mejorar la composición de clases u objetos** o **reutilizar código** sin herencia.

**Principales patrones:**
1. **Adapter** → Permite que clases incompatibles trabajen juntas.  
2. **Bridge** → Separa una abstracción de su implementación.  
3. **Composite** → Permite tratar objetos individuales y compuestos de la misma manera.  
4. **Decorator** → Agrega funcionalidades a un objeto dinámicamente.  
5. **Facade** → Proporciona una interfaz simple para un sistema complejo.  
6. **Flyweight** → Reduce el uso de memoria compartiendo objetos similares.  
7. **Proxy** → Controla el acceso a un objeto mediante un intermediario.

---

### 🔹 **C. Patrones Comportamentales**
> Se centran en **la comunicación y cooperación entre objetos**.

**Cuándo usarlos:**  
Cuando necesitas **definir cómo los objetos interactúan entre sí** y cómo **se reparten las responsabilidades** dentro del sistema.

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

## 💡 **4. Beneficios de usar patrones de diseño**
- Promueven **código más limpio, mantenible y escalable**  
- Fomentan la **reutilización de soluciones probadas**  
- Mejoran la **legibilidad y comunicación** entre desarrolladores  
- Facilitan la **implementación de buenas prácticas** de diseño orientado a objetos  
- Permiten **extender funcionalidad** sin modificar código existente

---

## 🚧 **5. Cuándo no usarlos**
- Cuando el problema es **demasiado simple** y no requiere abstracción adicional.  
- Si el uso de un patrón **aumenta innecesariamente la complejidad** del código.  
- Cuando el patrón **no encaja naturalmente** con el problema que se intenta resolver.  

> ⚠️ Los patrones deben **resolver problemas**, no crearlos.

---

## 🧱 **6. Ejemplo general (sin código)**
> Supongamos que un sistema necesita crear diferentes tipos de usuarios (cliente, empleado, administrador).  
En lugar de llenar el código de condicionales, se podría aplicar un **patrón creacional** para delegar la creación de esos objetos de forma ordenada y extensible.

---

## 📘 **7. Conclusión**
- Los patrones de diseño son **guías prácticas** para resolver problemas comunes de arquitectura de software.  
- No son recetas fijas, sino **modelos flexibles** que pueden adaptarse a cada situación.  
- Su uso adecuado mejora la calidad del software y la colaboración en equipos de desarrollo.  
- Lo importante no es conocerlos todos, sino **saber cuándo aplicarlos**.

---

## 📚 **8. Referencias**
- *Design Patterns: Elements of Reusable Object-Oriented Software* — *Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides (GoF)*  
- *Head First Design Patterns* — *Eric Freeman y Elisabeth Robson*  
- *Refactoring Guru:* [https://refactoring.guru/design-patterns](https://refactoring.guru/design-patterns)  

---

> 🧭 *“El objetivo de los patrones no es hacer el código más complicado, sino más claro, estructurado y mantenible.”*
