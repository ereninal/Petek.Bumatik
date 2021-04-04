using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Shared.DTOs
{
    public class SchoolDTO
    {
        public string SchoolName{ get; set; }

        public List<StudentDTO> Students { get; set; }

        public SchoolDTO()
        {
            Students = new List<StudentDTO>();
        }

    }
}
