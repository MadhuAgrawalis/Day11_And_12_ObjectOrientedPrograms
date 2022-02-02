using System;
using System.IO;

namespace InventoryManagement
{
    public class FetchJsonForRice
    {
        public object JsonConvert { get; private set; }

        public Rice ReadTheJsonFile(string Path)
        {
            using (StreamReader file = new StreamReader(Path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<Rice>(json);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return null;

                }
            }
        }
    }
}