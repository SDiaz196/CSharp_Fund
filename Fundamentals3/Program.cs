
// 1
static void PrintList(List<string> MyList)
{
    MyList.ForEach(item => Console.WriteLine(item));
}
List<string> TestStringList = new List<string>() { "Harry", "Steve", "Carla", "Jeanne" };
PrintList(TestStringList);

// 2
static void SumOfNumbers(List<int> IntList)
{
    Console.WriteLine(IntList.Sum());
}
List<int> TestIntList = new List<int>() { 2, 7, 12, 9, 3 };
SumOfNumbers(TestIntList);

// 3
static int FindMax(List<int> IntList)
{
    return IntList.Max();
}
List<int> TestIntList2 = new List<int>() { -9, 12, 10, 3, 17, 5 };
Console.WriteLine(FindMax(TestIntList2));

// 4
static List<int> SquareValues(List<int> IntList)
{
    return IntList.Select(item => item * item).ToList();
}
List<int> TestIntList3 = new List<int>() { 1, 2, 3, 4, 5 };
Console.WriteLine(string.Join(", ", SquareValues(TestIntList3)));

// 5
static int[] NonNegatives(int[] IntArray)
{
    return IntArray.Select(item => item < 0 ? 0 : item).ToArray();
}
int[] TestIntArray = new int[] { -1, 2, 3, -4, 5 };
Console.WriteLine(string.Join(", ", NonNegatives(TestIntArray)));

// 6
static void PrintDictionary(Dictionary<string, string> MyDictionary)
{
    Console.WriteLine(string.Join(", ", MyDictionary.Select(item => item.Key + ": " + item.Value)));
}
Dictionary<string, string> TestDict = new Dictionary<string, string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", "Money and intelligence");
PrintDictionary(TestDict);

// 7
static bool FindKey(Dictionary<string, string> MyDictionary, string SearchTerm)
{

    return MyDictionary.ContainsKey(SearchTerm);
}
Console.WriteLine(FindKey(TestDict, "RealName"));
Console.WriteLine(FindKey(TestDict, "Name"));

// 8
static Dictionary<string, int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    return Names.Select((name, idx) => new { Key = name, Value = Numbers[idx] }).ToDictionary(item => item.Key, item => item.Value);
}
List<string> keys = new List<string> { "Julie", "Harold", "James", "Monica" };
List<int> values = new List<int> { 6, 12, 7, 10 };
Dictionary<string, int> d2 = GenerateDictionary(keys, values);
Console.WriteLine(string.Join("\n", d2.Select(item => item.Key + ": " + item.Value)));
