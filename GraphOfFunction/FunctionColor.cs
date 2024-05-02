using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphOfFunction
{
    public class FunctionColor
    {
        private String function;
        private Color color;
        public String Function
        {
            get
            {
                return function;
            }
            set
            {
                function = value;
            }
        }
        public Color Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public FunctionColor()
        {

        }

        public FunctionColor(String function, Color color)
        {
            this.function = function;
            this.color = color;
        }

        public override string ToString()
        {
            return function;
        }

    }
}
