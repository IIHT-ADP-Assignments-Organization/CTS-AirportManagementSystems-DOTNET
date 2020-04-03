using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Entities
{
    public class Plane
    {
        //manufacture details with plane details
        public virtual int PlaneId { get; set; }
        public virtual string ManufactureName { get; set; }
        public virtual string RegistrationNo { get; set; }
        public virtual string MobileNo { get; set; }
        public virtual string PalneName { get; set; }
        public virtual long Capacity { get; set; }
        
        public virtual string Email { get; set; }
        public virtual string HouseNo { get; set; }
        public virtual string Address { get; set; }
        public virtual string City { get; set; }
        public virtual string State { get; set; }
        public virtual string Country { get; set; }
        public virtual int PinNo { get; set; }

    }
}
