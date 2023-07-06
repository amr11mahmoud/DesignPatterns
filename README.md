Reference: Design Patterns: elements of reusable object-oriented Software

Design Patterns Types:
1. Creational
2. Structural
3. Behavioral
_______________________________________________________________________
1.1 Singleton

![structure-en](https://github.com/amr11mahmoud/DesignPatterns/assets/53308603/ba9a1aac-46dd-4df1-a456-3541500a242a)

(image source: https://refactoring.guru/design-patterns/singleton)

The Singleton design pattern is a creational design pattern that ensures the existence of only one instance of a class in an application. It restricts the instantiation of a class to a single object, providing global access to that object.

Intent:
The Singleton pattern aims to control the instantiation process of a class and guarantee that only one instance of the class exists throughout the application.

Motivation:
There are scenarios where having multiple instances of a class can lead to issues or unnecessary resource consumption. The Singleton pattern addresses these concerns by providing a single point of access to a shared instance of the class.

Implementation:
To create a Singleton class, you typically follow these steps:

Make the constructor of the class private, preventing direct instantiation of the class from outside.
Create a static method within the class that serves as the access point to the instance of the class. This method is responsible for creating an instance if one doesn't exist, and returning the existing instance if it already exists.
Define a static member variable to hold the single instance of the class.
Whenever an instance of the class is needed, use the static access method to obtain it.
Benefits:
The Singleton pattern offers several advantages, including:

Global access: The Singleton instance can be accessed from any part of the application, providing a convenient way to share data or resources.
Control over instantiation: The Singleton pattern ensures that only one instance of the class is created, eliminating the risk of multiple conflicting instances.
Lazy initialization: The instance is created when it is first requested, which can be beneficial for resource-intensive objects that are not always needed.
Drawbacks:
While the Singleton pattern can be useful, it also has some drawbacks to consider:

Limited extensibility: Extending a Singleton class can be challenging because the constructor is private, and inheritance might lead to multiple instances.
Global state: Since the Singleton instance is globally accessible, it can introduce global state in the application, making it harder to manage and test.
Multithreading issues: Care must be taken when implementing Singletons in a multithreaded environment to ensure thread safety and avoid race conditions.
Overall, the Singleton pattern provides a way to ensure a single instance of a class and centralized access to that instance, making it useful in various scenarios, such as managing configuration settings, database connections, and logging systems.
_______________________________________________________________________

1.2 FactoryMethod

![FactoryMethod](https://github.com/amr11mahmoud/DesignPatterns/assets/53308603/eadb1f41-ec1b-4543-a577-0f4df8598760)

(image source: https://refactoring.guru/design-patterns/factory-method)

The Factory Method design pattern is a creational design pattern that provides an interface for creating objects but delegates the instantiation logic to subclasses. It allows a class to defer the instantiation of objects to its subclasses.

Here's a brief overview of the Factory Method design pattern:

Intent:
The Factory Method pattern aims to provide a way for creating objects without specifying their exact classes. It promotes loose coupling by relying on subclasses to determine the object creation process.

Motivation:
In some scenarios, a class cannot anticipate the exact type of objects it needs to create. Rather than tightly coupling the class to specific concrete classes, the Factory Method pattern introduces an abstract method for creating objects, which subclasses can override to provide their own implementation.

Implementation:
To apply the Factory Method pattern, you generally follow these steps:

Define an abstract base class that declares the factory method. This method serves as the interface for creating objects but does not provide a concrete implementation.
Create concrete subclasses that inherit from the base class. Each subclass provides its own implementation of the factory method, instantiating specific objects.
Client code invokes the factory method through the abstract base class, without knowing the exact class of the created object.
At runtime, the appropriate subclass is instantiated based on the context or configuration, and the client code receives an object without being aware of the specific subclass.
Benefits:
The Factory Method pattern offers several advantages, including:

Flexible object creation: It allows for flexible object creation by deferring the responsibility to subclasses. New classes can be added without modifying existing client code.
Encapsulation: The object creation logic is encapsulated within the subclasses, promoting encapsulation and separation of concerns.
Extensibility: The Factory Method pattern supports the addition of new product types or variations by introducing new subclasses.
Drawbacks:
While the Factory Method pattern has its benefits, it also has some drawbacks to consider:

Complexity: The pattern introduces additional complexity by requiring the definition of multiple classes, which might not be necessary in simpler scenarios.
Increased number of classes: Introducing subclasses for each product type can lead to an increased number of classes in the codebase, potentially making it more difficult to manage.
Overall, the Factory Method pattern provides a flexible way to create objects without tightly coupling client code to concrete classes. It enables extensibility and encapsulation, making it suitable for scenarios where object creation is dynamic or varies based on certain conditions.
_______________________________________________________________________
1.3 ProtoType
1.4 Builder


 
