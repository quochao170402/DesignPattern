# Singleton Pattern

### 1. Definition
Ensures that a class has only one instance and provides a global point of access to that instance.

**Meaning**: Only one instance of the Singleton class is created, and this instance can be accessed globally throughout the application.

### 2. When to Use It
- When you need exactly one instance of a class to be shared across the entire application.
- When consistent and centralized access to shared data or resources is required (e.g., logging, configuration, database connection).

### 3. Benefits
- Ensures consistent data across the application.
- Reduces resource usage by preventing multiple unnecessary instances.
- Provides a single point of control for managing shared state or behavior.