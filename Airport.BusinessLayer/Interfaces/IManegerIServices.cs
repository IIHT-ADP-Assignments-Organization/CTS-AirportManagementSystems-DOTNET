using Airport.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.BusinessLayer.Interfaces
{
    public interface IManegerIServices
    {
        HangerDetails SearchHanger(DateTime FromDate, DateTime ToDate);
        bool AllocatePlane(Booking booking);
        Booking GetHangerStatus(DateTime FromDate, DateTime ToDate, string HangerNumber);
        HangerDetails GetHanger(DateTime FromDate, DateTime ToDate);
    }
}
