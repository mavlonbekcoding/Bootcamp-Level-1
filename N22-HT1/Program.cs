using System.Threading.Channels;

List<int> list = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};

var tubson = list.Where(x => IsPrime(x)).OrderDescending();
foreach (var x in tubson)
{
    Console.WriteLine(x);
}

static bool IsPrime(int x)
{
    for(var i = 2; i < x; i++)
    {
        if(x % i == 0)
        {
            return false;
        }
    }
        return true;
}
