namespace Backend;

public class Recursive
{
    // n! = 1,            if n = 0 (base)
    // n! = n * (n - 1)!, if n > 0 (recursive)
    public static ulong Factorial(int n) => n <= 1 ? 1 : (ulong)n * Factorial(n - 1);

    // f(0) = 0, f(1) = 1,         (base)
    // f(n) = f(n - 1) + f(n - 2)  (recursive)
    public static ulong Fibonaci(int n) => n <= 1 ? (ulong)n : Fibonaci(n - 1) + Fibonaci(n - 2);

    public static void Hanoi(int n, char source, char target, char auxiliary)
    {
        // Base case: no disks to move.
        if (n == 0) return;

        // Step 1: move the n - 1 smaller disks out of the may (source -> auxiliary).
        Hanoi(n - 1, source, auxiliary, target);

        // Step 2: move the largest disk directly (source -> target).
        Console.WriteLine($"Nove disk {n} from {source} to {target}");

        // Step 3: bring the n - 1 smaller disks on top of it (auxiliary -> target)
        Hanoi(n - 1, auxiliary, target, source);
    }
}
