# Adapter Pattern

## 1. Identity

The Adapter pattern converts the interface of a class into another interface the clients expect. Adapter lets classes
work together that couldn't otherwise because of incompatible interfaces

**Meaning**: It introduces a middle class (the adapter), which receives a request from the client and translates or
delegates it to the appropriate method on the incompatible class (the adaptee) in a way the client can understand or
use.

## 2. When to use it

- The project need integrate interfaces, but they are incompatible with system. Using Adapters to adapt
- System need reuse legacy code or modules from third-party which often incompatible code base
- When you're gradually replacing a system, and you need a temporary bridge.
- Requires share common code across system, the code can be incompatible in some place and need adapt

## 3. Benefits

- Isolates the code that performs the transformation between interfaces.
- Allows incompatible interfaces to work together smoothly and reuse existing (legacy or third-party) code without
  modifying it
- Code is open for extension but closed for modification.
- Clients depend only on the target interface, not the real implementation.
- Clients always deal with a consistent and predictable interface.