﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    /// <summary>
    /// View of node in tree.
    /// </summary>
    public abstract class Node
    {
        public string Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        
        public abstract double Counting();

        public abstract string Print();
    }
}
