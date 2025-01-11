namespace CommandPatternRefactoringGuru;

public class Receiver {
    public void DoSomething(string a) {
        Console.WriteLine($"Receiver: Trabalhando com ({a}.)");
    }

    public void DoSomethingElse(string b) {
        Console.WriteLine($"Receiver: Também trabalhando com ({b}.)");
    }
}
