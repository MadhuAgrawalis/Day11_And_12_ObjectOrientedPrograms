using System;

namespace InventoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            FetchJsonForRice fetchJsonForRice = new FetchJsonForRice();

            Rice ricedata = fetchJsonForRice.ReadTheJsonFile("C:/Users/Hp/source/repos/InventoryManagement/new 1.json");

            Console.WriteLine(ricedata);

            for (int i = 0; i < ricedata.typesofRice.Count; i++)
            {
                Console.WriteLine(ricedata.typesofRice[i].name);
                Console.WriteLine(ricedata.typesofRice[i].weight);
                Console.WriteLine(ricedata.typesofRice[i].price);

                Console.WriteLine("Total Price of {0} = {1}", ricedata.typesofRice[i].name, ricedata.typesofRice[i].weight * ricedata.typesofRice[i].price);

            }
            Console.WriteLine("--------------------------------");
            for (int i = 0; i < ricedata.typesofPulses.Count; i++)
            {
                Console.WriteLine(ricedata.typesofPulses[i].name);
                Console.WriteLine(ricedata.typesofPulses[i].weight);
                Console.WriteLine(ricedata.typesofPulses[i].price);

                Console.WriteLine("Total Price of {0} = {1}", ricedata.typesofPulses[i].name, ricedata.typesofPulses[i].weight * ricedata.typesofPulses[i].price);
            }
            Console.WriteLine("--------------------------------");
            for (int i = 0; i < ricedata.typesofWheat.Count; i++)
            {
                Console.WriteLine(ricedata.typesofWheat[i].name);
                Console.WriteLine(ricedata.typesofWheat[i].weight);
                Console.WriteLine(ricedata.typesofWheat[i].price);

                Console.WriteLine("Total Price of {0} = {1}", ricedata.typesofWheat[i].name, ricedata.typesofWheat[i].weight * ricedata.typesofWheat[i].price);
            }
        }
    }
}