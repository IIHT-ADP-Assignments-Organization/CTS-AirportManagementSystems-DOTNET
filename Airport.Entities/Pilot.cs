using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Entities
{
    public class Pilot
    {
        public virtual int PilotId { get; set; }
        public virtual string PalneName { get; set; }
        public virtual string LicenceNo { get; set; }
        public virtual DateTime DOB { get; set; }
        public virtual string Gender { get; set; }
        public virtual string MobileNo { get; set; }
        public virtual string Email { get; set; }
        public virtual string HoseNumber { get; set; }
        public virtual string Address { get; set; }
        public virtual string City { get; set; }
        public virtual string state { get; set; }
        public virtual string Country { get; set; }
        public virtual int PinNo { get; set; }
    }
}
