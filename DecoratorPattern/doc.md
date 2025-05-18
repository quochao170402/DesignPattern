# Decorator Pattern

## 1. Identity
Decorator pattern attach additional responsibilities to an objects dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.

**Mean**: The object will be wrapped by decorators which will add behaviors before and/or after the object behaviors dynamically in runtime without modify structure.

## 2. When to use it
* Need to add responsibilities to an object flexibly at runtime without modifying existing code

* Avoid class explosion caused by creating many subclasses that inherit from a common superclass

## 3. Benefits
* Easily to add responsibilities to an object
* Reduce redundant code caused by manage a lot of subclasses