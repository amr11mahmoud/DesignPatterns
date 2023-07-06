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

Here's a brief overview of the Singleton design pattern:

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
1.3 ProtoType
1.4 Builder


 
