namespace Redis_API.Models
{
    public class Platform
    {
        public string Id { get; set; } = $"platform:{Guid.NewGuid().ToString()}";
        public string Name { get; set; } = String.Empty; 

    }
}
