using CommandPatternRefactoringGuru.Interfaces;

namespace CommandPatternRefactoringGuru.Commands;

// Alguns comandos podem implementar operações simples por conta própria.
public class SimpleCommand : ICommand {
    private string _payload = string.Empty;

    public SimpleCommand(string payload) {
        _payload = payload;
    }

    public void Execute() {
        Console.WriteLine($"SimpleCommand: Veja, eu posso fazer coisas simples como imprimir ({_payload})");
    }
}
