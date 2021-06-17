using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Team_7_KUKA_arm
{
    class color_picker
    {
        Color[] colors = { Color.Green, Color.Blue, Color.Red, Color.Yellow };

        public Color PickColor(int count)
        {
            return colors[count];
        }
    }
}
