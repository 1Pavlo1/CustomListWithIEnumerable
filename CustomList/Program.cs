using CustomList;

var intList = new CustomList<int>();

intList.Add(1);
intList.Add(2);
intList.Add(3);
intList.Add(4);
intList.Add(5);

for (var i = 0; i < intList.Count; i++)
{
    Console.WriteLine(intList[i]);
}

foreach (var i in intList)
{
    Console.WriteLine(i);
}