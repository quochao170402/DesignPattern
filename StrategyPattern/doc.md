# STRATEGY PATTERN

### 1. Identify

Strategy pattern defines a family of algorithm and encapsulates each one and makes them interchangeable.
The strategy lets the algorithm vary independently in clients that use it.

**Mean**:
It groups and encapsulates behaviors (methods) of objects and make it can be change internally without effect the code
that use it.

Instead of implement behaviors directly on class, the class receives behaviors from constructor or setter and perform
behaviors.

### 2. When to use it

* When you have many behaviors that perform a specific task but need to switch between them dynamically.

  **Explain**:

    * If I have a superclass and many subclasses, and a certain behavior is needed only by some subclasses, implementing
      the behavior in the superclass forces all subclasses to inherit it, which may result in unnecessary overrides.

    * On the other hand, using interfaces allows only relevant subclasses to implement the behavior, but this can lead
      to code duplication if multiple subclasses share the same implementation.

    * The Strategy Pattern solves this by extracting the behavior into separate strategy classes. The required strategy
      is then injected into the subclasses that need it, allowing behavior to be reused and swapped dynamically.


* Avoid large `if-else` or `switch` statements for select correct behavior:

  **Explain**:

    * Using if-else or switch to choose the correct behavior to perform a task. However, many if-else or switch can make
      harder to maintain and less readable. So the Strategy Pattern solve by inject behavior and use it to handle task.


* Isolating implementation details of algorithm from main logic and make sure the update not impact to component which
  used it.

### 3. Benefits:

* **Flexibility**: Easily to switch between different behaviors at runtime
* **Encapsulation**: Keep all separate from core logic
* **Scalability**: Easily to add new behaviors
* **Maintainability**: Remove complex if-else, switch, reduce redundant code, avoid duplicated code. 