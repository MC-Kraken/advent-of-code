namespace Year2015.Day1;

public static class Day1
{
    private static int _floor;
    private static int _position;

    public static void GetSantaFloor()
    {
        var currentDirectory = Directory.GetCurrentDirectory().Split("/bin").First();
        var filePath = Path.Combine(currentDirectory, "Day1/input.txt");
        var text = File.ReadAllText(filePath);

        foreach (var parenthesis in text)
        {
            _position++;

            if (parenthesis == '(')
            {
                _floor += 1;
            }

            if (parenthesis == ')')
            {
                _floor -= 1;
            }

            if (_floor == -1)
            {
                Console.WriteLine(_position);
            }
        }

        Console.WriteLine(_floor);
    }
}