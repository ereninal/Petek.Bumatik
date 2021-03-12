using Petek.BUmatik.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Entities.Concrete
{
    public class School :IEntitiy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }
        public int TownId { get; set; }


    }
}
