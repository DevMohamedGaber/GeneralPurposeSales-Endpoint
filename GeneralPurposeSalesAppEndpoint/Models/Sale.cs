using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace GeneralPurposeSalesAppEndpoint.Models
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public virtual Offer offer { get; set; }
        [Required]
        public virtual IdentityUser user { get; set; }
    }
}
