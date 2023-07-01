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
