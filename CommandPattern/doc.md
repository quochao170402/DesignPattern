# Command Pattern

### 1. Definition

encapsulates a request as an object, thereby letting you parameterize other objects
with different requests, queue or log requests, and support undoable operations

**Mean**: Create object for action and pass them as param of other request, and allow manage object (action) by store,
order or undo if need.

### 2. When to use it

* Manage many objects with many action, use Command pattern to help client ignore how to it work, it only focuses on
  responsible of methods
* Allow handle store actions, logging, undo (rollback)
* Decouple code which invokes the action from code execute it.

### 3. Benefits

* Easily to manage a lot of action because now they are object as parameters of request and can manage object as data to
  easily store
* Easily to add new actions by create new commands
* Decouples the invoker from the receiver: class call execute doesn't need know about class actual performs action