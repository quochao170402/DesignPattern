# Facade

## 1. Defined

The Facade Pattern provides a unified interface to a set of interfaces in a subsystem. Facade defines a higher-level
interface that makes the subsystem easier to use

**Meaning**:
- The Facade Pattern creates a single entry point (an interface or class) that simplifies access to a complex subsystem.
- Instead of interacting directly with multiple complicated classes, the client uses this facade to perform operations,
making the code easier to use and understand.

## 2. When to use it

- When have a complex subsystem and need simplify way client interact it.
- Need decoupled client and complex code

## 3. Benefits

- Simplified complex system by provides a single entry point to access
- Reduces coupling between client and subsystem
- Promotes separation of concerns by make client focuses on what to do, not how it's done
- Improve maintainability, readability and usability

## 4. Facade and Adapter

- A facade not only simplifies an interface, it **decouples** a client from a subsystem of components.
- Facades and adapters may **wrap** multiple classes, but a facade’s intent is to **simplify**, while an adapter’s is to
  **convert** the interface to something different.