using Backend;

//Console.WriteLine("**** FACTORIAL ****");
//Console.WriteLine("ITERATIVE");
//Console.WriteLine($"0! = {Iterative.Factorial(0):N0}");
//Console.WriteLine($"1! = {Iterative.Factorial(1):N0}");
//Console.WriteLine($"2! = {Iterative.Factorial(2):N0}");
//Console.WriteLine($"5! = {Iterative.Factorial(5):N0}");
//Console.WriteLine($"20! = {Iterative.Factorial(20):N0}");

//Console.WriteLine("RECURSIVE");
//Console.WriteLine($"0! = {Recursive.Factorial(0):N0}");
//Console.WriteLine($"1! = {Recursive.Factorial(1):N0}");
//Console.WriteLine($"2! = {Recursive.Factorial(2):N0}");
//Console.WriteLine($"5! = {Recursive.Factorial(5):N0}");
//Console.WriteLine($"20! = {Recursive.Factorial(20):N0}");
//Console.WriteLine();

//Console.WriteLine("**** FIBONACCI ****");
//Console.WriteLine("ITERATIVE");
//for (int i = 0; i < 10; i++) Console.WriteLine($"f({i}) = {Iterative.Fibonaci(i):N0}");

//Console.WriteLine("RECURSIVE");
//for (int i = 0; i < 10; i++) Console.WriteLine($"f({i}) = {Recursive.Fibonaci(i):N0}");

Console.WriteLine("RECURSIVE");
Recursive.Hanoi(5, 'A', 'C', 'B');

Console.WriteLine("ITERATIVE");
Iterative.HanoiWithExplicitStack(5, 'A', 'C', 'B');
