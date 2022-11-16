using System.Reflection.Metadata.Ecma335;

namespace Year2015.Day6;

public class Day6
{
    private static Dictionary<string, bool> Lights = new Dictionary<string, bool>();
    private static Dictionary<string, int> LightsPart2 = new Dictionary<string, int>();
    public static void Lightshow()
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
    public static void LightshowPart2()
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
                LoopThroughPart2(start, end, "on");

            }
            else if (instruction.Contains("off"))
            {
                var start = light[2];
                var end = light[4];
                LoopThroughPart2(start, end, "off");
            }
            else if (instruction.Contains("toggle"))
            {
                var start = light[1];
                var end = light[3];
                LoopThroughPart2(start, end, "toggle");
            }
        }

        var lightBrightness = 0;
            foreach (var light in LightsPart2)
            {
                lightBrightness += light.Value;
            }
        Console.WriteLine(lightBrightness);
    }
    
    private static void LoopThroughPart2(string startCoord, string endCoord, string instruction)
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
                if (LightsPart2.ContainsKey(coord))
                {
                    switch(instruction)
                    {
                        case "on":
                            LightsPart2[coord] = LightsPart2[coord]+=1;
                            break;
                        case "off":
                            if (LightsPart2[coord] != 0)
                            {
                                LightsPart2[coord] = LightsPart2[coord]-=1;
                            }
                            break;
                        case "toggle":
                            LightsPart2[coord] = LightsPart2[coord]+=2;
                            break;
                    }
                }
                else
                {
                    switch(instruction)
                    {
                        case "on":
                            LightsPart2.Add(coord, 1);
                            break;
                        case "off":
                            LightsPart2.Add(coord, 0);
                            break;
                        case "toggle":
                            LightsPart2.Add(coord, 2);
                            break;
                    }
                }
            }
        }

    }
    
}