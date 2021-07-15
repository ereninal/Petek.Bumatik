﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Shared.DTOs
{
    public class AutomatItemsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
    }
}
