using System;
using System.Collections.Generic;
namespace TrueCoders
{
    class Program
    {
        static void Main()
        {

            List<People> trueCoders = new List<People>();

            People BB = new People("BillyBob", "Bohannon", 21 , "Scotch");
            People JJ = new People("JimJoe", "Collins", 16 , "Burgundy");
            People IS = new People("Rocky", "Balboa", 24 , "Black");

            trueCoders.Add(BB);
            trueCoders.Add(JJ);
            trueCoders.Add(IS);

            foreach(var coder in trueCoders)
            {
                Console.WriteLine("Name: " + coder.FirstName + " "  + coder.LastName + " " + "Age: " +  coder.Age + " " + "Hair Color: " + coder.HairColor);
            }

        }
    }
}
