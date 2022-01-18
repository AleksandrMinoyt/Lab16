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

namespace Lab16
{
    class Program
    {
        static void Main(string[] args)
        {
            const int countProducts = 5;

            Console.WriteLine("Введите продукты:");

            Products[] ArrayProducts = new Products[countProducts];

            //ArrayProducts[0] = new Products(1, "Печенье", 40.5);
            //ArrayProducts[1] = new Products(2, "Молоко", 71.3);
            //ArrayProducts[2] = new Products(3, "Сырок Дружба", 10);
            //ArrayProducts[3] = new Products(4, "Чай со слоном", 200);
            //ArrayProducts[4] = new Products(5, "Яблоки молодильные", 500.84);

            for (int i = 0; i < countProducts; i++)
            {
                Console.WriteLine("Введите код товара");
                int code = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите наименование товара");
                string name = Console.ReadLine();
                Console.WriteLine("Введите цену товара");
                double price = Convert.ToDouble(Console.ReadLine());
                ArrayProducts[i] = new Products(code, name, price);
            }

            JsonSerializerOptions jsonOptions = new JsonSerializerOptions();
            jsonOptions.Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic);

            using (StreamWriter sr = new StreamWriter("d:\\Products.json", false))
            {
                sr.WriteLine(JsonSerializer.Serialize(ArrayProducts, jsonOptions));
            }
        }
    }
}

