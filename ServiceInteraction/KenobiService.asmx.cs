using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServiceInteraction
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class KenobiService : System.Web.Services.WebService, ICommunicableJedi
    {
        private GrievousReference.GrievousServiceSoapClient grievous;

        public KenobiService()
        {
            this.grievous = new GrievousReference.GrievousServiceSoapClient();
        }

        [WebMethod]
        public string SayHi(uint greetingsCounter, string log)
        {
            if (greetingsCounter != 0)
            {
                log += "Hello there. (left: " + (greetingsCounter - 1) + " greets)\r\n";
                return grievous.SayHi(greetingsCounter - 1, log);
            }
            else
            {
                return log;
            }
        }
    }
}
