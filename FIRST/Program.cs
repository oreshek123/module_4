using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIRST.module;

namespace FIRST
{
    class Program
    {
        static List<string[]> getData(string data)
        {
            List<string[]> rw = new List<string[]>();

            foreach (string item in data.Replace("},", "}").Split('}'))
            {
                string[] parse = item.Split(',');
                foreach (var item2 in parse)
                {
                    string[] parse2 =
                        item2
                        .Replace("{\"", "")
                        .Replace("\"", "")
                        .Split(':')
                        ;
                    rw.Add(parse2);
                }
            }

            return rw;
        }

        static void Main(string[] args)
        {
            #region data
            string data = "{\"PIN\":\"2288\",\"BRAND\":\"Tayota\",\"NAME\":\"свеча зажигания!\\ BMW E30/E36/E46/E39/E34/E32, Opel Astra/Omega 1.6-4.0 82-98\",\"ARTID\":\"21943\",\"PARNR\":\"0000000000\",\"KEYZAK\":\"MOV0000075\",\"RVALUE\":\">20\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"VENSL\":\"98.0\",\"PRICE\":\"135.50\",\"WAERS\":\"RUB\",\"DLVDT\":\"20170602181500\",\"ANALOG\":\"\",\"MSG\":null,\"PriceTenge\":0,\"PriceRub\":0.0,\"ArtificialPrice\":null,\"ShowArtificialByDefault\":false,\"SupplierId\":0,\"Delivery\":null,\"DeliveryEx\":0,\"DeliveryGu\":0,\"Vkorg\":null,\"Kunnr\":null}," +
                "{\"PIN\":\"2299\",\"BRAND\":\"Subaru\",\"NAME\":\"свеча зажигания!\\ BMW E30/E36/E46/E39/E34/E32, Opel Astra/Omega 1.6-4.0 82-98\",\"ARTID\":\"21943\",\"PARNR\":\"0000000000\",\"KEYZAK\":\"MOV0000086\",\"RVALUE\":\">20\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"VENSL\":\"98.0\",\"PRICE\":\"142.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20170601181500\",\"ANALOG\":\"\",\"MSG\":null,\"PriceTenge\":0,\"PriceRub\":0.0,\"ArtificialPrice\":null,\"ShowArtificialByDefault\":false,\"SupplierId\":0,\"Delivery\":null,\"DeliveryEx\":0,\"DeliveryGu\":0,\"Vkorg\":null,\"Kunnr\":null}," +
                "{\"PIN\":\"2345\",\"BRAND\":\"Audi\",\"NAME\":\"свеча зажигания!\\ BMW E30/E36/E46/E39/E34/E32, Opel Astra/Omega 1.6-4.0 82-98\",\"ARTID\":\"21943\",\"PARNR\":\"0000000000\",\"KEYZAK\":\"MOV0000073\",\"RVALUE\":\">20\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"VENSL\":\"100.0\",\"PRICE\":\"138.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20170529181500\",\"ANALOG\":\"\",\"MSG\":null,\"PriceTenge\":0,\"PriceRub\":0.0,\"ArtificialPrice\":null,\"ShowArtificialByDefault\":false,\"SupplierId\":0,\"Delivery\":null,\"DeliveryEx\":0,\"DeliveryGu\":0,\"Vkorg\":null,\"Kunnr\":null},";
            #endregion
            List<Product> products = new List<Product>();

            Product product = new Product();
            foreach (string[] item in getData(data))
            {
                
                switch (item[0])
                {
                    case "PIN":
                        product.Pin = item[1];
                        break;
                    case "BRAND":
                        product.Brend = item[1];
                        break;
                    case "NAME":
                        product.Name = item[1];
                        break;
                   
                }
                products.Add(product);

            }
            
            Product.PrintInfo(products);
            Console.ReadLine();
            #region hlam

            //Console.WriteLine("Введите нужное количество продуктов");
            //int productCount;
            //Random random = new Random();
            //Int32.TryParse(Console.ReadLine(), out productCount);

            //for (int i = 0; i < productCount; i++)
            //{
            //    Product product = new Product()
            //    {
            //        Pin = random.Next(1000, 8000),
            //        Brend = "Tayota",
            //        Analog = true,
            //        Name = "lusichka"
            //    };
            #endregion
        }
    }
}
