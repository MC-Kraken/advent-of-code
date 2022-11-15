using System.Reflection.Metadata.Ecma335;

namespace Year2015.Day6;

public class Day6
{
    private static Dictionary<string, bool> Lights = new Dictionary<string, bool>();
    public static void lightshow()
    {
        var currentDirectory = Directory.GetCurrentDirectory().Split("/bin").First();
        var filePath = Path.Combine(currentDirectory, "Day6/input.txt");
        var text = File.ReadAllLines(filePath);

        
        string? startingLightCoord;
        string? endingLightCoord;
        

        foreach (var instruction in text)
        {
            var light = instruction.Split(" ");
            if (instruction.Contains("on"))
            {
                var start = light[2];
                var end = light[4];
                LoopThrough(start, end, "on");

            }
            else if (instruction.Contains("off"))
            {
                var start = light[2];
                var end = light[4];
                LoopThrough(start, end, "off");
            }
            else if (instruction.Contains("toggle"))
            {
                var start = light[1];
                var end = light[3];
                LoopThrough(start, end, "toggle");
            }
        }

        var lightsOn = 0;
        foreach (var light in Lights)
        {
            if (light.Value)
            {
                lightsOn++;
            }
        }
        Console.WriteLine(lightsOn);
    }

    private static void LoopThrough(string startCoord, string endCoord, string instruction)
    {
        var startX = int.Parse(startCoord.Split(",")[0]);
        var startY = int.Parse(startCoord.Split(",")[1]);
        var endX = int.Parse(endCoord.Split(",")[0]);
        var endY = int.Parse(endCoord.Split(",")[1]);

        for (var i = startX; i <= endX; i++)
        {
            for (var j = startY; j <= endY; j++)
            {
                var coord = i + "," + j;
                if (Lights.ContainsKey(coord))
                {
                    switch(instruction)
                    {
                        case "on":
                            Lights[coord] = true;
                            break;
                        case "off":
                            Lights[coord] = false;
                            break;
                        case "toggle":
                            Lights[coord] = !Lights[coord];
                            break;
                    }
                }
                else
                {
                    switch(instruction)
                    {
                        case "on":
                            Lights.Add(coord, true);
                            break;
                        case "off":
                            Lights.Add(coord, false);
                            break;
                        case "toggle":
                            Lights.Add(coord, true);
                            break;
                    }
                }
            }
        }

    }
    
    
}
