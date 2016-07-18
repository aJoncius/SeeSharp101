using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharp101.Basics
{
    public class Graph
    {
        private string _name = "Master Graph";
        private string _description = "One Graph to Rule Them All";

        public Graph(string name, string description = "One Graph to Rule Them All")
        {
            _name = name;
            _description = description;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetDescription()
        {
            return _description;
        }
    }
}
