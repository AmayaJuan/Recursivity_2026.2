namespace Backend;

public class Iterative
{
    public static ulong Factorial(int n)
    {
        ulong result = 1;
        for (int i = 2; i <= n; i++) result *= (ulong)i;
        return result;
    }

    // 0, 1, 2, 3, 4, 5, 6, 7, 8, ......
    // 0, 1, 1, 2, 3, 5, 8, 13, .....
    public static ulong Fibonaci(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        ulong a = 0;
        ulong b = 1;
        ulong c = 0;
        for (int i = 2; i <= n; i++) 
        {
            c = a + b;
            a = b;
            b = c;
        }
        return c;
    }

    // Explicit-stack version: each frame remembers which step it is on.
    public static void HanoiWithExplicitStack(int n, char source, char target, char auxiliary)
    {
        var stack = new Stack<(int N, char From, char To, char Via, int Step)>();
        stack.Push((n, source, target, auxiliary, 0));

        while (stack.Count > 0)
        {
            var frame = stack.Pop();

            // Base case: an empty frame does nothing (equivalent to "return").
            if (frame.N == 0)
            {
                continue;
            }

            switch (frame.Step)
            {
                case 0:
                    // Re-push this frame so we come back to Step 1 later,
                    // then push the first recursive call on top of it.
                    stack.Push(frame with { Step = 1 });
                    stack.Push((frame.N - 1, frame.From, frame.Via, frame.To, 0));
                    break;
                case 1:
                    // The first recursive call has finished: do the real work.
                    Console.WriteLine($"Move disk {frame.N} from {frame.From} to {frame.To}");
                    // Come back for Step 2, then run the second recursive call.
                    stack.Push(frame with { Step = 2 });
                    stack.Push((frame.N - 1, frame.Via, frame.To, frame.From, 0));
                    break;
                case 2:
                    // Both recursive calls are done: this frame is finished.
                    break;
            }
        }
    }
}
