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

    public class Cart
    {
        
        public string Uid {set; get;}
        public AppUser appUser {set; get;}


        [Display(Name = "ISBN")] 
        public string? Isbn {set; get;}
        
        
        [ForeignKey("Isbn")]
        public Book Book {set; get;}  
        
    }
}