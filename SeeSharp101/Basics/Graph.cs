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

        public bool IsConnected {
            get
            {
                var connected = new bool[AdjacencyMatrix.GetLength(0)];
                Check(0, connected);
                return !connected.Any(b => b == false);
            }

            private set { }
        }

        private void Check(int vertex, IList<bool> connected)
        {
            for (int i = 0; i < AdjacencyMatrix.GetLength(0); i++)
            {
                if (AdjacencyMatrix[vertex, i] == 1 && !connected[i])
                {
                    connected[i] = true;
                    Check(i, connected);
                }
            }
        }

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
