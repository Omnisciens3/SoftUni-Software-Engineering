using System;
using System.Collections.Generic;
using System.Text;

namespace _05.GenericCountMethodString
{
    public class Box<T> where T : IComparable
    {
        public Box(T value)
        {
            Value = value;
        }

        public T Value { get; private set; }

        public override string ToString()
        {
             
            Type valueType = Value.GetType();

            string valueTypeFullName = valueType.FullName;
            return $"{valueTypeFullName}: {Value}";
        }
    }
}
