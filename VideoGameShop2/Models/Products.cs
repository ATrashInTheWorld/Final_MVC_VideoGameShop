using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VideoGameShop2.Models
{
    public class Products
    {
       

        public enum AvailableConsol { Xbox360, XboxOne,
                                    PlayStation2, PlayStation3, PlayStation4, PSP, PSVita,
                                    NintendoSwich, Wii, WiiU, NintendoDS, Nintendo3DS, Gamecube,
                                    PC, Steam};

        public enum GameType { Fighing, Race, Adventure, RPG, Action, Puzzle, Shooter, Strategy,
                                Platformer, Sports, Simulation, Misc};

        public enum ESRBrating { E, E10, T, M, A};


        [Required(ErrorMessage = "ISBN is required")]
        [Key]
        public int productISBN { get; set; }

        [Required(ErrorMessage = "The title of the game is required")]
        [StringLength(100, ErrorMessage = "MAX 1500 chars included spaces")]
        public string productTitle { get; set; }

        [Required(ErrorMessage ="A descriptionof the game is required")]
        [StringLength(1500, ErrorMessage = "MAX 1500 chars included spaces")]
        public string productDescription { get; set; }

        [EnumDataType(typeof(AvailableConsol))]
        [Required(ErrorMessage = "Available console(s) are required")]
        public AvailableConsol availableConsole1 { get; set; }

        [EnumDataType(typeof(AvailableConsol))]
        public AvailableConsol availableConsole2 { get; set; }

        [EnumDataType(typeof(AvailableConsol))]
        public AvailableConsol availableConsole3 { get; set; }

        [EnumDataType(typeof(GameType))]
        [Required(ErrorMessage = "Game type(s) are required")]
        public GameType gametype1 { get; set; }

        [EnumDataType(typeof(GameType))]
        [Required(ErrorMessage = "Game type(s) are required")]
        public GameType gametype2 { get; set; }

        [EnumDataType(typeof(GameType))]
        [Required(ErrorMessage = "Game type(s) are required")]
        public GameType gametype3 { get; set; }

        [EnumDataType(typeof(ESRBrating))]
        [Required(ErrorMessage ="ESRB Rating is required")]
        public ESRBrating esrbRating { get; set; }

        [DataType(DataType.Url)]
        public string preview { get; set; }

        [DataType(DataType.Date)]
        public DateTime releasedDate { get; set; }

        public string imagePath { get; set; }

        [Required(ErrorMessage = "Plese set the Entered Date")]
        public DateTime enteredDate { get; set; }


    }
}