// RANDOM ARRAY

static int[] RandomArray()
{
    Random rand = new Random();
    int[] array = new int[10];
    int min = 26;
    int max = 4;
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(5, 26);
        sum = sum + array[i];
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    System.Console.WriteLine($"Min value is: {min}");
    System.Console.WriteLine($"Max value is: {max}");
    System.Console.WriteLine($"Sum of the random array is: {sum}");

    return array;
}

RandomArray();

System.Console.WriteLine("");
// COIN FLIP

static string Tosscoin()
{
    Random rand = new Random();
    string result = "";
    System.Console.WriteLine("Tossing a Coin!");
    int flip = rand.Next(2);
    if (flip == 0)
    {
        System.Console.WriteLine("Heads");
        result = "Heads";
    }
    else
    {
        System.Console.WriteLine("Tails");
        result = "tails";
    }

    return result;
}
Tosscoin();

static double TossMultipleCoins(int num)
{
    double result = 0;
    for (int i = 0; i < num; i++)
    {
        string flip = Tosscoin();
        if (flip == "Heads") {
            result++;
        }
    }
        return result / num;
}

System.Console.WriteLine(TossMultipleCoins(8));


System.Console.WriteLine("");
// NAMES

static List<string> Names() {
    string[] nameArray = {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
    List<string> names = new List<string>(nameArray);
    // Result array that will only contain strins longer than 5 characters
    List<string> result = new List<string>();

    foreach (string item in names) {
        if(item.Length > 5) {
            result.Add(item);
        }
    }

    return result;
}
// Consoles writes each string returned in the Names function
Names().ForEach(Console.WriteLine);




