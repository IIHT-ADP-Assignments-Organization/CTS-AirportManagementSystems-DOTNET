using Airport.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Airport.Test.Testcases
{
    public class BoundaryTest
    {
        [Fact]
        public void BoundaryTest_ForLicenceNo_Length()
        {
            Pilot pilot = new Pilot()
            {
                LicenceNo = "1114564"
            };
            var MinLength = 10;
            var MaxLength = 10;

            //Action
            var actualLength = pilot.LicenceNo.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }

        [Fact]
        public void BoundaryTest_ForPilotPincode_Length()
        {

            Pilot pilot = new Pilot()
            {
                PinNo = 1114561
            };
            var MinLength = 7;
            var MaxLength = 7;

            //Action
            var actualLength = pilot.PinNo.ToString().Length;


            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }
        [Fact]
        public void BoundaryTest_ForDOB()
        {

            Pilot pilot = new Pilot()
            {
                DOB = DateTime.Now
            };

            //Action
            var DOBPattern = pilot.DOB;


            //Assert
            Assert.Matches(DOBPattern.ToString(), "dd-mm-yyyy");
        }

        [Fact]
        public void BoundaryTest_ForPhoneNo_Length()
        {
            Plane plane = new Plane()
            {
                MobileNo = "981114564"
            };
            var MinLength = 10;
            var MaxLength = 10;

            //Action
            var actualLength = plane.MobileNo.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }
        [Fact]
        public void BoundaryTest_ForPilotPhoneNo_Length()
        {
            Pilot pilot = new Pilot()
            {
                MobileNo = "981114564"
            };
            var MinLength = 10;
            var MaxLength = 10;

            //Action
            var actualLength = pilot.MobileNo.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }

        [Fact]
        public void BoundaryTest_ForManagerPincode_Length()
        {

            Address address = new Address()
            
            {
               PinNo = 1114561
            };
            var MinLength = 7;
            var MaxLength = 7;

            //Action
            var actualLength = address.PinNo.ToString().Length;


            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }
        [Fact]
        public void BoundaryTest_ForManufacturerPincode_Length()
        {

            Plane plane = new Plane()
            {
                PinNo = 1114561
            };
            var MinLength = 7;
            var MaxLength = 7;

            //Action
            var actualLength = plane.PinNo.ToString().Length;


            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }



    }


}
