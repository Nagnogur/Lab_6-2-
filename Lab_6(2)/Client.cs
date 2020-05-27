using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_2_
{
    class Client
    {
        bool health;
        public bool Health
        {
            get { return health; }
            set { health = value; }
        }

        public  List<Service> ClientCard = new List<Service>();
        public int TypeOfCard;

        public Client(int[] a, int type)
        {
            TypeOfCard = type;
            foreach (int i in a)
            {
                if (i == 1)
                {
                    Console.WriteLine("You must go to medical examination. Precede?");
                    string s = Console.ReadLine();
                    if (s == "Yes")
                    {
                        this.MedicalExamination();
                    }
                    else
                    {
                        Console.WriteLine("You are not allowed to enter swimming pool");
                        continue;
                    }
                }
                ClientCard.Add(new Service(i));
            }
        }
        public void MedicalExamination()
        {
            Console.WriteLine("Healthy");
            health = true;
        }
    }
}
