# Online-Shop

## About The Project

This app is a C# console app, in which are presented multiple C# topics, like Inheritance, Abstract classes, Constructor types and so on.
Each topic is presented in it's own project assembly, making the code easier to read.


<!-- TABLE OF CONTENTS -->
## Table of contents / Project assemblies
<ul>
  <li>MyApp</li>
  <li>ProjectA</li>
  <li>ProjectB</li>
  <li>ProjectC</li>
  <li>ProjectD</li>
</ul>  

## MyApp

This project assembly is about classes and the relation between them. In here, we talk about topics like Inheritance, Base calls, Abstract Classes, Virtaul Methods.

We have multiple classes, the Details.cs class being the BASE Class.
The Phone, PC and TV classes inherit from the base class, which is an ABSTRACT Class.

This classes inherit through CONSTRUCTORS and METHODS(). We've looked and saw the differences
between abstract methods and virtual methods.The main difference between the two, is that an abstract method needs implementation, the method must be overriden, while the virtual method can be overriden, but is not necesarry. You can leave a virtual method with it's default implementation, without to override with a new implementation.

Also, we defined a PARAMETERIZED CONSTRUCTOR in the Base class, and we saw the use of the "base" keyword in the derived classes.

## Project A

In this assembly, we showcased the structs.

## Project B

Constructor types. Here, we defined what a constructor is and what kind of constructors exist in C#.
Here are some of them: 

<ul>
  <li>Default/Parameterless Constructor</li>
  <li>Parameterized Constructor</li>
  <li>Copy Constructor</li>
  <li>Static Constructor</li>
  <li>Private Constructor</li>
</ul>

## Project C

Type-checking. "is" Operator.

Here, we look at Type-checking with the "is" operator. Basically, what the "is" keyword does, it returns true if an object can be cast to a specific type, otherwise false.

We have 3 classes: Student, JuniorStudent and SeniorStudent. The latest two, are derived classes, that inherit from Student class. Check the code for more.

## Project D

Type casting. "As" Operator.

The 'as' operator, attempts to cast an object to a specific type, adn returns null, if it fails.

We cannot type-cast base type to derived types.

What is the difference between Cast operator and As operator ?

Cast operator throws an exception if the conversion fails (it makes the app to crash)
As operator returns NULL if the conversion fails.

We have 3 classes: Student, JuniorStudent and SeniorStudent. The latest two, are derived classes, that inherit from Student class. Check the code for more.



