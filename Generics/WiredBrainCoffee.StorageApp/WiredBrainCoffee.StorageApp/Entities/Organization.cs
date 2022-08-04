namespace WiredBrainCoffee.StorageApp.Entities
{
    public class Organization : EntityBase
    {
        public string? Name { get; set; }

        public override string ToString() => $"Employee ID: {Id}, FistName: {Name}";

    }
}
