var linkedList = new LinkedList<string>();
linkedList.Add("Yes");
linkedList.Add("No");
linkedList.Add("Maybe");
linkedList.Add("So");
linkedList.Add("Okay");
linkedList.Add("Thanks");

var target = linkedList.FindNodeByPosition(2);
Console.WriteLine($"Target Data: {target.Data}");
Console.WriteLine($"Total Count: {linkedList.Count()}");