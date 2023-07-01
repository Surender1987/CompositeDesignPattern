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
