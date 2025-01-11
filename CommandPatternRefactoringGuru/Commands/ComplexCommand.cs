using CommandPatternRefactoringGuru.Interfaces;

namespace CommandPatternRefactoringGuru.Commands;

public class ComplexCommand : ICommand {
    private Receiver _receiver;
    private string _a;
    private string _b;

    public ComplexCommand(Receiver receiver, string a, string b) {
        _receiver = receiver;
        _a = a;
        _b = b;
    }

    public void Execute() {
        Console.WriteLine("ComplexCommand: Coisas complexas devem ser feitas por um objeto receiver.");
        _receiver.DoSomething(_a);
        _receiver.DoSomethingElse(_b);
    }
}
