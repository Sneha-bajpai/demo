using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ispostback
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AddListBoxItems();
            }
            else
            {
                Response.Write("this is sneha");
            }
        }
        void AddListBoxItems()
        {
            ListBox1.Items.Add("item1");
        }
    }
}