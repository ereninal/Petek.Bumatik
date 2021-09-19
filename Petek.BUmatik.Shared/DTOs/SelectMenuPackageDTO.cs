using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Shared.DTOs
{
    public class SelectMenuPackageDTO
    {
        public int StudentId { get; set; }
        public int MenuTypeId { get; set; }
        public DateTime UseDate { get; set; }
        public int PackageId { get; set; }
        public int Count { get; set; }
    }
}
