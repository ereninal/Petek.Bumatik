using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Shared.DTOs
{
    public class TransactionDataDTO
    {
        public List<string> StudentNames { get; set; }
        public List<DateTime> UseDates { get; set; }
        public List<int> ItemCount { get; set; }
        public TransactionDataDTO()
        {
            StudentNames = new List<string>();
            UseDates = new List<DateTime>();
            ItemCount = new List<int>();
        }
    }
}
