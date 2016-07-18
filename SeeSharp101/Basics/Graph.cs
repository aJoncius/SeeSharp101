using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharp101.Basics
{
    public class Graph
    {
        // Properties
        public string Name { get; private set; }
 
        public string Description { get; private set; }

        public int[,] AdjacencyMatrix { get; private set; }

        public bool IsConnected { get; private set; }

        // Constructors
        public Graph(string name, int[,] adjacencyMatrix, string description = "One Graph to Rule Them All")
        {
            Name = name;
            if (adjacencyMatrix.GetLength(0) != adjacencyMatrix.GetLength(1))
            {
                throw new ArgumentException("Array's dimensions are not equal");
            }
            else
            {
                AdjacencyMatrix = adjacencyMatrix;
            }  
            Description = description;      
        }
        
    }
}
