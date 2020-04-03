using Airport.BusinessLayer.Interfaces;
using Airport.DataLayer.NHibernateConfiguration;
using Airport.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.BusinessLayer.Services
{
    public class AdminServices : IAdminServices
    {
        private readonly IMapperSession _session;

        public AdminServices(IMapperSession session)
        {
            _session = session;
        }
        public bool AddHangerDetails(HangerDetails hangerDetails)
        {
            return true;
        }

        public bool AddPilot(Pilot pilot)
        {
            return true;
        }

        public bool AddPlane(Plane plane)
        {
            return true;
        }
    }
}
