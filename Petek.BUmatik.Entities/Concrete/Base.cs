using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Entities.Concrete
{
    public abstract class Base
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public int? CreatedUserId { get; set; }//N olmalı(1-N) ilişkisi için
        public int? ModifiedUserId { get; set; }//N olmalı(1-N) ilişkisi için
    }
}
