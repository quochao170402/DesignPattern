# Factory Method Pattern

### 1. Definition

Defines an interface to creating an object but let subclasses decide class which will create object. Factory Method
pattern lets a class defer instantiation to the subclass.

### 2. When to use it

* Have many types of object, need create object without exactly identify type as design time or need identity at
  runtime.
* Creating object is complex and duplicated in many place -> increase time to modify when have any change in types

### 3. Benefits

* Reduce duplicated code
* Loosely coupled
* Follow dependency inversion principle - the code depends on abstractions rather than concrete classes.

# Abstract Factory Pattern

### 1. Definition

Provide an interface to creating families of related or dependencies objects without specifying concrete classes.

**Mean**: create a factory interface with have many methods to create many objects in a family.

### 2. When to use it

* Have many families of related or dependencies objects, need create object but define type at runtime
* When need create related objects from a factory

### 3. Benefits

* Enforces consistency among products in the same family.

* Promotes loose coupling between client code and the concrete classes of the products.

* Makes it easier to add new product families without modifying existing code.