using CommandPatternRefactoringGuru.Interfaces;

namespace CommandPatternRefactoringGuru;

public class Invoker {
    private ICommand _onStart = default!;
    private ICommand _onFinish = default!;

    public void SetOnStart(ICommand command) {
        _onStart = command;
    }

    public void SetOnFinish(ICommand command) {
        _onFinish = command;
    }

    public void DoSomethingImportant() {
        Console.WriteLine("Invoker: Alguém quer que algo seja feito antes de eu começar?");
        if (_onStart is ICommand) {
            _onStart.Execute();
        }
        
        Console.WriteLine("Invoker: ...fazendo algo realmente importante...");
        
        Console.WriteLine("Invoker: Alguém quer que algo seja feito depois que eu terminar?");
        if (_onFinish is ICommand) {
            _onFinish.Execute();
        }
    }
}
