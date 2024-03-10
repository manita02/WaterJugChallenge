using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WaterJugChallenge.Content.Controller;
using WaterJugChallenge.Content.Model;

namespace WaterJugChallenge
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        JugController jugController = new JugController();
        ValidationController validationController = new ValidationController();
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnShowResults_Click(object sender, EventArgs e)
        {
            string resultValidation = validationController.ValidateInputsEntered(txtVolumeZ.Text, txtVolumeX.Text, txtVolumeY.Text);
            if (string.IsNullOrEmpty(resultValidation))
            {
                int measurenmentZ = Convert.ToInt32(txtVolumeZ.Text);
                Jug jugX = jugController.CreateJug("X", Convert.ToInt32(txtVolumeX.Text));
                Jug jugY = jugController.CreateJug("Y", Convert.ToInt32(txtVolumeY.Text));
                Session["x"] = jugX;
                Session["y"] = jugY;
                Response.Redirect("ResultsTable.aspx?z=" + measurenmentZ);
            }
            else
            {
                lblJugInfo.Text = resultValidation;
            }
        }
    }
}