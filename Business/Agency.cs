namespace SpyAgency.Business
{
    public class Agency
    {
        //properties
        public string Country { get; set; }
        public string AgencyName { get; set; }
        public int NumberOfAgents { get; set; }

        //constructor
        public Agency()
        {
            Country = "UK";
            AgencyName = "MI6";
            NumberOfAgents = 0;

        }


    }
}
