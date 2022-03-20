using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class RemembringState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                TextBox1.Text = "0";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(TextBox1.Text) + 1;
            TextBox1.Text = count.ToString();
            //now it will retain the value 
            //because it creates new instance of web form and text box 
            // How is it doing that ??--> all asp.net control use by default view state
          // field to retain the data that's why without using view state we can retain data
          // difference between asp.net controls and html controls is that asp.net controls retain state whereas html controls doesn't
          // html controls can be converted into asp.net controls by adding runat = server
        }
    }
}