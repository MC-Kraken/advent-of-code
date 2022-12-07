namespace Year2022.Day6;

public static class Day6
{
    public static void GetMarkerPart1()
    {
        var currentDirectory = Directory.GetCurrentDirectory().Split("/bin").First();
        var filePath = Path.Combine(currentDirectory, "Day6/input.txt");
        var text = File.ReadAllText(filePath);

        var marker = 0;
        var markerFound = false;
        
        while (!markerFound)
        {
            for (var i = 0; i < text.Length; i++)
            {
                var first = text[i];
                var second = text[i + 1];
                var third = text[i + 2];
                var fourth = text[i + 3];

                var array = new [] { first.ToString(), second.ToString(), third.ToString(), fourth.ToString() };
                var count = array.Distinct().Count();
                
                if (count == 4)
                {
                    markerFound = true;
                    marker = i + 4;
                    break;
                }
            }
        }
        
        Console.WriteLine(marker);
    }
    
    public static void GetMarkerPart2()
    {
        var currentDirectory = Directory.GetCurrentDirectory().Split("/bin").First();
        var filePath = Path.Combine(currentDirectory, "Day1/input.txt");
        var text = File.ReadAllText(filePath);

        var marker = 0;
        var markerFound = false;
        
        while (!markerFound)
        {
            for (var i = 0; i < text.Length; i++)
            {
                var list = new List<string>();

                for (var j = i; j < i + 14; j++)
                {
                    list.Add(text[j].ToString());
                }

                var count = list.Distinct().Count();
                
                if (count == 14)
                {
                    markerFound = true;
                    marker = i + 14;
                    break;
                }
            }
        }
        
        Console.WriteLine(marker);
    }
}
