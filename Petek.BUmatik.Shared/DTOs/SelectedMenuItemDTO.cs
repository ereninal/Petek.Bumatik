using Petek.BUmatik.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Shared.DTOs
{
    public class SelectedMenuItemDTO
    {
        public int StudentId { get; set; }
        public List<SelectedMenuItems> selectedMenuItems { get; set; }
        
    }
}
