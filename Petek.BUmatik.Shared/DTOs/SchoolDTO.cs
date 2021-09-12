using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Shared.DTOs
{
    public class SchoolDTO
    {
        public int Id { get; set; }
        public string SchoolName{ get; set; }
        public int CountryId { get; set; }
        public bool IsDeleted { get; set; }

       

    }
}
