using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Document\n");
            Console.WriteLine("Enter the name of the document: ");
            string name = Console.ReadLine();
            Console.WriteLine("What content will be in this document: ");
            string content = Console.ReadLine();
            if (!name.EndsWith(".txt"))
            {
                name = name + ".txt";
            }
            try
            {
                using (StreamWriter sw = new StreamWriter(name))
                {
                    sw.Write(content);
                }
                Console.WriteLine("Wrote file " + name + " with " + content.Length + " characters"); 
            }
            catch (Exception ex)
            { 
            Console.WriteLine(ex); 
            }
        }
    }
}
