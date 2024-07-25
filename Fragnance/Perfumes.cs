using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fragnance
{


    namespace indexExamples
    {
        public class Perfume
        {
            private string name;
            private string brand;
            private double price;
            private string topNotes;
            private string middleNotes;
            private string baseNotes;

            public Perfume(string name, string brand, double price, string topNotes, string middleNotes, string baseNotes)
            {
                this.name = name;
                this.brand = brand;
                this.price = price;
                this.topNotes = topNotes;
                this.middleNotes = middleNotes;
                this.baseNotes = baseNotes;
            }

            public string this[int index]
            {
                get
                {
                    if (index == 0)
                        return this.name;
                    else if (index == 1)
                        return this.brand;
                    else if (index == 2)
                        return this.price.ToString();
                    else if (index == 3)
                        return this.topNotes;
                    else if (index == 4)
                        return this.middleNotes;
                    else if (index == 5)
                        return this.baseNotes;
                    else
                        throw new IndexOutOfRangeException();
                }
                set
                {
                    if (index == 0)
                        this.name = value;
                    else if (index == 1)
                        this.brand = value;
                    else if (index == 2)
                        this.price = double.Parse(value);
                    else if (index == 3)
                        this.topNotes = value;
                    else if (index == 4)
                        this.middleNotes = value;
                    else if (index == 5)
                        this.baseNotes = value;
                    else
                        throw new IndexOutOfRangeException();
                }
            }

            public string this[string property]
            {
                get
                {
                    if (property == "name")
                        return this.name;
                    else if (property == "brand")
                        return this.brand;
                    else if (property == "price")
                        return this.price.ToString();
                    else if (property == "topnotes")
                        return this.topNotes;
                    else if (property == "middlenotes")
                        return this.middleNotes;
                    else if (property == "basenotes")
                        return this.baseNotes;
                    else
                        throw new ArgumentException($"Invalid property name: {property}");
                }
                set
                {
                    if (property == "name")
                        this.name = value;
                    else if (property == "brand")
                        this.brand = value;
                    else if (property == "price")
                        this.price = double.Parse(value);
                    else if (property == "topnotes")
                        this.topNotes = value;
                    else if (property == "middlenotes")
                        this.middleNotes = value;
                    else if (property == "basenotes")
                        this.baseNotes = value;
                    else
                        throw new ArgumentException($"Invalid property name: {property}");
                }
            }
        }
    }
}