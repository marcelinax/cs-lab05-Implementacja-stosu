using System;

namespace Stos
{
    /*public class StosWLiscie<T>: IStos<T>
    {
        private Wezel szczyt;
        public StosWLiscie()
        {
            szczyt = null;
        }

        public T Peek => IsEmpty ? throw new StosEmptyException() : szczyt.dane;

        public T Pop()
        {
            if (IsEmpty)
                throw new StosEmptyException();
            szczyt = szczyt.nastepnik;
        }

        public void Push(T value)
        {
            szczyt = new Wezel(value, szczyt);
        }
        public bool IsEmpty => szczyt == null;
            
        
    }*/
}
