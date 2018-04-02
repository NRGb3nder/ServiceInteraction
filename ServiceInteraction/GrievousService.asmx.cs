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
    public class GrievousService : System.Web.Services.WebService, ICommunicableJedi
    {
        private KenobiReference.KenobiServiceSoapClient kenobi;

        public GrievousService()
        {
            this.kenobi = new KenobiReference.KenobiServiceSoapClient();
        }

        [WebMethod]
        public string SayHi(uint greetingsCounter, string log)
        {
            if (greetingsCounter != 0)
            {
                log += "General Kenobi... (left: " + (greetingsCounter - 1) + " greets)\r\n";
                return kenobi.SayHi(greetingsCounter - 1, log);
            }
            else
            {
                return log;
            }
        }
    }
}
