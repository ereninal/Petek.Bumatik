using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Shared.DTOs
{
    public class SelectedMenuPackageDTO
    {
        public int? StudentId { get; set; }
        public string StudentName { get; set; }
        public string BandNumber { get; set; }
        public DateTime? UseDate { get; set; }
        public int? PackageId { get; set; }
        public int? SelectedMenuId { get; set; }
    }
}
