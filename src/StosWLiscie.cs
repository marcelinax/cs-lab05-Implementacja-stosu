using System;

namespace Stos
{
    public class StosWLiscie<T>: IStos<T>
    {
        public StosWLiscie()
        {
            szczyt = null;
        }

        public T Peek
        {
            IsEmpty ? throw new StosEmptyException() : szczyt = new Wezel();
           
        }

        public void Peek()
        {
            if (IsEmpty ? throw new StosEmptyException() : szczyt = szczyt.nastepnik) ;
        }
        public bool IsEmpty => szczyt == -1;
            
        
    }
}