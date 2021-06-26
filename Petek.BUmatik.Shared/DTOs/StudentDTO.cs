﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Shared.DTOs
{
    public class StudentDTO
    {
        public int StudentId { get; set; }
        public string Fullname{ get; set; }
        public decimal RemainingMoney { get; set; }
        public string SchoolName { get; set; }
        public string BandNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int RecordsTotal { get; set; }


    }
}
