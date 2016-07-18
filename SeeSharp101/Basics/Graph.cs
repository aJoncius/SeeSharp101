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


        // Constructors
        public Graph(string name, string description = "One Graph to Rule Them All")
        {
            Name = name;
            Description = description;
        }
        
    }
}
