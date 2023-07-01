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
