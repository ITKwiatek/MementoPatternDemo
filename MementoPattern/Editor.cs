using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    class Editor
    {
        private string content;

        public EditorState CreateState()
        {
            return new EditorState(content);
        }

        public void Restore(EditorState state)
        {
            content = state.GetContent();
        }

        public string GetContent()
        {
            return content;
        }

        public void SetContent(string value)
        {
            content = value;
        }

    }
}
