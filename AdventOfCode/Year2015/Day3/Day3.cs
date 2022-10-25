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
        var coordinateSanta = new Coordinate();
        var coordinateRoboSanta = new Coordinate();
        var count = 1;
        
        foreach (var move in text)
        {
            
            switch (move)
            {
                
                case '<' :
                    if (count % 2 == 0)
                    {
                        coordinateSanta.Y--; 
                    }
                    else
                    { 
                        coordinateRoboSanta.Y--;
                    }
                    break;
                case '>' :
                    if (count % 2 == 0)
                    {
                        coordinateSanta.Y++; 
                    }
                    else
                    { 
                        coordinateRoboSanta.Y++;
                    }
                    break;
                case '^' :
                    if (count % 2 == 0)
                    {
                        coordinateSanta.X++; 
                    }
                    else
                    { 
                        coordinateRoboSanta.X++;
                    }
                    break;
                case 'v' :
                    if (count % 2 == 0)
                    {
                        coordinateSanta.X--; 
                    }
                    else
                    { 
                        coordinateRoboSanta.X--;
                    }
                    break;
                    
            }

            var updatedCoordinate = new Coordinate();
            
            if (count % 2 == 0)
            {
                updatedCoordinate.X = coordinateSanta.X;
                updatedCoordinate.Y = coordinateSanta.Y;
            }
            else
            {
                updatedCoordinate.X = coordinateRoboSanta.X;
                updatedCoordinate.Y = coordinateRoboSanta.Y;
            }
            
            
            count++; 
            if(!coordinates.Any(c => c.X == updatedCoordinate.X && c.Y == updatedCoordinate.Y))
            {
                coordinates.Add(updatedCoordinate);   
            }
        }
        Console.WriteLine(coordinates.Count);
        return coordinates.Count;
    }
    
    
}