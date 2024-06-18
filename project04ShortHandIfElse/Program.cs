int time = DateTime.Now.Hour;
string result = (time < 18) ? "Good day." : "Good evening.";
Console.WriteLine(result);