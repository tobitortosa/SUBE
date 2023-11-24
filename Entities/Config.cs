using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class Config
    {
        private string _username;
        private Color _backgroundColor;
        private Color _fontColor;

        public Config(Color backColor, Color fontColor, string username)
        {
            BackgroundColor = backColor;
            FontColor = fontColor;
            Username = username;
        }

        public Color BackgroundColor { get => _backgroundColor; set => _backgroundColor = value; }
        public string Username { get => _username; set => _username = value; }
        public Color FontColor { get => _fontColor; set => _fontColor = value; }
    }
}
