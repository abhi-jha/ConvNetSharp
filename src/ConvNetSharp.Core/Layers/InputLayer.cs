﻿using System;
using ConvNetSharp.Flow;

namespace ConvNetSharp.Core.Layers
{
    public class InputLayer<T> : LayerBase<T> where T : struct, IEquatable<T>, IFormattable
    {
        public InputLayer()
        {
            this.Op = ConvNetSharp<T>.PlaceHolder("input");
        }
    }
}