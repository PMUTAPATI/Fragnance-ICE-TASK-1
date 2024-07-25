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

            public object this[int index]
            {
                get
                {
                    if (index == 0)
                        return this.name;
                    else if (index == 1)
                        return this.brand;
                    else if (index == 2)
                        return this.price;
                    else if (index == 3)
                        return this.topNotes;
                    else if (index == 4)
                        return this.middleNotes;
                    else if (index == 5)
                        return this.baseNotes;
                    else
                        return null;
                }
                set
                {
                    if (index == 0)
                        this.name = (string)value;
                    else if (index == 1)
                        this.brand = (string)value;
                    else if (index == 2)
                        this.price = (double)value;
                    else if (index == 3)
                        this.topNotes = (string)value;
                    else if (index == 4)
                        this.middleNotes = (string)value;
                    else if (index == 5)
                        this.baseNotes = (string)value;
                }
            }

            public object this[string attrName]
            {
                get
                {
                    if (attrName.ToLower() == "name")
                        return this.name;
                    else if (attrName.ToLower() == "brand")
                        return this.brand;
                    else if (attrName.ToLower() == "price")
                        return this.price;
                    else if (attrName.ToLower() == "topnotes")
                        return this.topNotes;
                    else if (attrName.ToLower() == "middlenotes")
                        return this.middleNotes;
                    else if (attrName.ToLower() == "basenotes")
                        return this.baseNotes;
                    else
                        return null;
                }
                set
                {
                    if (attrName.ToLower() == "name")
                        this.name = (string)value;
                    else if (attrName.ToLower() == "brand")
                        this.brand = (string)value;
                    else if (attrName.ToLower() == "price")
                        this.price = (double)value;
                    else if (attrName.ToLower() == "topnotes")
                        this.topNotes = (string)value;
                    else if (attrName.ToLower() == "middlenotes")
                        this.middleNotes = (string)value;
                    else if (attrName.ToLower() == "basenotes")
                        this.baseNotes = (string)value;
                }
            }
        }
    }
}