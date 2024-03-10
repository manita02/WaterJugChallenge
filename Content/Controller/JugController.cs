using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using WaterJugChallenge.Content.Model;

namespace WaterJugChallenge.Content.Controller
{
    public class JugController
    {
        List<string> explanationsColumn = new List<String>();
        List<string> columnOfXvolumes = new List<String>();
        List<string> columnOfYvolumes = new List<String>();
        ValidationController validationController = new ValidationController();


        public Jug CreateJug(string name, int capacity)
        {
            return new Jug(name, capacity);
        }

        public List<string> GetExplanations()
        {
            return this.explanationsColumn;
        }

        public List<string> GetXvolumes()
        {
            return this.columnOfXvolumes;
        }

        public List<string> GetYvolumes()
        {
            return this.columnOfYvolumes;

        }

        public void AddExplanation(string explanation)
        {
            explanationsColumn.Add(explanation);
        }

        public void AddJugVolumeX(int volume)
        {
            columnOfXvolumes.Add(volume.ToString());
        }

        public void AddJugVolumeY(int volume)
        {
            columnOfYvolumes.Add(volume.ToString());
        }

        private void AddInformationToColumnLists(string explanation, int currentOccupiedVolumeX, int currentOccupiedVolumeY)
        {
            AddExplanation(explanation);
            AddJugVolumeX(currentOccupiedVolumeX);
            AddJugVolumeY(currentOccupiedVolumeY);
        }


        public void MeasureTheQuantityZinBothJugs(Jug jugX, Jug jugY, int measurementZ)
        {
            if (validationController.CheckMostEfficientSolution(jugX, jugY, measurementZ) == true)
            {
                if (jugY.TotalVolume > measurementZ)
                {
                    AddInformationToColumnLists(jugY.Fill(), jugX.currentOccupiedVolume, jugY.currentOccupiedVolume);
                    while (jugY.currentOccupiedVolume > measurementZ) 
                    {
                        AddInformationToColumnLists(jugY.Transfer(jugX, 0), jugX.TotalVolume, jugY.currentOccupiedVolume);
                        AddInformationToColumnLists(jugX.Empty(), jugX.currentOccupiedVolume, jugY.currentOccupiedVolume);
                    }
                }
                else
                {
                    while (jugX.currentOccupiedVolume < measurementZ) 
                    {
                        AddInformationToColumnLists(jugY.Fill(), jugX.currentOccupiedVolume, jugY.currentOccupiedVolume);
                        AddInformationToColumnLists(jugY.Transfer(jugX, 1), jugX.currentOccupiedVolume, 0);
                    }
                }
            }
            else
            {
                if (jugX.TotalVolume > measurementZ)
                {
                    AddInformationToColumnLists(jugX.Fill(), jugX.currentOccupiedVolume, jugY.currentOccupiedVolume);
                    while (jugX.currentOccupiedVolume > measurementZ) 
                    {
                        AddInformationToColumnLists(jugX.Transfer(jugY, 0), jugX.currentOccupiedVolume, jugY.TotalVolume);
                        AddInformationToColumnLists(jugY.Empty(), jugX.currentOccupiedVolume, jugY.currentOccupiedVolume);
                    }
                }
                else
                {
                    while (jugY.currentOccupiedVolume < measurementZ) 
                    {
                        AddInformationToColumnLists(jugX.Fill(), jugX.currentOccupiedVolume, jugY.currentOccupiedVolume);
                        AddInformationToColumnLists(jugX.Transfer(jugY, 1), 0, jugY.currentOccupiedVolume);
                    }
                }
            }
        }
    }
}