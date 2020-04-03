using Airport.BusinessLayer.Interfaces;
using Airport.DataLayer.NHibernateConfiguration;
using Airport.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.BusinessLayer.Services
{
    public class ManegerServices : IManegerIServices
    {

        private readonly IMapperSession _session;

        public ManegerServices(IMapperSession session)
        {
            _session = session;
        }
      
        public bool AllocatePlane(Booking booking)
        {
            return true;
        }

        public HangerDetails GetHanger(DateTime FromDate, DateTime ToDate)
        {
            HangerDetails hangerDetails = new HangerDetails();
            return hangerDetails;
        }

        public Booking GetHangerStatus(DateTime FromDate, DateTime ToDate, string HangerNumber)
        {
            Booking booking = new Booking();
            return booking;
        }

        public HangerDetails SearchHanger(DateTime FromDate, DateTime ToDate)
        {
            HangerDetails hangerDetails = new HangerDetails();
            return hangerDetails;
        }
    }
}
