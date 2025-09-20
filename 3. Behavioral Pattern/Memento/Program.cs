using Memento;

var editor = new TextEditor();
var caretaker = new Caretaker();

editor.Type("Hello");
caretaker.Backup(editor);

editor.Type("World!");
Console.WriteLine(editor.Content); // Hello World!

caretaker.Undo(editor);
Console.WriteLine(editor.Content); // Hello