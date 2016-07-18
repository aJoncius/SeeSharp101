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
