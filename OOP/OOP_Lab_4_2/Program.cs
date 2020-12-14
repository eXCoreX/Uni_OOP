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
            var imgFormatRegex = new Regex(@"^.((gif)|(jpe?g)|(png)|(bmp)|(tiff?))$", RegexOptions.IgnoreCase);

            var files = Directory.GetFiles(Directory.GetCurrentDirectory());
            foreach (var filePath in files)
            {
                try
                {
                    Bitmap bmp = new Bitmap(filePath);
                    bmp.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    bmp.Save(Path.GetFileNameWithoutExtension(filePath) + "-mirrored.gif");
                    Console.WriteLine("Processed image {0}", Path.GetFileName(filePath));
                }
                catch (ArgumentException)
                {
                    if (imgFormatRegex.IsMatch(Path.GetExtension(filePath)))
                    {
                        Console.WriteLine("Can't open {0} as image, proceeding...", Path.GetFileName(filePath));
                    }
                }
            }
        }
    }
}
