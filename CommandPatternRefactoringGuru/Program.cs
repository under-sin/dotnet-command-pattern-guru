using CommandPatternRefactoringGuru;
using CommandPatternRefactoringGuru.Commands;

Invoker invoker = new Invoker();
invoker.SetOnStart(new SimpleCommand("Olá!"));
Receiver receiver = new Receiver();
invoker.SetOnFinish(new ComplexCommand(receiver, "Enviar e-mail", "Salvar relatório"));

invoker.DoSomethingImportant();