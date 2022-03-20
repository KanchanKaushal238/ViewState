using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class RememberState : System.Web.UI.Page
    {
        int count = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                TextBox1.Text = "0";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(ViewState["Clicks"] != null) //initially null but in another button action it will be 1 value is stored in hidden field in base64 format
            {
                count = (int)ViewState["Clicks"]+1;
            }
            TextBox1.Text = count.ToString(); //initially 1
            ViewState["Clicks"] = count; // 1 is stored in it, the value will flow b/w client and server
            //in page initalisation before page load event , view state restoration happen

        }
    }
}