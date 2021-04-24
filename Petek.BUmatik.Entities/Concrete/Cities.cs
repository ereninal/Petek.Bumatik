using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Entities.Concrete
{
    public class Cities: Base, IEntity
    {
        public string Name { get; set; }
        public int CountryCode { get; set; }
    }
}
