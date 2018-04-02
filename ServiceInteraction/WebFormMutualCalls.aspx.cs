using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServiceInteraction
{
    public partial class WebFormMutualCalls : System.Web.UI.Page
    {
        private KenobiReference.KenobiServiceSoapClient jediClient;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.jediClient = new KenobiReference.KenobiServiceSoapClient();
        }

        protected void ButtonCall_Click(object sender, EventArgs e)
        {
            if (TextBoxCallCount.Text != "")
            {
                TextBoxResult.Text = "";
                uint callCount;
                TextBoxResult.Text = UInt32.TryParse(TextBoxCallCount.Text, out callCount) ?
                    jediClient.SayHi(callCount, "") : "Invalid call count";
            }
        }
    }
}