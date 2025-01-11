namespace CommandPatternRefactoringGuru;

// As classes Receiver contêm alguma lógica de negócios importante. Elas sabem como
// executar todos os tipos de operações, associadas à execução de uma request.
// Na verdade, qualquer classe pode servir como um Receiver.
public class Receiver {
    public void DoSomething(string a) {
        Console.WriteLine($"Receiver: Trabalhando com ({a}.)");
    }

    public void DoSomethingElse(string b) {
        Console.WriteLine($"Receiver: Também trabalhando com ({b}.)");
    }
}
