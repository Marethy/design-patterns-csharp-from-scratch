using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento;

public class TextEditor
{
    public string Content{get;private set; } = "";
    public void  Type(string text) => Content += " " + text;

    // Save the current state inside a memento
    public EditorMemento Save() => new EditorMemento(Content);
    public void Restore(EditorMemento memento) => Content = memento.Content;
    public sealed class EditorMemento
    {
        internal string Content { get; }
        internal EditorMemento(string state) => Content = state;
    }
}
public class Caretaker
{
    private readonly Stack<TextEditor.EditorMemento> history = new();
    public void Backup(TextEditor editor) => history.Push(editor.Save());
    public void Undo(TextEditor editor)
    {
        if (history.Count == 0) return;
        var memento = history.Pop();
        editor.Restore(memento);
    }

}
