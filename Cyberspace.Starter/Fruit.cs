//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Cyberspace.Starter
//{
//    public class Fruit<T> : IEnumerable<T>
//    {
//        private readonly Fruit<T>[] fruit;
//        public Fruit(T[] _fruit)
//        {
//            fruit = new FruitEnumerator<T>();
//        }
//        public IEnumerator<T> GetEnumerator()
//        {
//            throw new NotImplementedException();
//        }

//        IEnumerator IEnumerable.GetEnumerator()
//        {
//            throw new NotImplementedException();
//        }
//    }

//    public class FruitEnumerator<T> : IEnumerator<T>
//    {
//        private readonly T[] _fruits;
//        public FruitEnumerator(T[] fruits)
//        {
//            _fruits = fruits;
//        }

 

//        private int counter = -1;
//        public T Current => throw new NotImplementedException();

//        object IEnumerator.Current => Current;

//        public void Dispose()
//        {
//            throw new NotImplementedException();
//        }

//        public bool MoveNext()
//        {
//            throw new NotImplementedException();
//        }

//        public void Reset()
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
