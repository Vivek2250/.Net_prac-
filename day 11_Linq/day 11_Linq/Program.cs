using System.Xml.Linq;

namespace Linq_query
{
    class program
    {
        public static void Main(string[] args)
        {
            string[] names = { "Ram", "Anil", "Madhup", "Rekha", "Shruti", "Sneha", "Jiren" };


            //UsingLinq(names);
            //UsingLinqExtensions(names);
            //UsingLinqFunctions(names);
            //UsingAnonymousMethod(names);
            //LinqReadXML();
            //LinqXMLAddNode();
            LinqXMLDeleteNode();
        }
        //Using Linq Queries
        //private static void UsingLinq(string[] names)
        //{
        //    IEnumerable<string> query = from s in names         //for loop start
        //                                where s.Length >= 5
        //                                orderby s
        //                                select s.ToUpper();

        //    foreach(string str in query)
        //    {
        //        Console.WriteLine(str);
        //    }

        //    Console.ReadLine();
        //}

        //Using Linq Extensions
        //private static void UsingLinqExtensions(string[] names)
        //{
        //    IEnumerable<string> query = names
        //                                .Where(s => s.Length >= 5)
        //                                .OrderBy(s => s)
        //                                .Select(s => s.ToUpper());
        //    foreach (string str in query)
        //    {
        //        Console.WriteLine(str);
        //    }

        //}

        //Using Linq Functions
        //private static void UsingLinqFunctions(string[] names)
        //{
        //    Func<string, bool> filter = s => s.Length >= 5;
        //    Func<string, string> extract = s => s;
        //    Func<string, string> convert = s => s.ToUpper();

        //    IEnumerable<string> query = names.Where(filter)
        //                                       .OrderBy(extract)
        //                                        .Select(convert);
        //    foreach (string str in query)
        //    {
        //        Console.WriteLine(str);
        //    }

        //}

        //Using Anonymous method
        //private static void UsingAnonymousMethod(string[] names)
        //{
        //    Func<string, bool> filter = delegate (string s)
        //    {
        //        return s.Length >= 5;
        //    };

        //    Func<string, string> extract = delegate (string s)
        //    {
        //        return s;
        //    };

        //    Func<string, string> convert = delegate (string s)
        //    {
        //        return s.ToUpper();
        //    };

        //    IEnumerable<string> query = names.Where(filter)
        //        .OrderBy(extract)
        //        .Select(convert);

        //    foreach(string str in query)
        //    {
        //        Console.WriteLine(str);
        //    }
        //}

        // Using Linq in XML
        //public static void LinqReadXML()
        //{
        //    string myXML = @"<Departments>
        //                     <Department>Account</Department>
        //                     <Department>Sales</Department>
        //                     <Department>Pre-Sales</Department>
        //                    <Department>Marketing</Department>
        //                    </Departments>";

        //    XDocument xdoc = new XDocument();
        //    xdoc = XDocument.Parse(myXML);

        //    var result = xdoc.Element("Departments").Descendants();

        //    foreach(XElement item in result)
        //    {
        //        Console.WriteLine("Department Name:- " + item.Value);
        //    }

        //    Console.WriteLine("Press any key to continue!");
        //    Console.ReadLine();
        //}

        //public static void LinqXMLAddNode()
        //{
        //    string myXML = @"<Departments>
        //                     <Department>Account</Department>
        //                     <Department>Sales</Department>
        //                     <Department>Pre-Sales</Department>
        //                    <Department>Marketing</Department>
        //                    </Departments>";

        //    XDocument xdoc = new XDocument();
        //    xdoc = XDocument.Parse(myXML);

        //    //Add the element at last
        //    xdoc.Element("Departments").Add(new XElement("Department", "Finance"));

        //    //Add the element at first
        //    xdoc.Element("Departments").AddFirst(new XElement("Department", "Support"));


        //    var result = xdoc.Element("Departments").Descendants();

        //    foreach (XElement item in result)
        //    {
        //        Console.WriteLine("Department Name:- " + item.Value);
        //    }

        //    Console.WriteLine("Press any key to continue!");
        //    Console.ReadLine();
        //}

        private static void LinqXMLDeleteNode()
        {
            string myXML = @"<Departments>
                             <Department>Account</Department>
                             <Department>Sales</Department>
                             <Department>Pre-Sales</Department>
                            <Department>Marketing</Department>
                            </Departments>";

            XDocument xdoc = new XDocument();
            xdoc = XDocument.Parse(myXML);

            //Add the element at last
            xdoc.Element("Departments").Add(new XElement("Department", "Finance"));

            //Add the element at first
            xdoc.Element("Departments").AddFirst(new XElement("Department", "Support"));

            //Remove the element
            xdoc.Descendants().Where(s => s.Value == "Sales").Remove();


            var result = xdoc.Element("Departments").Descendants();

            foreach (XElement item in result)
            {
                Console.WriteLine("Department Name:- " + item.Value);
            }

            Console.WriteLine("Press any key to continue!");
            Console.ReadLine();
        }
    }
}