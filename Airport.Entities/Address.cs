using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Entities
{
  public  class Address
    {
        public virtual string City { get; set; }
        public virtual string State { get; set; }
        public virtual string Country { get; set; }
        public virtual int PinNo { get; set; }
    }
}
