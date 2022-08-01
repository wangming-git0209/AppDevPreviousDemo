using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using appdev.Models.Stores;
using Microsoft.AspNetCore.Identity;

namespace appdev.Models
{
    public class AppUser : IdentityUser
    {
        

        [Column(TypeName ="nvarchar")]
        [StringLength(400)]
        public string ?DiaChi {set; get;}

        public virtual List<Cart> Carts { get; set; } 
    
    }
}  