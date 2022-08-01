using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using appdev.Models.Stores;



namespace appdev.Models
{
    [Table("Book")]
    public class Book
    {
        [Key]
        [Required]
        [Display(Name = "Key Book")]
        public string Isbn {set; get;}

        // [Display(Name = "Store ID")]  
        // public int StoreId;
        [ForeignKey("StoreId")]   
        public Store Store {set; get;} 


        [Display(Name = "Book title")]
        public string Title {set; get;}
        
        [Display(Name = "Book category")]
        public string Category {set; get;}

        [Display(Name = "Page")]
        public int Pages {set; get;}

        [Display(Name = "Book price")]
        public Decimal Price {set; get;}
        
        [Display(Name = "Book description")]
        public string Desc {set; get;}

        [Display(Name = "Book image")]
        public string ImgUrl {set; get;}   

        [Display(Name = "Book Author")]
        public string Author {set; get;}
        
    }
}