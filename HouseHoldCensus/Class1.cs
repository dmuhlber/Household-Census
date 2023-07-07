using System;

namespace Household
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class object created
            HouseholdCensus hd = new HouseholdCensus();
            //Call functions
            hd.inputHouseholdInfo();
            hd.determineAssistance();
        }
    }
}
