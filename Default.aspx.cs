using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WaterJugChallenge
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnStarChallengue_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Content/Views/Jug.aspx");
        }
    }
}