using Airport.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.DataLayer.Mapping
{
   public class BookingMap: ClassMap<Booking>
    {
        public BookingMap()
        {
            Id(x => x.FromDate);

            Map(x => x.ToDate);

            Map(x => x.HangerNumber);
            Map(x => x.HangerLocation);
            Map(x => x.PalneId);
          
            Table("booking");

        }
    }
}
