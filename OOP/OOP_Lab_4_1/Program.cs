// Exceptions lab

using System;
using System.IO;

namespace OOP_Lab_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int n = 0;
            try
            {
                using StreamWriter noFile = new StreamWriter("no_file.txt");
                using StreamWriter badData = new StreamWriter("bad_data.txt");
                using StreamWriter overflow = new StreamWriter("overflow.txt");
                for (int i = 10; i < 30; i++)
                {
                    int mulRes = 1;
                    try
                    {
                        using (StreamReader sr = File.OpenText(i + ".txt"))
                        {
                            mulRes *= int.Parse(sr.ReadLine());
                            mulRes *= int.Parse(sr.ReadLine());
                            try
                            {
                                int.Parse(sr.ReadLine());
                                throw new FormatException();
                            }
                            catch (ArgumentNullException)
                            {

                            }
                            catch (Exception)
                            {
                                throw new FormatException();
                            }
                        }
                        result += mulRes;
                        n++;
                    }
                    catch (FileNotFoundException)
                    {
                        noFile.WriteLine(i + ".txt");
                    }
                    catch (Exception ex) when (ex is ArgumentNullException
                                            || ex is FormatException)
                    {
                        badData.WriteLine(i + ".txt");
                    }
                    catch (OverflowException)
                    {
                        overflow.WriteLine(i + ".txt");
                    }
                }
                try
                {
                    Console.WriteLine("Mean: " + (result / (double)n));
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Not enought data");
                }
            }
            catch(UnauthorizedAccessException)
            {
                Console.WriteLine("Can't create or open file");
            }
        }
    }
}
