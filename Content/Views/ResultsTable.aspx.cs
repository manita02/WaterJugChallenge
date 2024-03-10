using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using WaterJugChallenge.Content.Controller;
using WaterJugChallenge.Content.Model;

namespace WaterJugChallenge
{
    public partial class ResultsTable : System.Web.UI.Page
    {
        JugController jugController = new JugController();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int measurenmentZ = int.Parse(Request.QueryString["z"]);
                Jug jugX = (Jug)Session["x"];
                Jug jugY = (Jug)Session["y"];
                GridView gridView = table;
                jugController.MeasureTheQuantityZinBothJugs(jugX, jugY, measurenmentZ);
                LoadGridView(jugController.GetExplanations(), jugController.GetXvolumes(), jugController.GetYvolumes());
                lbx.Text = "Total volume of jug X entered: " + jugX.TotalVolume.ToString();
                lby.Text = "Total volume of jug Y entered: " + jugY.TotalVolume.ToString();
                lbz.Text = "Z measurement entered: " + measurenmentZ.ToString();
            }
        }

        private void LoadGridView(List<string> explanations, List<string> jugXvolumes, List<string> jugYvolumes)
        {
            var dataSource = explanations.Select((explanation, index) => new
            {
                Explicacion = explanation,
                VolumenJug1 = jugXvolumes[index],
                VolumenJug2 = jugYvolumes[index]
            }).ToList();

            table.DataSource = dataSource;
            table.DataBind();

            MarkFinalSolutionCell();
        }

        private void MarkFinalSolutionCell()
        {
            if (table.Rows.Count > 0)
            {
                GridViewRow lastRow = table.Rows[table.Rows.Count - 1];
                TableCell cellVolumenJug1 = lastRow.Cells[1];
                TableCell cellVolumenJug2 = lastRow.Cells[2];
                int volumenJug1Value;
                if (int.TryParse(cellVolumenJug1.Text, out volumenJug1Value) && volumenJug1Value != 0)
                {
                    cellVolumenJug1.BackColor = System.Drawing.Color.Yellow;
                    lbSolution.Text = "There is a solution for the data entered previously. The Z measurement entered is equal to " + cellVolumenJug1.Text;
                }
                else
                {
                    cellVolumenJug2.BackColor = System.Drawing.Color.Yellow;
                    lbSolution.Text = "There is a solution for the data entered previously. The Z measurement entered is equal to " + cellVolumenJug2.Text;
                }
            }
        }



    }
}