using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Convert
    {
        public string line2;
        string firstName;
        string secondName;

        StreamWriter writer = new StreamWriter(@"c:\prod\web\out.txt");

        public void workFile()
        {
            using (StreamReader sr = new StreamReader(@"c:\prod\web\test.txt"))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string sub = line.Substring(0, 6);
                    line2 = line.Substring(6, 50);

                    switch (sub)
                    {
                        case "59001N":
                            test();
                            //report();
                            break;

                        default:
                          writer.WriteLine(line);
                          writer.Flush();
                            break;
                    }
                }
            }
                  
        }
        public void test() 
        {
            if (line2.Contains(" and "))
            {
                firstName = line2.Substring(0, line2.IndexOf(" and ") + 5);
                secondName = line2.Substring(line2.IndexOf(" and ") + 5);
                writer.WriteLine("59001N" + firstName);
                writer.WriteLine("59002N" + secondName);
                writer.Flush();
            }
            else if (line2.Contains(" & "))
            {
                firstName = line2.Substring(0, line2.IndexOf(" & ") + 3);
                secondName = line2.Substring(line2.IndexOf(" & ") + 3);
                writer.WriteLine("59001N" + firstName);
                writer.WriteLine("59002N" + secondName);
                writer.Flush();

            }
            else
            {
                firstName = line2.Substring(0, 30);
                writer.WriteLine("59001N" + firstName);
                writer.Flush();
   
            }
        
        }
        public void report()
        {
            if (line2.Contains(" and "))
            {
                firstName = line2.Substring(0, line2.IndexOf(" and ") + 5);
                secondName = line2.Substring(line2.IndexOf(" and ") + 5);
                writer.WriteLine(firstName);
                writer.WriteLine(secondName);
                writer.WriteLine(" ");
                writer.Flush();
            }
            else if (line2.Contains(" & "))
            {
                firstName = line2.Substring(0, line2.IndexOf(" & ") + 3);
                secondName = line2.Substring(line2.IndexOf(" & ") + 3);
                writer.WriteLine(firstName);
                writer.WriteLine(secondName);
                writer.WriteLine(" ");
                writer.Flush();

            }
            else
            {
                firstName = line2.Substring(0, 30);
                writer.WriteLine(firstName);
                writer.WriteLine(" ");
                writer.Flush();

            }

        }


    }
}
