using Fragnance.indexExamples;

namespace Fragnance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perfume perfume = new Perfume("Chanel No. 5", "Chanel", 100.0, "Bergamot, Lemon, Neroli", "Rose, Jasmine, Lily of the Valley", "Vetiver, Sandalwood, Musk");

            // Access perfume properties using integer indexer
            Console.WriteLine("Name: " + perfume[0]);
            Console.WriteLine("Brand: " + perfume[1]);
            Console.WriteLine("Price: " + perfume[2]);
            Console.WriteLine("Top Notes: " + perfume[3]);
            Console.WriteLine("Middle Notes: " + perfume[4]);
            Console.WriteLine("Base Notes: " + perfume[5]);

            // Modify perfume properties using integer indexer
            perfume[0] = "Dior J'adore";
            perfume[1] = "Dior";
            perfume[2] = 120.0;
            perfume[3] = "Bergamot, Mandarin, Jasmine";
            perfume[4] = "Rose, Orchid, Plum";
            perfume[5] = "Vanilla, Amber, Sandalwood";

            // Access perfume properties using string indexer
            Console.WriteLine("Name: " + perfume["name"]);
            Console.WriteLine("Brand: " + perfume["brand"]);
            Console.WriteLine("Price: " + perfume["price"]);
            Console.WriteLine("Top Notes: " + perfume["topnotes"]);
            Console.WriteLine("Middle Notes: " + perfume["middlenotes"]);
            Console.WriteLine("Base Notes: " + perfume["basenotes"]);

            // Modify perfume properties using string indexer
            perfume["name"] = "Dior Miss Dior";
            perfume["brand"] = "Dior";
            perfume["price"] = 150.0;
            perfume["topnotes"] = "Bergamot, Mandarin, Rose";
            perfume["middlenotes"] = "Peony, Jasmine, Lily of the Valley";
            perfume["basenotes"] = "Patchouli, Vanilla, Musk";
            //
        }
    }

}

