using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace WaterJugChallenge.Content.Model
{
    public class Jug
    {
        private string name;
        private int totalVolume;
        public int currentOccupiedVolume;

        
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("El nombre no puede estar vacío.");
                }
            }
        }

        
        public int TotalVolume
        {
            get { return totalVolume; }
            set
            {
                if (value > 0)
                {
                    totalVolume = value;
                }
            }
        }

        public Jug(string name, int capacity)
        {
            Name = name;
            TotalVolume = capacity;
            currentOccupiedVolume = 0;
        }


        
        public string Fill()
        {
            currentOccupiedVolume = totalVolume; 
            return "Fill jug " + this.name;
        }

    
        public string Transfer(Jug otherJug, int condition)
        {    
            if(condition == 0)
            {
                this.currentOccupiedVolume = this.currentOccupiedVolume - otherJug.TotalVolume;
                //Debug.WriteLine("Cantidad ACTUAL DE "+this.name+" : " + this.currentOccupiedVolume);
            }
            else
            {
                otherJug.currentOccupiedVolume = otherJug.currentOccupiedVolume + this.currentOccupiedVolume; 
            }
            return "Transfer from jug " + this.name + " to jug " + otherJug.name;
        }

        public string Empty()
        {
            currentOccupiedVolume = 0; 
            return "Empty jug "+this.name;
        }  
    }
}