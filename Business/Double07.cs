using System;

namespace SpyAgency.Business
{
    class Double07 : Spy
    {
        public Double07()
        {
            Weapon = "Thermo Nuclear Device";
            Charmlevel = 7;
            CodeName = "Bond James Bond";

        }


        //we never record when we last saw 007 therefore its always 0
        //override the default method in Spy
        public override double DaysSinceLastSeen(DateTime contactDate)
        {
            return 0;

        }
    }


}
