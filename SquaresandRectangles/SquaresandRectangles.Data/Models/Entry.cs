﻿using System;
using System.ComponentModel.DataAnnotations;

namespace SquaresandRectangles.Data.Models
{
    class Entry
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ContentUrl { get; set; }

        public DateTime TimeTaken { get; set; }
    }
}
