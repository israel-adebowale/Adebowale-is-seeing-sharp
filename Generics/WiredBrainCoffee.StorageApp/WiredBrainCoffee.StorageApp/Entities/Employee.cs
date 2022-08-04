namespace WiredBrainCoffee.StorageApp.Entities
{
    public class Employee : EntityBase
    {
        public string? FirstName { get; set; }

        public override string ToString() => $"Employee ID: {Id}, FistName: {FirstName}";
        
    }

}
