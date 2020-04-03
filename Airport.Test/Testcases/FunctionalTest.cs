using Airport.BusinessLayer.Services;
using Airport.DataLayer.NHibernateConfiguration;
using Airport.Entities;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Airport.Test.Testcases
{
   public class FunctionalTest
    {
        private readonly ManegerServices _ManegerServices;
        private readonly AdminServices _AdminServices;


        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public FunctionalTest()
        {
            _ManegerServices = new ManegerServices(_session);
            _AdminServices = new AdminServices(_session);


        }

        [Fact]
        public void Test_for_SearchHanger()
        {
            Booking booking = new Booking()
            {
                FromDate = DateTime.Now,
                ToDate = DateTime.Now
            };

            var Result = _ManegerServices.SearchHanger(booking.FromDate, booking.ToDate);
            var GetHanger = _ManegerServices.GetHanger(booking.FromDate, booking.ToDate);
            Assert.Equal(GetHanger, Result);
        }


        [Fact]
        public void Test_For_AllocatePlane()
        {
            Booking booking = new Booking()
            {
                FromDate = DateTime.Now,
                ToDate = DateTime.Now,
                HangerLocation="ddd",
                HangerNumber="dff",
                PalneId=1

            };
            var Result = _ManegerServices.AllocatePlane(booking);
            Assert.True(Result);
        }

        [Fact]
        public void Test_For_AddHangerDetails()
        {
            HangerDetails hangerDetails = new HangerDetails()
            {
                
                HangerLocation = "ddd",
                HangerNumber = "dff",
               DateOfBirth=DateTime.Now,
               SocialSecurityNo="dd",
               Email="aa@gail.com",
               Gender="f",
               HangerCapacity=6,
               HouseNo="dd",
               ManegerName="dd",
               MobileNo="11111",
               NoOfPlane=12
            };
            var Result = _AdminServices.AddHangerDetails(hangerDetails);
            Assert.True(Result);
        }

        [Fact]
        public void Test_For_AddPilot()
        {
            Pilot pilot = new Pilot()
            {
                PalneName = "ss",
                state = "ss",
                Address = "ss",
                City = "dd",
                DOB = DateTime.Now,
                Country = "dd",
                Email = "g@gmail.com",
                Gender = "f",
                HoseNumber = "ddd",
                LicenceNo = "ddd",
                MobileNo = "11111",
                PilotId = 1,
                PinNo = 4444
            };
            var Result = _AdminServices.AddPilot(pilot);
            Assert.True(Result);
        }

        [Fact]
        public void Test_For_AddPlane()
        {
            Plane plane = new Plane()
            {
                Address = "ff",
                Capacity = 11,
                City = "ff",
                Country = "ff",
                Email = "s@gmail.com",
                HouseNo = "ff",
                ManufactureName = "dd",
                MobileNo = "ff",
                PalneName = "ff",
                PinNo = 222,
                PlaneId = 1,
                RegistrationNo = "vv",
                State = "vv"

            };
            var Result = _AdminServices.AddPlane(plane);
            Assert.True(Result);
        }
    }
}
