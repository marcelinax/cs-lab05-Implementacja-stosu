using System;

namespace Stos
{
    public class StosWLiscie<T>: IStos<T>
    {
        private class Wezel
        {
            public T Dane;
            public Wezel Nastepnik;

           public Wezel(T e, Wezel nastepnik)
            {
                Dane = e;
                Nastepnik = nastepnik;
            }
        }
        private Wezel szczyt;
        private int _count;

        public StosWLiscie()
        {
            szczyt = null;
        }

        public T Peek => IsEmpty ? throw new StosEmptyException() : szczyt.Dane;

        public T Pop()
        {
            if (IsEmpty)
                throw new StosEmptyException();
            szczyt = szczyt.Nastepnik;
            return szczyt.Dane;
        }

        int IStos<T>.Count => _count;
        public int TLength { get; }

        public void Push(T value)
        {
            szczyt = new Wezel(value, szczyt);
        }
        public bool IsEmpty => szczyt == null;

        public void Clear()
        {
            szczyt = null;
        }

        public void TrimExcess()
        {
        }

        public T this[int index] => throw new NotImplementedException();

        public T[] ToArray()
        {
            T[] tr = new T[_count + 1];
            Wezel temp = szczyt;
            for (int i = 0; i < _count; i++)
            {
                tr[i] = szczyt.Dane;
                szczyt = szczyt.Nastepnik;
            }
            return tr;
        }

        public int Count => _count + 1;
            
        
    }
}
