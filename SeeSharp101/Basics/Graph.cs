using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharp101.Basics
{
    public class Graph
    {
        // Fields
        private string _name = "Master Graph";
        private string _description = "One Graph to Rule Them All";

        // Properties
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = Name;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = Description;
            }
        }

        //Constructors
        public Graph(string name, string description = "One Graph to Rule Them All")
        {
            Name = name;
            Description = description;
        }
        
    }
}
