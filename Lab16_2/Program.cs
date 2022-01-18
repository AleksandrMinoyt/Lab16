using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using Lab16;


namespace Lab16_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Products[] ArrayProducts;
           

            using (StreamReader sr = new StreamReader("d:\\Products.json"))
            {
                string st = sr.ReadToEnd();
                ArrayProducts = JsonSerializer.Deserialize<Products[]>(st);
            }

            double maxPrice;
            int indexMaxPrice=0;

            if (ArrayProducts.Length > 0)
            {
                maxPrice = ArrayProducts[0].Price;
                indexMaxPrice = 0;

                for (int i = 0; i < ArrayProducts.Length; i++)
                {
                    if(ArrayProducts[i].Price> maxPrice)
                    {
                        indexMaxPrice = i;
                    }

                }

                Console.WriteLine("Самый дорогой товар {0}, про цене {1:f2}", ArrayProducts[indexMaxPrice].Name, ArrayProducts[indexMaxPrice].Price);
            }
            else
            {
                Console.WriteLine("В файле пусто");
            }

            Console.ReadKey();
        }
    }
}
