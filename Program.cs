using System;
using System.Collections.Generic;

namespace List_T
{
    class Program
    {
        static void Main()
        {

            List<string> stringList = new List<string>();

            stringList.Add("Première chaîne");
            stringList.Add("Deuxième chaîne");
            stringList.Add("Troisième chaîne");

            stringList.RemoveAt(0);

            stringList.Remove("Troisième chaîne");

            stringList[0] = "Chaîne modifiée";

            Console.WriteLine("Contenu de la liste après manipulation :");
            foreach (string str in stringList)
            {
                Console.WriteLine(str);
            }
        }
    }
}
