# Composite design pattern
Composite design pattern is a stractural design pattern which enables us to compose objects in tree structure to represent a part or whole hierarchies. It enables client to treat indevidual object or group of objects uniformly by defining a common interface or abstract class called as component.

## Main components 
Main components of composite design pattern are 
1. **Component** Component is an interface or abstract class that defines all common operations for leaf object or composite object
2. **Leaf** Leaf represents the individual objects in hierarchy, leaf always imlement all operations defined by component
3. **Composite** Composite objects are the group of objects that represent a part of hierarchy, composite object always imlement operations defined in component as well as some additional operations to maintain hierarchy

## Implementation of composite design pattern
