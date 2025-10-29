# **Singleton**

## 1. Introducción

El Singleton es un patrón de diseño **creacional** que garantiza que **solo exista una única instancia** de una clase en todo el sistema y proporciona un **punto global de acceso** a esa instancia.  

Este patrón es útil cuando se necesita **controlar el acceso a un recurso compartido**, como una conexión a base de datos, un registro de logs o un manejador de configuración.  

A diferencia de otros patrones creacionales, el Singleton **restringe la instanciación** de su clase y asegura que todos los clientes usen el mismo objeto.

---

## 2. Objetivo

> **Garantizar que una clase tenga una única instancia y proporcionar un punto global de acceso a ella.**

De esta forma:
- Se evita la creación múltiple de objetos que deben ser únicos.  
- Se permite acceder fácilmente a la instancia compartida desde cualquier parte del programa.  
- Se asegura la **consistencia de estado** dentro de la aplicación.

---

## 3. Problema que resuelve

Imaginemos una fábrica de vehículos que necesita llevar un registro global de todos los autos y motos producidos.  

Si cada clase (por ejemplo, `Car` o `MotorCicle`) mantiene su propio contador, los datos estarán desincronizados.  

Podríamos intentar crear un registro así:

```csharp
public class ProductionRegister
{
    public int totalVehicles = 0;
}
```

Y luego usarlo en distintas partes del código, pero si cada clase crea su propio `new ProductionRegister()`, se perdería la consistencia del conteo.

---

De esta manera, el problema principal es:

- Existen **múltiples instancias** del mismo registro.  
- No se puede mantener un **control centralizado**.  
- Se produce **incoherencia de datos** entre las clases.

---

## 4. Solución con Singleton

Con el patrón **Singleton**, se crea una clase que **controla su propia instancia** y expone un método estático (`GetInstance()`) que devuelve siempre **la misma instancia única**.

Esto garantiza que:

- Solo exista un **único registro de producción**.  
- Todas las clases trabajen con el **mismo objeto compartido**.  
- El acceso sea **controlado y seguro**.

---

## 5. Estructura del patrón

### **Singleton:**

- Declara un **campo estático privado** que almacena la instancia única.  
- Tiene un **constructor privado** para evitar la creación directa con `new`.  
- Proporciona un **método público o estático** (`GetInstance()`) para obtener la instancia.  
- Contiene la **lógica del recurso compartido**.

### **Cliente:**

- Llama a `GetInstance()` en lugar de `new` para usar la misma instancia.

---

## 6. Ventajas

- Garantiza que exista una **única instancia** en todo el sistema.  
- Proporciona un **punto de acceso global controlado**.  
- **Ahorra recursos** al evitar múltiples creaciones innecesarias.  
- Es fácil de integrar con otros patrones como **Factory Method** o **Abstract Factory**.

---

## 7. Desventajas

- Puede **dificultar las pruebas unitarias** (ya que mantiene estado global).  
- Puede generar **acoplamiento** si se abusa del acceso global.  
- No es adecuado para **entornos altamente concurrentes** sin manejo de sincronización.  
- Si no se maneja correctamente, puede provocar **problemas de rendimiento o estado compartido**.

---

## 8. Cuándo usarlo

Usa **Singleton** cuando:

- Debes asegurar una **única instancia** de una clase en toda la aplicación.  
- Quieres un **punto global de acceso** (por ejemplo, registro de logs o configuraciones).  
- Tu clase controla **recursos compartidos** como conexiones, registros o cachés.  
- Necesitas **coordinar acciones globales** desde una única fuente de verdad (por ejemplo, un registro de producción).


