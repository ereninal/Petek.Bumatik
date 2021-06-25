using Petek.BUmatik.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Shared.DTOs
{
    public class SelectedMenuDetailsDTO
    {
        public string StudentName { get; set; }
        public string BandNumber { get; set; }

        public List<SelectedMenuItems> MenuItems { get; set; }

        public SelectedMenuDetailsDTO()
        {
            MenuItems = new List<SelectedMenuItems>();
        }
    }
}
