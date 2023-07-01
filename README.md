# Composite design pattern
Composite design pattern is a stractural design pattern which enables us to compose objects in tree structure to represent a part or whole hierarchies. It enables client to treat indevidual object or group of objects uniformly by defining a common interface or abstract class called as component.

## Main components 
Main components of composite design pattern are 
1. **Component** Component is an interface or abstract class that defines all common operations for leaf object or composite object
2. **Leaf** Leaf represents the individual objects in hierarchy, leaf always imlement all operations defined by component
3. **Composite** Composite objects are the group of objects that represent a part of hierarchy, composite object always imlement operations defined in component as well as some additional operations to maintain hierarchy

## Implementation of composite design pattern
For example, lets implement an organization hierarchy by using composite design pattern

- Component to provide common interface
```
namespace CompositeDesignPattern
{
    /// <summary>
    /// Component: IEmployee is the component to provide common interface for
    ///            individual or group of objects. All leaf or composite objects
    ///            implement these operations.
    /// </summary>
    public interface IEmployee
    {
        /// <summary>
        /// Get or set for name
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Get or set for Salary
        /// </summary>
        double Salary { get; set; }

        /// <summary>
        /// Get or set for Mobile 
        /// </summary>
        string Mobile { get; set; }

        /// <summary>
        /// Print employee information
        /// </summary>
        void PrintInformation();
    }
}
```  
-   Developer as leaf node with uniform interface
```
namespace CompositeDesignPattern
{
    /// <summary>
    /// Leaf object: Developer class represent a leaf object that will implement all operations 
    ///              defined in component for uniform treatment
    /// </summary>
    public class Developer : IEmployee
    {
        /// <summary>
        /// Get or set for name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Get or set for Salary
        /// </summary>
        public double Salary { get; set; }

        /// <summary>
        /// Get or set for Mobile 
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// Initialize object 
        /// </summary>
        public Developer(string name, double salary, string mobile)
        {
            Name = name;
            Salary = salary;
            Mobile = mobile;
        }

        public void PrintInformation()
        {
            Console.WriteLine($" ====> Developer name : {this.Name} \n ====> Developer Salary : {this.Salary} \n ====> Developer mobile : {this.Mobile}");
        }
    }
}
```
- Manager as composite object that represent group of objects
 ```
namespace CompositeDesignPattern
{
    /// <summary>
    /// Composite object: Manager class represent composite object in hierarchy, it implement 
    ///                   all operations defined by component as well some additional operations.
    /// </summary>
    public class Manager : IEmployee
    {
        private IList<IEmployee> lstEmployee;

        /// <summary>
        /// Get or set for name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Get or set for Salary
        /// </summary>
        public double Salary { get; set; }

        /// <summary>
        /// Get or set for Mobile 
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// Initialize object 
        /// </summary>
        public Manager(string name, double salary, string mobile)
        {
            Name = name;
            Salary = salary;
            Mobile = mobile;
            lstEmployee = new List<IEmployee>();
        }

        /// <summary>
        /// Print information
        /// </summary>
        public void PrintInformation()
        {
            Console.WriteLine($" ==> Manager name : {this.Name} \n ==> Manager Salary : {this.Salary} \n ==> Manager mobile : {this.Mobile}");
            foreach (var emp in lstEmployee)
            {
                emp.PrintInformation();
            }
        }

        /// <summary>
        /// Add employee to hierarchy
        /// </summary>
        /// <param name="employee"></param>
        public void AddEmployee(IEmployee employee)
        {
            lstEmployee.Add(employee);
        }

        /// <summary>
        /// Remove employee from hierarchy
        /// </summary>
        /// <param name="employee"></param>
        public void RemoveEmployee(IEmployee employee)
        {
            lstEmployee.Remove(employee);
        }
    }
}
 ```
- Client code
  ```
  using CompositeDesignPattern;

var dev1 = new Developer("Surender Tanwar", 10000, "88888888");
var dev2 = new Developer("Dolly", 20000, "987654321");
var dev3 = new Developer("Poonam", 10000, "3434343434");

var dev4 = new Developer("JP", 15000, "55555555");
var dev5 = new Developer("Sonu", 30000, "333333333");

var manager1 = new Manager("Root", 65000, "6565656565");
manager1.AddEmployee(dev1);
manager1.AddEmployee(dev2);
manager1.AddEmployee(dev3);

var manager2 = new Manager("Composite", 32000, "3232323232");
manager2.AddEmployee(dev4);
manager2.AddEmployee(dev5);
manager1.AddEmployee(manager2);

manager1.PrintInformation();
Console.ReadLine();
  ```
