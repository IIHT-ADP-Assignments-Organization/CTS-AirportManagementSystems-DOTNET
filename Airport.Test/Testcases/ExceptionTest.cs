using Airport.BusinessLayer.Services;
using Airport.DataLayer.NHibernateConfiguration;
using Airport.Entities;
using Airport.Test.Exceptions;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Airport.Test.Testcases
{
   public class ExceptionTest
    {

        private readonly ManegerServices _ManegerServices;
        private readonly AdminServices _AdminServices;


        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public ExceptionTest()
        {
            _ManegerServices = new ManegerServices(_session);
            _AdminServices = new AdminServices(_session);


        }

        [Fact]
        public void ExceptionTestFor_PilotEmailAlreadyExist()
        {
             Pilot pilot = new Pilot()
            {
                Email = "example@gmail.com"
            };
            //Assert
            var ex = Assert.Throws<EmailAlreadyExistException>(() => _AdminServices.AddPilot(pilot));
            Assert.Equal("Email Already Exist ", ex.Messages);
        }
        [Fact]
        public void ExceptionTestFor_ManufactureEmailAlreadyExist()
        {
             Plane plane = new Plane()
            {
                Email = "example@gmail.com"
            };
            //Assert
            var ex = Assert.Throws<EmailAlreadyExistException>(() => _AdminServices.AddPlane(plane));
            Assert.Equal("Email Already Exist ", ex.Messages);
        }
        [Fact]
        public void ExceptionTestFor_ManagerEmailAlreadyExist()
        {
             HangerDetails Hangerdetails = new HangerDetails()
            {
                Email = "example@gmail.com"
            };
            //Assert
            var ex = Assert.Throws<EmailAlreadyExistException>(() => _AdminServices.AddHangerDetails(Hangerdetails));
            Assert.Equal("Email Already Exist ", ex.Messages);
        }

        [Fact]
        public void ExceptionTestFor_MobileNoAlreadyExist()
        {
              HangerDetails Hangerdetails = new HangerDetails()
            {
               MobileNo=" 7878765465"
            };
            //Assert
            var ex = Assert.Throws<MobileNoAlreadyExistException>(() => _AdminServices.AddHangerDetails(Hangerdetails));
            Assert.Equal("MobileNo Already Exist ", ex.Messages);
        }
        [Fact]
        public void ExceptionTestFor_PilotMobileNoAlreadyExist()
        {
            Pilot pilot = new Pilot()
            {
               MobileNo= "7878765465"
            };
            //Assert
            var ex = Assert.Throws<MobileNoAlreadyExistException>(() => _AdminServices.AddPilot (pilot));
            Assert.Equal("MobileNo Already Exist ", ex.Messages);
        }

       [Fact]
        public void ExceptionTestFor_SocialSecurityNoAlreadyExist()
        {
             HangerDetails Hangerdetails = new HangerDetails()
            {
               SocialSecurityNo=" 12345"
            };
            //Assert
            var ex = Assert.Throws<SocialSecurityNoAlreadyExistException>(() => _AdminServices.AddHangerDetails(Hangerdetails));
            Assert.Equal("SocialSecurityNo Already Exist ", ex.Messages);
        }

    }
}

