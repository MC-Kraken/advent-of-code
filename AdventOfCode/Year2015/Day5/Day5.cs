namespace Year2015.Day5;

public static class Day5
{
    public static void GetVowelsPart1()
    {
        var currentDirectory = Directory.GetCurrentDirectory().Split("/bin").First();
        var filePath = Path.Combine(currentDirectory, "Day5/input.txt");
        var text = File.ReadAllLines(filePath);
      
        var vowelList = new List<char> { 'a', 'e', 'i', 'o', 'u' };
        var niceStrings = 0;

        foreach (var line in text)
        {
            var invalidString = false;
            var doubles = false;
            var vowels = 0;
            var previousChar = '0';
            
            foreach (var character in line)
            {
                if (previousChar == 'a' && character == 'b')
                {
                    invalidString = true;
                    break;
                }
                if (previousChar == 'c' && character == 'd')
                {
                    invalidString = true;
                    break;
                }
                if (previousChar == 'p' && character == 'q')
                {
                    invalidString = true;
                    break;
                }
                if (previousChar == 'x' && character == 'y')
                {
                    invalidString = true;
                    break;
                }

                if (vowelList.Contains(character))
                {
                    vowels += 1;
                }

                if (character == previousChar)
                {
                    doubles = true;
                }
                
                
                previousChar = character;
            }
            
            if (vowels >= 3 && doubles && !invalidString)
            {
                niceStrings += 1;
            }
        }
        
        Console.WriteLine(niceStrings);
    }
    
    public static void GetVowelsPart2()
    {
        var currentDirectory = Directory.GetCurrentDirectory().Split("/bin").First();
        var filePath = Path.Combine(currentDirectory, "Day5/input.txt");
        var text = File.ReadAllLines(filePath);
      
        var niceStrings = 0;

        foreach (var line in text)
        {
            var prePreChar = '0';
            var preChar = '1';
            var twoPairs = 0;
            var repeat = 0;
            
            foreach (var character in line)
            {
                if (character == prePreChar)
                {
                    repeat += 1;
                }

                var substring = preChar + character.ToString();
                var timeOfRepeat = line.Split(substring);

                if (timeOfRepeat.Length > 2)
                {
                    twoPairs += 1;
                }

                prePreChar = preChar;
                preChar = character;
            }

            if (twoPairs >= 2 && repeat > 0)
            {
                niceStrings += 1;
            }
        }
        
        Console.WriteLine(niceStrings);
    }
}
