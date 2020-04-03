using Airport.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.BusinessLayer.Interfaces
{
    public interface IAdminServices
    {
        bool AddPlane(Plane plane);
        bool AddPilot(Pilot pilot);
        bool AddHangerDetails(HangerDetails hangerDetails);


    }
}
