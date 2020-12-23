using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublerWF
{
    
    class Doubler
    {

        public event Action IsGameEnded;
        public event Action Update;

        private int _current = 1;
        private int _steps = 0;
        Stack<int> history = new Stack<int>();
        public int Current { get => _current; }
        public int Finish { get; private set; }
        public int Steps { get => _steps; }
        public int MinimalSteps 
        {
            get
            {
                int finish = Finish;
                int minimalSteps = 0;
                while(finish != 1)
                {
                    finish = finish % 2 == 0 ? finish / 2 : finish - 1;
                    minimalSteps++;
                }
                return minimalSteps;
            }
         }
        public Doubler()
        {
            _current = 1;
            Finish = new Random().Next(10, 101);
            Update?.Invoke();
        }

        public int Plus()
        {
            history.Push(Current);
            _current++;
            _steps++;
            Update?.Invoke();
            IsGameEnded?.Invoke();
            return Current;
        }

        public int Multi()
        {
            history.Push(Current);
            _current *= 2;
            _steps++;
            Update?.Invoke();
            IsGameEnded?.Invoke();
            return Current;
        }

        public void Back()
        {
            if(history.Count != 0) _current = history.Pop();
            _steps--;
            Update?.Invoke();
        }

        public void Reset()
        {
            _current = 1;
            history.Clear();
            _steps = 0;
            Update?.Invoke();
        }

        public override string ToString()
        {
            return Current.ToString();
        }
    }
}
