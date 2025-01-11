using CommandPatternRefactoringGuru.Interfaces;

namespace CommandPatternRefactoringGuru.Commands;

// No entanto, alguns comandos podem delegar operações mais complexas a outros objetos, chamados "receivers".
public class ComplexCommand : ICommand {
    private Receiver _receiver;

    // Dados de contexto, necessários para iniciar os métodos do receptor.
    private string _a;
    private string _b;

    // Comandos complexos podem aceitar um ou vários objetos receptores junto com quaisquer dados de contexto 
    // por meio do construtor.
    public ComplexCommand(Receiver receiver, string a, string b) {
        _receiver = receiver;
        _a = a;
        _b = b;
    }
    
    // Os comandos podem ser delegados a qualquer método de um receptor.
    public void Execute() {
        Console.WriteLine("ComplexCommand: Coisas complexas devem ser feitas por um objeto receiver.");
        _receiver.DoSomething(_a);
        _receiver.DoSomethingElse(_b);
    }
}
