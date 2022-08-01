using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using appdev.Models;



namespace appdev.Models.Stores
{
    [Table("Orders")]
    public class Orders
    {
        [Key]
        [Required]
        [Display(Name = "Id")]
        public int Id {set; get;}

        [ForeignKey("Uid")]
        public AppUser appUser {set; get;}


        [Display(Name = "Order Time")] 
        public DateTime OrderTime {set; get;}
        
        
        [Display(Name = "Total")]
        public Decimal Total {set; get;}
       
        
    }
}