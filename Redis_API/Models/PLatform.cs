using System.ComponentModel.DataAnnotations;

namespace Redis_API.Models
{
    
        public class Platform
        {
            [Required]
            public string Id { get; set; } = $"platform:{Guid.NewGuid().ToString()}";

            [Required]
            public string Name { get; set; } = String.Empty;
        }

}
