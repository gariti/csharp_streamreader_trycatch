using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ReadTextFileWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader myReader = new StreamReader("Values.txt");
                string line = "";

                while (line != null)
                {
                    line = myReader.ReadLine();
                    if (line != null)
                        Console.WriteLine(line);
                }

                myReader.Close();

            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Directory not found!");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something Broke: {0}", e.Message);
            }
            finally
            {
                //perform any cleanup to roll back the data or close connections to files, databases, networks, ect
            }
            Console.ReadLine();
        }
    }
}
