# Observer Patter

#### 1. Identify
Observer pattern defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically

**Mean**: the pattern create a one-to-many relationship between objects, **ONE** is a `subject` or `publisher` which will send notification to **MANY** which are `observers` or `subscribers` when it's state changed

#### 2. When to use it
* Many objects depend on a specific object and need know when the object change
* Decoupling the subject from its observers: The subject don't need knows about its observers, only notify them.
* Dynamic subscription and unsubscription at runtime: add and remove observers at runtime

#### 3. Benefits
* Loosely coupling: The subject (publisher) and observers (subscribers) are loosely coupled, subject don't need knows observers.
* Flexibility & Extensibility: Easily to add, remove, notify to observers and easily to add create and add new observer types