using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace VideoGameShop2.Models
{
    public class SellerList
    {

        [Required]
        [Key]
        public int sellerListID { get; set; }

        public Seller[] sellers { get; set; }

    }
}