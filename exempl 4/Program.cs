



int MyNumber = int.Parse(Console.ReadLine());

string a = "<";
string b = ">";
int min = 1;
int max = 100;
bool numnerFound = false;

for (int i = 0; i < 7; i++)
{
    var RandomComp = AskRandom(min, max);
    if (RandomComp == MyNumber)
    {
        Console.WriteLine("Computer win!");
        numnerFound = true;
        break;
    }

    string _anser2 = Console.ReadLine().Trim();

    if (_anser2 == a)
    {
        max = RandomComp;
    }
    else if (_anser2 == b)
    {
        min = RandomComp;
    }
    else 
    {
        Console.WriteLine("Invalid input!");
    }
}

if (!numnerFound) {
    Console.WriteLine("Computer lose!");
}

int AskRandom(int min, int max)
{
    Console.WriteLine($"Computer is searching from {min} to {max}...");
    Random random3 = new Random();
    int RandomComp3 = random3.Next(min, max);
    Console.WriteLine($"Computer thinks it's {RandomComp3}");
    return RandomComp3;
}
