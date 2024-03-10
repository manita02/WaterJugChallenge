using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using WaterJugChallenge.Content.Model;

namespace WaterJugChallenge.Content.Controller
{
    public class ValidationController
    {
        public bool CheckMostEfficientSolution(Jug jugX, Jug jugY, int measurementZ)
        {
            int differenceJugX = Math.Abs(jugX.TotalVolume - measurementZ);
            int differenceJugY = Math.Abs(jugY.TotalVolume - measurementZ);

            return differenceJugX > differenceJugY;
        }

        public bool CheckIfZisDivisibleByXorY(int z, int x, int y)
        {
            if ( z % Math.Min(x, y) == 0)
            {
                return true;
            }
            return false;
        }

        public bool CheckIfZisGreaterThanXorY(int z, int x, int y)
        {
            if ( z > x && z > y )
            {
                return false;
            }
            return true;
        }

        public bool CheckIfTheInputIsAnInteger(string input)
        {
            int number;
            if (int.TryParse(input, out number))
            {
                if( number != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }  
            }
            return false;
        }

        public string ValidateInputsEntered(string z, string x, string y)
        {
            if(CheckIfTheInputIsAnInteger(z) && CheckIfTheInputIsAnInteger(x) && CheckIfTheInputIsAnInteger(y) == true)
            {
                if(CheckIfZisGreaterThanXorY(Convert.ToInt32(z), Convert.ToInt32(x), Convert.ToInt32(y)) == true)
                {
                    if (CheckIfZisDivisibleByXorY(Convert.ToInt32(z), Convert.ToInt32(x), Convert.ToInt32(y)) == false)
                    {
                        return "The value of measurenment Z must be divisible by volume of jug X or jug Y... its division must give zero remainder. There is no solution for this case";
                    }
                    else
                    {
                        return "";
                    }
                }
                return "The value entered for measurenment Z must not be greater than the value of jug Y or jug X. There is no solution for this case";

            }
            else
            {
                return "The values ​​for measurenment Z, volume of jug X and jug Y must be integers and greater than zero. There is no solution for this case";
            }

        }
    }
}