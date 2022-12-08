namespace Year2022.Day1;

public class Day1
{
    public static void GetElfCalories()
    {
        var currentDirectory = Directory.GetCurrentDirectory().Split("/bin").First();
        var filePath = Path.Combine(currentDirectory, "Day1/input.txt");
        var text = File.ReadAllLines(filePath);
        
        
    }
}
