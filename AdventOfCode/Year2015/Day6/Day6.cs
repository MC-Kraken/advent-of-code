namespace Year2015.Day6;

public class Day6
{
    private class Coordinate
    {
        public string X { get; set; }
        public string Y { get; set; }
    }

    public void RenamePlz()
    {
        var currentDirectory = Directory.GetCurrentDirectory().Split("/bin").First();
        var filePath = Path.Combine(currentDirectory, "Day5/input.txt");
        var text = File.ReadAllLines(filePath);
    }

    // private List<Coordinate> GetCoordinates(Coordinate coord1, Coordinate coord2)
    // {
    //     
    // }
}
