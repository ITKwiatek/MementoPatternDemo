using System;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var history = new History();
            var editor = new Editor();
            editor.SetContent("a");
            history.Push(editor.CreateState());
            
            editor.SetContent("ab");
            history.Push(editor.CreateState());

            editor.SetContent("abc");
            history.Push(editor.CreateState());

            editor.SetContent("abcd");

            Console.WriteLine($"Editor content before: {editor.GetContent()}");

            editor.Restore(history.Pop());

            Console.WriteLine($"Editor content after 1 pop: {editor.GetContent()}");

            editor.Restore(history.Pop());
            editor.Restore(history.Pop());
            editor.Restore(history.Pop());
            editor.Restore(history.Pop());
            editor.Restore(history.Pop());
            editor.Restore(history.Pop());
            editor.Restore(history.Pop());

            Console.WriteLine($"Editor content after 10 pop: {editor.GetContent()}");
        }
    }
}
