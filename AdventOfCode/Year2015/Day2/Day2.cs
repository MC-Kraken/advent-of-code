using System.Reflection.Metadata.Ecma335;

namespace Year2015.Day2;

public class Day2
{

    public static int HowMuchWrappingPaper()
    {
        int totalSquareFeet = 0; 
        
        var currentDirectory = Directory.GetCurrentDirectory().Split("/bin").First();
        var filePath = Path.Combine(currentDirectory, "Day2/input.txt");
        var text = File.ReadAllLines(filePath);

        foreach (var line in text)
        {
            var box = line.Split("x");
            var l = int.Parse(box[0]);
            var w = int.Parse(box[1]);
            var h = int.Parse(box[2]);

            var a = 2*l*w;
            var b = 2*w*h;
            var c = 2*h*l;
            
            var smallestSide = Math.Min(Math.Min(a, b), c)/2;
            var surfaceArea = a + b + c + smallestSide;
            
            totalSquareFeet += surfaceArea;
        }
        Console.WriteLine(totalSquareFeet);
        return totalSquareFeet;
    }
    
    public static int HowMuchRibbon()
    {
        int totalFeet = 0; 
        
        var currentDirectory = Directory.GetCurrentDirectory().Split("/bin").First();
        var filePath = Path.Combine(currentDirectory, "Day2/input.txt");
        var text = File.ReadAllLines(filePath);

        foreach (var line in text)
        {
            var box = line.Split("x");
            var l = int.Parse(box[0]);
            var w = int.Parse(box[1]);
            var h = int.Parse(box[2]);

            var sides = new int[] {l, w, h};
            Array.Sort(sides);

            var ribbon = (sides[0] * 2) + (sides[1] * 2); 
            var bow = l * w * h;
            totalFeet += ribbon + bow;
        }
        Console.WriteLine(totalFeet);
        return totalFeet;
    }
}
