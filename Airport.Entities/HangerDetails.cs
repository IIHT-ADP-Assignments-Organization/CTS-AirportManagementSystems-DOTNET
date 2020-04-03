using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Entities
{
   public class HangerDetails
    {
        //HangerDeatils along with manegerDetails
        public virtual string HangerNumber { get; set; }
        public virtual string HangerLocation { get; set; }
        public virtual int HangerCapacity { get; set; }
        public virtual long NoOfPlane { get; set; }
        public virtual string ManegerName { get; set; }
        public virtual string SocialSecurityNo { get; set; }
        public virtual DateTime DateOfBirth { get; set; }
        public virtual string Gender { get; set; }
        public virtual string MobileNo { get; set; }
        public virtual string Email { get; set; }
        public virtual string HouseNo { get; set; }
    }
}
