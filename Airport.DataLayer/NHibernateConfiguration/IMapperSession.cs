﻿using Airport.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Airport.DataLayer.NHibernateConfiguration
{
    public interface IMapperSession
    {
        void BeginTransaction();
        System.Threading.Tasks.Task Commit();
        System.Threading.Tasks.Task Rollback();
        void CloseTransaction();
        System.Threading.Tasks.Task Save(Booking entity);
        System.Threading.Tasks.Task Delete(Booking entity);
        IQueryable<Booking> booking { get; }
    }
}
