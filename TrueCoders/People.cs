using System;
namespace TrueCoders
{
    public class People
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HairColor { get; set; }

        public People(string fN, string lN, int age, string hC)
        {
            Age = age;
            FirstName = fN;
            LastName = lN;
            HairColor = hC;
        }
    }
}
