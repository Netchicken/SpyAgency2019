﻿using System;

namespace SpyAgency.Business
{
    public class Spy : ISpy
    {
        public string CodeName { get; set; }
        public Agency Agency { get; set; } //Aggregation
        public string DateLastSeen { get; set; }
        public string Weapon { get; set; }
        public int Charmlevel { get; set; }


        //Constructor with our single spy's abilities
        public Spy()
        {
            Agency = new Agency();
            Weapon = "Rubberband";
            Charmlevel = 1;
            CodeName = "Rogue Killer";
        }



        //Methods

        //how old is the Spy
        public double YearsOld(DateTime born)
        {
            TimeSpan ts = DateTime.Now - born;
            double age = ts.TotalDays / 365;
            age = Math.Round(age, 1);
            return age;
        }

        //How long since we last saw the spy
        public virtual double DaysSinceLastSeen(DateTime contactDate)
        {
            TimeSpan ts = DateTime.Now - contactDate;
            double LastSeen = ts.TotalDays;
            LastSeen = Math.Round(LastSeen, 1);
            return LastSeen;

        }
        //where does the Spy live
        public string Home()
        {
            return "Park Lane";

        }






    }
}
