using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    class History
    {
        private List<EditorState> states = new List<EditorState>();

        public void Push(EditorState state)
        {
            states.Add(state);
        }

        public EditorState Pop()
        {
            if(states.Count < 1)
            {
                return new EditorState("");
            }
            var lastState = states.Last();
            states.Remove(lastState);

            return lastState;
        }
    }
}
