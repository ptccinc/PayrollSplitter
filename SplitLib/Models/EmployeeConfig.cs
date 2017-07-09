namespace SplitLib.Models
{
    /// <summary>
    /// Holds data responsible for identifying an employee
    /// </summary>
    public class EmployeeConfig
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UniqueIdentifier { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}