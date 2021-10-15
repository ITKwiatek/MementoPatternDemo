using System;

namespace MementoPattern
{
    public class EditorState
    {
        private readonly string content;

        public EditorState(string content)
        {
            this.content = content;
        }

        internal string GetContent()
        {
            return content;
        }
    }
}