﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTO
{
    public class BookDTO
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double AvarageRate { get; set; }
        public int RatesCount { get; set; }
        public List<BookAuthorDTO> Authors { get; set; }
    }
}
