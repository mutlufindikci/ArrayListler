using System;
using System.Collections;

namespace ArrayListler
{

    class Araba
    {

        public string marka { get; set; }
        public string model { get; set; }
        public int yil { get; set; }



    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            Araba araba = new Araba();
            araba.marka = "BMW";
            araba.model = "X3";
            araba.yil =2005;


            arrayList.Add("Araba");
            arrayList.Add(1232);
            arrayList.Add(true);
            arrayList.Add(araba.marka);
            arrayList.Add(araba.model);
            arrayList.Add(araba.yil);
            arrayList.Add(araba);


            foreach (var item in arrayList) 
            {

                Console.WriteLine(item.ToString());
            
            }

            Console.ReadKey();

        }
    }
}
