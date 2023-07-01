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