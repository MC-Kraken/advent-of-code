namespace Year2022.Day1;

public class Day1
{
    public static void GetElfCalories()
    {
        var currentDirectory = Directory.GetCurrentDirectory().Split("/bin").First();
        var filePath = Path.Combine(currentDirectory, "Day1/input.txt");
        var text = File.ReadAllLines(filePath);

        var sum = 0;
        var list = new List<int>();
        for (var i = 0; i < text.Length; i++)
        {
            if (text[i] == "")
            {
                list.Add(sum);
                sum = 0;
            }
            else
            {
                sum += int.Parse(text[i]);
            }
        }

        var highest = list.Max();
        Console.WriteLine(highest);
    }
}
