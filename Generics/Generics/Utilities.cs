using System;
using System.ComponentModel.Design.Serialization;
using System.Security.Permissions;

namespace Generics
{
    // where T : struct
    //Constraint to value type
    public class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable()
        {
            
        }

        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)_value;

            return default(T);
        }
    }

    // where T : Product
    // where T : class
    //Constraint to a class
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product)
        {
            return product.Price;
        }              
    }



    
    // where T : new()
    // where T : IComparable 
    //Constraint to an Interface and/or default constructor
    public class Utilities<T> where T : IComparable, new()
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T();
        }

        //Can't be done because T is an object not an int.
        //Need to apply constraint 
        //Can be added on the method or on the class itself
        public T Max(T a, T b) //where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
            
        }
    }
}