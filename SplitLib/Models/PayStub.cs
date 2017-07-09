namespace SplitLib.Models
{
    /// <summary>
    /// Holds information about an extracted paystub
    /// </summary>
    public class PayStub
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Filename { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}