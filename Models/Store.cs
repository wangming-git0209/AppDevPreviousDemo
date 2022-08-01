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
    [Table("Store")]
    public class Store
    {
        [Key]
        [Required]
        [Display(Name = "Store ID")]
        public int StoreId {set; get;}

        [Display(Name = "UID")]
        public int UId {set; get;}
        
        [Display(Name = "Address")]
        public string Address {set; get;}

        [Display(Name = "Slogan")]
        public string Slogan {set; get;}
        
    }
}