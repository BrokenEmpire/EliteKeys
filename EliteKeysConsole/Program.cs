using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Diagnostics;

namespace EliteKeysConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var fileStream = new FileStream("C:\\Users\\dhr\\AppData\\Local\\Frontier Developments\\Elite Dangerous\\Options\\Bindings\\Custom.3.0.binds", FileMode.Open, FileAccess.Read))
            {
                using (var reader = XmlReader.Create(fileStream, new XmlReaderSettings
                {
                    Async = false,
                    IgnoreWhitespace = true,
                    IgnoreComments = true,
                    IgnoreProcessingInstructions = true
                }))
                {
                    while (reader.Read())
                    {

                        if (reader.IsStartElement() && !reader.IsEmptyElement && !reader.HasAttributes)
                        {
                            Debug.WriteLine(string.Format("<{0}>", reader.Name));
                        }

                        if (reader.HasAttributes)
                        {
                           
                            while (reader.MoveToNextAttribute())
                            {

                            }
                            // Move the reader back to the element node.
                            reader.MoveToElement();
                        }

                        if (reader.IsStartElement())
                        {
                            if (reader.IsEmptyElement)
                            {

                            }
                            else
                            {


                            }
                        }
                        else if (reader.NodeType == XmlNodeType.EndElement)
                        {


                        }
                        else if (reader.NodeType == XmlNodeType.Text)
                        {

                        }
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Program Complete");
        }
    }
}