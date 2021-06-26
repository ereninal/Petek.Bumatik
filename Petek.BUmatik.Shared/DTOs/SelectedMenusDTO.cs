using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Shared.DTOs
{
    public class SelectedMenusDTO
    {
        public int StudentId { get; set; }
        public string Fullname { get; set; }
        public string BandNumber { get; set; }

        public string MenuType { get; set; }
        public string LastStatus { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
