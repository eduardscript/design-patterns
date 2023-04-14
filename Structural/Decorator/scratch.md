The **Decorator pattern** is a structural design pattern that provides a flexible way to extend the functionality of objects dynamically. It involves five key components:

1. **Component**
    - The Component declares the common interface that both the Concrete Component and Base Decorator implement.
    - It acts as a base for all objects that can have additional behaviors dynamically added to them.

2. **Concrete Component**
    - The Concrete Component is a class that implements the Component interface.
    - It represents the original object to which we want to add extra functionality.
    - Defines the basic behavior of the Component.

3. **Base Decorator**
    - The Base Decorator is an abstract class or interface that implements the Component interface.
    - It acts as the base class for all concrete decorators.
    - It holds a reference to the Component object and delegates operations to it.
    - The field type of the Base Decorator must be of the Component type, allowing it to wrap both the Concrete Component and Concrete Decorators.

4. **Concrete Decorators**
    - Concrete Decorators are classes that extend the Base Decorator.
    - They add new behaviors or modify existing behaviors of the Component.
    - They maintain a reference to a Component object and can wrap other decorators.

5. **Client**
    - The Client interacts with the Component and Concrete Decorators.
    - It creates and configures the desired combination of decorators to add functionality to the Component.
    - The Client can use the Component directly or through the decorators, as they all adhere to the same interface.

By applying the Decorator pattern, you can enhance an object's behavior by wrapping it with one or more decorators. Each decorator adds specific functionality while preserving the object's original interface. This pattern promotes the principle of "composition over inheritance" and allows for dynamic behavior modification at runtime.