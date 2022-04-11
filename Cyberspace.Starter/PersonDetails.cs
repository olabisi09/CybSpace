using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberspace.Starter
{
    public class PersonDetails
    {
        public string name = "Olabisi";
        public int age = 20;
        public bool hasKids = false;
    }
    
    public class Addition<E, F>
    {
        public void Add(E par1, F par2, bool x)
        {

        }
    }

    //public class Shape<T>
    //{
    //    public T Par1
    //    {
    //        get;
    //    }
    //}

    //public class Circle<T> : Shape<T>
    //{
    //    public Circle(T num)
    //    {
    //    }
    //}

    //public interface IData
    //{
    //    void Add<T>(T par1);
    //}

    //public class Data<T> : IData
    //{
    //    private T[] _data;
    //    private int _index;

    //    public Data()
    //    {
    //        _data = new T[10];
    //    }

    //    public void Add<D, E>(D par1)
    //    {
    //        _data[_index++] = par1;
    //    }
    //}
}
//Question 131: An interface defines or declares the methods, fields and properties that the
//class will then implement.

//Question 132: An abstract base class can only be inherited by an abstract class,
//and all of them must be inherited.

//Question 133: class NameOfClass : MyBase, ISuppose, IDo{}

//Question 134: is and as operators

//Question 135: the 'is' operator compares two types to determine if they are compatible.
//If they are not, false is returned. The 'as' operator is casting from one type to another.
//If the types are not compatible, null is returned, otherwise the resultant object type is returned.

//Question 136: An interface extends another interface by implementing its properties and
//methods, and can also add its own.

//Question 137: interface MyInterface : AnotherInterface {}

//Question 138: When an interface extends another and implements a method in the parent
//
//it, then they can be overridden in derived classes.

//Question 139: This is implementing an interface by writing its name along with its methods.
//This is to avoid confusion with methods in different interfaces with the same signatures.
