using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VideoGameShop2.Models
{
    public class Seller
    {
        [Required]
        [Key]
        public int sellerID { get; set; }

        [Required(ErrorMessage ="Please enter a seller name")]
        [StringLength(100, MinimumLength = 3, ErrorMessage ="The lengt must be between 3 and 100")]
        public string sellerName { get; set; }

        [Required(ErrorMessage ="Please insert the seller's home page")]
        [DataType(DataType.Url)]
        public string sellerHomePage { get; set; }

        [Required(ErrorMessage = "Please insert the seller's search URL")]
        [DataType(DataType.Url)]
        public string sellerSearchURL { get; set; }

    }
}