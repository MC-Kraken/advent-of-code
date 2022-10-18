namespace Year2015.Day3;

public class Day3
{
    public class Coordinate
    {
        public Coordinate()
        {
            X = 0;
            Y = 0;
        }
        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }
    }
    public static int HowManyHouses()
    {
        var currentDirectory = Directory.GetCurrentDirectory().Split("/bin").First();
        var filePath = Path.Combine(currentDirectory, "Day3/input.txt");
        var text = File.ReadAllText(filePath);
        
        
        var coordinates = new HashSet<Coordinate> { new() };
        var coordinate = new Coordinate();
        
        foreach (var move in text)
        {
            
            switch (move)
            {
                case '<' :
                    coordinate.Y--;
                    break;
                case '>' :
                    coordinate.Y++;
                    break;
                case '^' :
                    coordinate.X++;
                    break;
                case 'v' :
                    coordinate.X--;
                    break;
                    
            }

            var updatedCoordinate = new Coordinate(coordinate.X, coordinate.Y);
            if(!coordinates.Any(c => c.X == updatedCoordinate.X && c.Y == updatedCoordinate.Y))
            {
                coordinates.Add(updatedCoordinate);   
            }
        }
        Console.WriteLine(coordinates.Count);
        return coordinates.Count;
    }
    
    
}