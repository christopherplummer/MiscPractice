var linkedList = new LinkedList<string>();
linkedList.Add("Yes");
linkedList.Add("No");
linkedList.Add("Maybe");
linkedList.Add("So");
linkedList.Add("Okay");
linkedList.Add("Thanks");

DateTime date = DateTime.Now;
int hourRemainder = date.Hour % 6;
    
var target = linkedList.FindNodeByPosition(hourRemainder);
Console.WriteLine($"Target Data: {target.Data}");
Console.WriteLine($"Total Count: {linkedList.Count()}");