﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FilmsCatalog.Models
{
    public class Film
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string CreatorId { get; set; }

        public User Creator { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Year { get; set; }

        public string Producer { get; set; }

        public string Path { get; set; }
    }
}
