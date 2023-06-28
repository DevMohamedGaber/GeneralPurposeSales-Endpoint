using System.ComponentModel.DataAnnotations;

namespace GeneralPurposeSalesAppEndpoint.Models
{
    public class Offer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public float price { get; set; } = 0;
    }
}
