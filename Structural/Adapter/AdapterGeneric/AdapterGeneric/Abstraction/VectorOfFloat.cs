﻿using AdapterGeneric.Interface;

namespace AdapterGeneric.Abstraction
{
    public class VectorOfFloat<TSelf, D> : Vector<TSelf, float, D>
        where D : IInteger, new()
        where TSelf : Vector<TSelf, float, D>, new()
    {
        public VectorOfFloat() { }

        public VectorOfFloat(params float[] values) : base(values) { }

        public static VectorOfFloat<TSelf, D> operator +(VectorOfFloat<TSelf, D> left, VectorOfFloat<TSelf, D> right)
        {
            var result = new VectorOfFloat<TSelf, D>();
            var dim = new D().Value;

            for (int i = 0; i < dim; i++)
            {
                result[i] = left[i] + right[i];
            }
            return result;
        }
    }
}
