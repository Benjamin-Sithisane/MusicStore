﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebWeek4.Models
{
    public class Customer
    {
       public int Id { get; set; }
       public string Name { get; set; }
       public int Age { get; set; }
       public string FavoriteGenre { get; set; }
       public string FavoriteSong { get; set; }
       public string ImagePath { get; set; }
        //update database later
    }
}
