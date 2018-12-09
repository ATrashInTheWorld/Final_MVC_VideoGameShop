using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace VideoGameShop2.Models
{
    public class WhishList
    {
        [Required]
        [Key]
        public int wishListID { get; set; }

        public List<Products> wishList { get; set; }


        //An IVALIDATOR will be used in order to make sure that there are no doubles
        // on the wish list
    }
}