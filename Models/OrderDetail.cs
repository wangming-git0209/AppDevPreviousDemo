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
    [Table("Orders Detail")]
    public class OrdersDetail
    {
        
        [Display(Name = "Order Id")]     
        public int? OrderId {set; get;}

        [ForeignKey("OrderId")] 
        public Orders Orders {set; get;}

        [Display(Name = "ISBN")]
        public string? Isbn {set; get;}

        [ForeignKey("Isbn")] 
        public Book Book {set; get;}

        
        
        [Display(Name = "Quantity")]
        public int Quantity {set; get;}
       
        
    }
}