using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VideoGameShop2.Models
{
    public class VideoGameShop2DB : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public VideoGameShop2DB() : base("name=VideoGameShop2DB")
        {
        }

        public System.Data.Entity.DbSet<VideoGameShop2.Models.Products> Products { get; set; }

        public System.Data.Entity.DbSet<VideoGameShop2.Models.Seller> Sellers { get; set; }

        public System.Data.Entity.DbSet<VideoGameShop2.Models.SellerList> SellerLists { get; set; }

        public System.Data.Entity.DbSet<VideoGameShop2.Models.User> Users { get; set; }
    }
}
