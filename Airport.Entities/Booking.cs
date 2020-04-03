using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Entities
{
    public class Booking
    {
        public virtual DateTime FromDate { get; set; }
        public virtual DateTime ToDate { get; set; }
        public virtual string HangerNumber { get; set; }
        public virtual string HangerLocation { get; set; }
        public virtual int PalneId { get; set; }
    }
}
