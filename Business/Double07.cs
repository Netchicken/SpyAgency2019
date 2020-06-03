using System;

namespace SpyAgency2019.Business
{
    class Double07 : Spy
    {
        public Double07()
        {
            Weapon = "Thermo Nuclear Device";
            KillAbility = "Absolute Devastation";
            Gadgets = "invisibilty and invulnerability Protection";
            Charmlevel = 7;
            CodeName = "Bond James Bond";

        }

        //How long since we last saw the spy
        public override double DaysSinceLastSeen(DateTime contactDate)
        {
            //TimeSpan ts = DateTime.Now - contactDate;
            //double LastSeen = ts.TotalDays;
            //LastSeen = Math.Round(LastSeen, 1);
            return 0;

        }
    }


}
