using System;
using System.Collections.Generic;

namespace RandallsCarLot
{
    class Program
    {
        static void Main (string[] args)
        {
            List<Dictionary<string, Dictionary<string, string>>> vehicles = new List<Dictionary<string, Dictionary<string, string>>> ();

            Dictionary<string, Dictionary<string, string>> sale = new Dictionary<string, Dictionary<string, string>> ();

            Dictionary<string, string> vehicle = new Dictionary<string, string> ();
            vehicle.Add ("year", "2008");
            vehicle.Add ("model", "Damfresh");
            vehicle.Add ("make", "Biotraxquote");
            vehicle.Add ("color", "sky magenta");
            Dictionary<string, string> sales_agent = new Dictionary<string, string> ();
            sales_agent.Add ("mobile", "(896) 478-6975");
            sales_agent.Add ("last_name", "Botsford");
            sales_agent.Add ("first_name", "Shaina");
            Dictionary<string, string> credit = new Dictionary<string, string> ();
            credit.Add ("credit_provider", "J.P.Morgan Chase & Co");
            credit.Add ("account", "601109582720302");

            sale.Add ("vehicle", vehicle);
            sale.Add ("sales_agent", sales_agent);
            sale.Add ("credit", credit);

            vehicles.Add (sale);

            Dictionary<string, Dictionary<string, string>> sale2 = new Dictionary<string, Dictionary<string, string>> ();

            Dictionary<string, string> vehicle2 = new Dictionary<string, string> ();
            vehicle2.Add ("year", "2010");
            vehicle2.Add ("model", "Hotquadtrax");
            vehicle2.Add ("make", "Transtintechno");
            vehicle2.Add ("color", "robin egg blue");
            Dictionary<string, string> sales_agent2 = new Dictionary<string, string> ();
            sales_agent2.Add ("mobile", "562.300.2912");
            sales_agent2.Add ("last_name", "Davis");
            sales_agent2.Add ("first_name", "Gerardo");
            Dictionary<string, string> credit2 = new Dictionary<string, string> ();
            credit2.Add ("credit_provider", "PNC Financial Services");
            credit2.Add ("account", "34578280562836");

            sale2.Add ("vehicle", vehicle2);
            sale2.Add ("sales_agent", sales_agent2);
            sale2.Add ("credit", credit2);

            vehicles.Add (sale2);

            foreach (Dictionary<string, Dictionary<string, string>> saleDict in vehicles)
            {
                foreach (KeyValuePair<string, Dictionary<string, string>> salePair in saleDict)
                {
                    Console.WriteLine (salePair.Key);
                    foreach (KeyValuePair<string, string> section in salePair.Value)
                    {
                        Console.WriteLine ($"{section.Key}: {section.Value}");
                    }
                }
            }

        }
    }
}