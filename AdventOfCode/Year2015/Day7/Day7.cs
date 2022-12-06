namespace Year2015.Day7;

public static class Day7
{
    public static void DoBitwiseStuff()
    {
        decimal x = 123;
        decimal y = 123;

        Convert.ToInt16(x);
        var wires = new Dictionary<string, decimal>();

        var currentDirectory = Directory.GetCurrentDirectory().Split("/bin").First();
        var filePath = Path.Combine(currentDirectory, "Day6/input.txt");
        var text = File.ReadAllLines(filePath);
        IList<string> textCopy = text;

        while (textCopy.Count > 0)
        {
            for (int i = 0; i < textCopy.Count; i++)
            {
                var splitInstructions = textCopy[i].Split(" ");
                if (splitInstructions.Contains("NOT"))
                {
                    if (wires.ContainsKey(splitInstructions[1]))
                    {
                        wires.Add(splitInstructions[3], ~int.Parse(splitInstructions[1]));
                    }
                }
                else if (splitInstructions.Contains("AND"))
                {
                    if (wires.ContainsKey(splitInstructions[0]) && wires.ContainsKey(splitInstructions[2]))
                    {
                        wires.Add(splitInstructions[4], wires[splitInstructions[0]]);
                    }
                }
                else if (splitInstructions.Contains("OR"))
                {
                    
                }
                else if (splitInstructions.Contains("RSHIFT"))
                {
                }
                else if (splitInstructions.Contains("LSHIFT"))
                {
                }
                else
                {
                    wires.Add(splitInstructions[2], int.Parse(splitInstructions[0]));
                    textCopy.RemoveAt(i);
                }
            }
        }
    }
}