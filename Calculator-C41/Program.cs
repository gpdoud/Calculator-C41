
var stack = new Stack<double>();

var entry = string.Empty;

var answer = string.Empty;
Console.Write("Enter a RPN statement: ");
answer = Console.ReadLine();

var operands = answer.Split(",");

foreach(var op in operands) {
    double n;
    var isNumber = double.TryParse(op, out n);
    if(isNumber) {
        stack.Push(n);
        continue;
    }
    var n1 = stack.Pop();
    var n2 = stack.Pop();
    var result = op switch {
        "+" => n2 + n1,
        "-" => n2 - n1,
        "*" => n2 * n1,
        "/" => n2 / n1,
        "^" => Math.Pow(n2, n1)
    };
    stack.Push(result);
}
var final = stack.Pop();
Console.WriteLine(final);









//do {
//    if(answer.ToLower() == "c") {
//        stack.Clear();
//        Console.WriteLine("Cleared");
//    } else if(answer == "+") {
//        int n1 = stack.Pop();
//        int n2 = stack.Pop();
//        Console.WriteLine(n1 + n2);
//        stack.Push(n1 + n2);
//    } else if(answer == "-") {
//        int n1 = stack.Pop();
//        int n2 = stack.Pop();
//        Console.WriteLine(n2 - n1);
//        stack.Push(n2 - n1);
//    } else if(answer == "*") {
//        int n1 = stack.Pop();
//        int n2 = stack.Pop();
//        Console.WriteLine(n1 * n2);
//        stack.Push(n1 * n2);
//    } else if(answer == "/") {
//        int n1 = stack.Pop();
//        int n2 = stack.Pop();
//        Console.WriteLine(n2 / n1);
//        stack.Push(n2 / n1);
//    } else {
//        int n = Convert.ToInt32(answer);
//        stack.Push(n);
//    }
//    Console.Write("Enter a number, operator, C to clear or X to quit: ");
//    answer = Console.ReadLine();
//} while(answer.ToLower() != "x");