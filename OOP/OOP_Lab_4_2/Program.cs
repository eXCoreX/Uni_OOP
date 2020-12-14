// Converter to gif

using System;
using System.IO;
using System.Drawing;
using System.Text.RegularExpressions;
namespace OOP_Lab_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var imgFormatRegex = new Regex(@"^(gif)|(jpe?g)|(png)|(bmp)|(tiff?)$");

            var files = Directory.GetFiles(Directory.GetCurrentDirectory());
            foreach (var file in files)
            {
                var fileSplit = file.Split('.');
                try
                {
                    Bitmap bmp = new Bitmap(file);
                    bmp.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    bmp.Save(fileSplit[0] + "-mirrored.gif");
                    Console.WriteLine("Processed image {0}", file);
                }
                catch (ArgumentException)
                {
                    if (imgFormatRegex.IsMatch(fileSplit[1]))
                    {
                        Console.WriteLine("Can't open {0} as image, proceeding...", file);
                    }
                }
            }
        }
    }
}
