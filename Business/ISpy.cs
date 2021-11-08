using System;

namespace SpyAgency.Business
{
    public interface ISpy
    {
        Agency Agency { get; set; }
        int Charmlevel { get; set; }
        string CodeName { get; set; }
        string DateLastSeen { get; set; }
        string Gadgets { get; set; }
        string KillAbility { get; set; }
        string Weapon { get; set; }

        double DaysSinceLastSeen(DateTime contactDate);
        string Home();
        double YearsOld(DateTime born);

    }
}
