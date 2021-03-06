﻿using System.Collections;
using System.Collections.Generic;

namespace CompositeNeuralNetwork
{
    public class Neuron : IEnumerable<Neuron>
    {
        public float Value;

        public List<Neuron> In, Out;

        public IEnumerator<Neuron> GetEnumerator()
        {
            yield return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
