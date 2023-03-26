﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketing.Models
{
    public class Producer
    {
        [Key]
        public int ActorId { get; set; }
        public string ProfilePictureUrl { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
        //RelationShip
        public List<Movie> Movies { get; set; }
        

    }
}
