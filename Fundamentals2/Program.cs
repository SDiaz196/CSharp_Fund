// Three Basic Arrays
int[] Arr1 = new int[10];
for (int i = 0; i < 10; i++)
    Arr1[i] = i;

string[] Arr2 = new string[]{"Tim", "Martin", "Nikki", "Sara"};

bool[] Arr3 = new bool[10];
for (int i = 0; i < Arr3.Length; i++)
    Arr3[i] = i == 0 ? !Arr3[i]:!Arr3[i-1];

Array.ForEach(Arr1, Console.WriteLine);
Array.ForEach(Arr2, Console.WriteLine);
Array.ForEach(Arr3, Console.WriteLine);

// List of Flavors 
List<string> flavors = new List<string>{"Vanila", "Rocky Road", "Chocolate", "Neapolitan", "Salted Caramel"};
Console.WriteLine(flavors.Count);
Console.WriteLine(flavors[2]);
flavors.RemoveAt(2);
Console.WriteLine(flavors.Count);


// User Dictionary
Random rng = new Random();
Dictionary<string,string> user = new Dictionary<string, string>{};
foreach(var name in Arr2)
    user.Add(name,flavors[rng.Next(0,flavors.Count)]);
foreach (KeyValuePair<string, string> entry in user)
    Console.WriteLine($"{entry.Key} - {entry.Value}");