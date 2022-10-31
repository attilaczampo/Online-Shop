# Access Modifiers in C#


All types(classes,structs,records) and types members have a accessibility level.

The accessibility level controls whether the code can be used by other code in the same assembly or different assemblies.

Here are the access modifiers you can use for a type or member when you declare it:

<ol>
  <li>Public</li>
  <li>Private</li>
  <li>Protected</li>
  <li>Internal</li>
  <li>Protected Internal</li>
  <li>Private Protected</li>
</ol>

## 1. Public
  The type / member can be accessed by any other code inside of the assembly or other assemblies.
## 2. Private
  The type/ member can be accessed only by the code in the same class or struct. 
## 3. Protected
  The type/ member can be accessed only by the code in the same class or a class the derives from another class.
## 4. Internal
## 5. Protected Internal
## 6. Private Protected


# Class, records and structs accessibilities

Classes, records and structs that are declared directly, within a namespace can either be <i>public</i> or <i>internal</i>.

<i>Internal</i> is the default if no access modifier is declared.

# Class, record, and struct member accessibility

Class members and record members can have all 6 access modifier: public, private, protected, internal, protected internal, private protected.

Structs members can't be declared as protected, protected internal and private protected, because structs don't support inheritance.
