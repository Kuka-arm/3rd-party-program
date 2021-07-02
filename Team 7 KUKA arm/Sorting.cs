using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_7_KUKA_arm
{
    class Sorting
    {
        string[] inputs = { "Object 1", "Object 2", "Object 3", "Object 4" };
        string[] outputs = { "Location 1", "Location 2", "Location 3", "Location 4" };

        public string[] Inputs { get => inputs; set => inputs = value; }
        public string[] Outputs { get => outputs; set => outputs = value; }
    }
}
