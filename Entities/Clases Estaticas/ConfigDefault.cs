using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public static class ConfigDefault
    {
        public static Color BackDefaultColor;
        public static Color FontDefaultColor;

        static ConfigDefault()
        {
            BackDefaultColor = SystemColors.Control;
            FontDefaultColor = SystemColors.ControlText;
        }
    }
}
