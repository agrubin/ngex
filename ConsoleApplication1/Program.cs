using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static List<Name> names;
        class Name
        {
            // Fields...
            private string _Surname;
            private string _First;

            public string first
            {
                get { return _First; }
                set
                {
                    _First = value;
                }
            }

            public string surname
            {
                get { return _Surname; }
                set
                {
                    _Surname = value;
                }
            }

            public override string ToString()
            {
                return first + " " + surname;
            }

            /// <summary>
            /// Initializes a new instance of the <see cref="Name"/> class.
            /// </summary>
            /// <param name="first"></param>
            /// <param name="surname"></param>
            public Name(string first, string surname)
            {
                _Surname = surname;
                _First = first;
            }

            /// <summary>
            /// Private default constructor of the <see cref="Name"/> class.
            /// No empty names permitted upon construction.
            /// </summary>
            private Name()
            {
            }
        }
        static void DeleteName(string first, string surname)
        {
            foreach(Name name in names)
            {
                if (!String.Equals(name.surname, surname, StringComparison.OrdinalIgnoreCase)) continue;
                if (!String.Equals(name.first, first, StringComparison.OrdinalIgnoreCase)) continue;
                names.Remove(name);
                break;
            }
        }

        static void InsertName(string first, string surname)
        {
            names.Insert(0, new Name(first, surname));
            SortNames();
        }
        static void SortNames()
        {
            Comparison<Name> compname = new Comparison<Name>
                 ((x, y) => { return String.Compare(x.first + x.surname, y.first + y.surname, true); });

            names.Sort(compname);
        }

        static void OutputNames(string header)
        {
            Console.WriteLine("\n" + header + "\n");

            foreach (Name name in names)
            {
                Console.WriteLine(name.ToString());
            }
        }

        static void Main(string[] args)
        {
            Func<int> foo = ()=>6;
            int j = foo.Invoke();

            Name[] namearray =
            {
				new Name("ahmet", "tas"),
				new Name("al", "rubin"),
				new Name("al", "smith"),
				new Name("bob", "goldberg"),
				new Name("steph", "frank"),
				new Name("harry", "frank")
		    };

            names = namearray.ToList<Name>();

            SortNames();
            OutputNames("Initial sorted array");
            InsertName("bob", "Jones");
            InsertName("HARvey", "Jones");
            InsertName("BOB", "Jones");
            InsertName("al", "moron");
            OutputNames("After insert");
            DeleteName("BOB", "Jones");
            OutputNames("After delete");

            namearray = names.ToArray();
        }
    }
}
