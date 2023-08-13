using N21_HT1;

CustomList<int> myList = new CustomList<int>();
myList.Add(5);
myList.AddRange(new List<int> { 10, 15, 20 });
Console.WriteLine(myList.Contains(10)); // Output: True
Console.WriteLine(myList.IndexOf(15));  // Output: 2

int[] array = new int[4];
myList.CopyTo(array);
Console.WriteLine(string.Join(", ", array)); // Output: 5, 10, 15, 20

myList.Insert(1, 25);
myList.InsertRange(2, new List<int> { 30, 35 });
Console.WriteLine(string.Join(", ", myList.ToArray())); // Output: 5, 25, 30, 35, 10, 15, 20

myList.Remove(25);
myList.RemoveAt(3);
Console.WriteLine(string.Join(", ", myList.ToArray())); // Output: 5, 30, 35, 15, 20