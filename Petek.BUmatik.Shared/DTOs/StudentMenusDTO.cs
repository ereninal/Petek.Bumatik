using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Shared.DTOs
{
    public class StudentMenusDTO
    {
        public int StudentId { get; set; }
        public string MenuType { get; set; }
        public int MenuTypeId { get; set; }
        public string UseDate { get; set; }
        public string CreatedDate { get; set; }
        public bool LastStatus { get; set; }
        public int SelectedItemCount { get; set; }
    }
}
