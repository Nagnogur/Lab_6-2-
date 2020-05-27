using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_2_
{
    class SportComplex
    {
        public List<string> Services;
        public List<Client> Clients;
        public SportComplex()
        {
            string[] s = { "Swimming pool", "Fitness center", "Gym", "Massage", "Sauna" };
            Services = new List<string>(s);
        }
        public void AddService(string s)
        {
            Services.Add(s);
        }
        
        
        public void NewClient()
        {
            Console.WriteLine("Please, choose services. Currently we have:");
            foreach (string s in Services)
            {
                Console.Write(s + ", ");
            }
            int[] a = Console.ReadLine().Split().Select(s => int.Parse(s)).ToArray();
            Console.WriteLine("Now choose type: infinite; month; single.");
            int t = Convert.ToInt32(Console.ReadLine());
            Client client = new Client(a, t);
            Clients.Add(client);
        }
    }
}
