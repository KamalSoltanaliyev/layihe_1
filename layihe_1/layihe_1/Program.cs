using layihe_1;

GenericCustomList<int> generic = new();

generic.Add(1);
generic.Add(2);
generic.Add(3);
generic.Add(4);
generic.Add(5);
Console.WriteLine(generic.Count);
Console.WriteLine(generic.Capacity);