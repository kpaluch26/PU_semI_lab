﻿using System;

namespace Model
{
    public abstract class Rate
    {
        public int Id { get; set; }
        public short Value { get; set; }
        public DateTime Date { get; set; }
    }
}
