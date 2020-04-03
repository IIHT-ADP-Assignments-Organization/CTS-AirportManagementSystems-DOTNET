using System;
using System.Collections.Generic;
using System.Text;


namespace Airport.Test.Exceptions
{
   public class SocialSecurityNoAlreadyExistException:Exception
    {
        public string Messages = "SocialSecurityNo Already Exist";

        public SocialSecurityNoAlreadyExistException(string message)
        {
            Messages = message;
        }

    }
}
