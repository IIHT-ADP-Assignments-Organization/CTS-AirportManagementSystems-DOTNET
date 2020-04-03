using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Test.Exceptions
{
   public class MobileNoAlreadyExistException:Exception
    {
        public string Messages = "MobileNo Already Exist";

        public MobileNoAlreadyExistException(string message)
        {
            Messages = message;
        }
    }
}
